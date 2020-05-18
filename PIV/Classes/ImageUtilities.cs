using PIV.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PIV.Classes
{
	class ImageUtilities
	{
		private static readonly Dictionary<int, string> LoadedImages = new Dictionary<int, string>();
		private static int LoadedImagesCounter = 0;
		private static int CurrentImageCounter = 0;
		private static int PreviousImageCounter = 0;

		public static bool OutOfRangeForNextIndex { get; internal set; }
		public static bool OutOfRangeForPreviousIndex { get; internal set; }
		public static string CurrentFolder { get; internal set; }
		public static string CurrentImage { get; set; }
		private static string PreviousImage { get; set; }
		public static string CurrentImageName { get; internal set; }

		/// <summary>
		/// Provides a Console output of errors and other debug information.
		/// </summary>
		/// <param name="v">
		/// string: The message to be displayed
		/// </param>
		private static void DebugOutput(string v)
		{
#if DEBUG
			Console.WriteLine(v);
#endif
		}

		/// <summary>
		/// Loads all the images from the supplied folder
		/// </summary>
		/// <param name="Folder">
		/// string: The path of the folder to load images from
		/// </param>
		internal static void LoadImagesFromFolder(string Folder)
		{
			DebugOutput("In ImageUtilities.LoadImagesFromFolder");

			if (string.IsNullOrEmpty(Folder) & string.IsNullOrEmpty(Settings.Default.LastFolder))
				return;
			else
				if (!string.IsNullOrEmpty(Settings.Default.LastFolder))
				CurrentFolder = Settings.Default.LastFolder;
			else
				CurrentFolder = Folder;

			Settings.Default.LastFolder = CurrentFolder;
			Settings.Default.Save();

			LoadedImages.Clear();
			CurrentImageCounter = 0;
			LoadedImagesCounter = 0;

			string[] filenames = Directory.GetFiles(Folder, "*", SearchOption.AllDirectories);
			foreach (string filename in filenames)
			{
				if (FilenameIsImage(filename))
				{
					LoadedImages.Add(LoadedImagesCounter, filename);
					LoadedImagesCounter++;
					Application.DoEvents();
				}
			}
		}

		/// <summary>
		/// Checks to see if the filename supplied is an image
		/// </summary>
		/// <param name="filename">
		/// string: The filename to check to see if it is an image or not
		/// </param>
		/// <returns>
		/// bool: True if the filename is an image
		/// bool: False if the filename is not an image
		/// </returns>
		/// <remarks>
		/// TODO: We should really check the file more thoroughly to see if files without extensions are actually images
		/// </remarks>
		private static bool FilenameIsImage(string filename)
		{
			DebugOutput("In ImageUtilities.FilenameIsImage");

			FileInfo fileInfo = new FileInfo(filename);
			switch (fileInfo.Extension.ToLowerInvariant())
			{
				case ".gif":
					return true;
				case ".jpg":
					return true;
				case ".jpeg":
					return true;
				case ".jfif":
					return true;
				case ".png":
					return true;
				case ".webp":
					return true;
				case ".tif":
					return true;
				case ".tiff":
					return true;

				default:
					return false;
			}
		}

		/// <summary>
		/// Loads the first image from LoadedImages
		/// </summary>
		/// <returns>
		/// Image: The actual image of the file
		/// </returns>
		internal static Image GetFirstImage()
		{
			DebugOutput("In ImageUtilities.GetFirstImage");

			PreviousImage = CurrentImage;
			PreviousImageCounter = CurrentImageCounter;

			if (LoadedImages.TryGetValue(CurrentImageCounter, out string filename))
			{
				OutOfRangeForNextIndex = false;
				OutOfRangeForPreviousIndex = false;
				CurrentImage = filename;
				Image tmpImage = Image.FromFile(filename);
				return tmpImage;
			}

			// Means there are NO Images to display.
			OutOfRangeForNextIndex = true;
			OutOfRangeForPreviousIndex = true;
			return null;
		}

		/// <summary>
		/// Loads the Next Image from LoadedImages
		/// </summary>
		/// <returns>
		/// Image: The actual image of the file
		/// </returns>
		internal static Image GetNextImage()
		{
			DebugOutput("In ImageUtilities.GetNextImage");

			PreviousImage = CurrentImage;
			PreviousImageCounter = CurrentImageCounter;

			++CurrentImageCounter;
			if (LoadedImages.TryGetValue(CurrentImageCounter, out string filename))
			{
				OutOfRangeForNextIndex = false;
				CurrentImage = filename;
				Image tmpImage = Image.FromFile(filename);
				return tmpImage;
			}
			OutOfRangeForNextIndex = true;
			return null;
		}

		/// <summary>
		/// Loads the Previous Image from LoadedImages
		/// </summary>
		/// <returns>
		/// Image: The actual image of the file
		/// </returns>
		internal static Image GetPreviousImage()
		{
			DebugOutput("In ImageUtilities.GetPreviousImage");

			PreviousImage = CurrentImage;
			PreviousImageCounter = CurrentImageCounter;

			--CurrentImageCounter;
			if (LoadedImages.TryGetValue(CurrentImageCounter, out string filename))
			{
				OutOfRangeForPreviousIndex = false;
				CurrentImage = filename;
				Image tmpImage = Image.FromFile(filename);
				return tmpImage;
			}
			OutOfRangeForPreviousIndex = true;
			return null;
		}

		/// <summary>
		/// Moves the CurrentImage to the moveToFolder supplied
		/// </summary>
		/// <param name="moveToFolder">
		/// string: The destination of the move command.
		/// </param>
		internal static void Move(string moveToFolder)
		{
			DebugOutput("In ImageUtilities.Move");

			FileInfo finfo = new FileInfo(PreviousImage);
			if (PreviousImage.ToLowerInvariant() != Path.Combine(moveToFolder.ToLowerInvariant(), finfo.Name.ToLowerInvariant()))
			{
				try
				{
					File.Move(PreviousImage, Path.Combine(moveToFolder, finfo.Name));
				}
				catch (IOException iox)
				{
					if (!GenerateNewFilenameAndMove(moveToFolder))
					{
						DebugOutput("ERROR: ImageUtilities.Move " + iox.Message);
					}
				}

				RemoveCurrentImageFromDictionary();
			}
		}

		/// <summary>
		/// Removes the current image from LoadedImages
		/// </summary>
		private static void RemoveCurrentImageFromDictionary()
		{
			DebugOutput("In ImageUtilities.RemoveCurrentImageFromDictionary");
			LoadedImages.Remove(PreviousImageCounter);
			//TODO: Remove the file from the "Other Process"
			// File.Delete(PreviousImage);
		}

		/// <summary>
		/// Attempts to Generate a New Filename if it already exists in the destination folder supplied.
		/// </summary>
		/// <param name="moveToFolder">
		/// string: The destination folder of the move command.
		/// </param>
		/// <returns>
		/// bool: true is always currently returned
		/// </returns>
		private static bool GenerateNewFilenameAndMove(string moveToFolder)
		{
			DebugOutput("In ImageUtilities.GenerateNewFilenameAndMove");

			bool NotValid;
			int idx = 1;
			FileInfo finfo = new FileInfo(PreviousImage);
			string currentImage = finfo.Name;


			do
			{
				if (File.Exists(Path.Combine(moveToFolder, currentImage)))
				{

					currentImage = finfo.Name.Replace(finfo.Extension, "[" + idx + "]" + finfo.Extension);
					idx++;
					NotValid = true;
				}
				else
				{
					try
					{
						File.Move(PreviousImage, Path.Combine(moveToFolder, currentImage));
					}
					catch (IOException iox)
					{
						DebugOutput("ERROR ImageUtilities.GenerateNewFilenameAndMove: " + iox.Message);
					}

					NotValid = false;
				}

			} while (NotValid);
			return true;
		}

		/// <summary>
		/// Gets the CurrentImage name
		/// </summary>
		/// <returns>
		/// string: The actual name without directory path of the current image
		/// </returns>
		internal static string GetCurrentImageName()
		{
			if (string.IsNullOrEmpty(CurrentImage))
				return string.Empty;
			else
			{
				FileInfo finfo = new FileInfo(CurrentImage);
				return finfo.Name;
			}
		}
	}
}
