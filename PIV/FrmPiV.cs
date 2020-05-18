//*****************************************************************************
//*****************************************************************************
//** Application Name: Private Image Viewer [PiV]
//**
//** Description: Allows the viewing of encrypted files without the file ever 
//** being decrypted and saved to disc.
//**
//** Coded By: David Gordon (Zeb)
//** Date: 15th of May 2020
//** License: Open Source WITHOUT ANY warranties.
//*****************************************************************************
//*****************************************************************************

using PIV.Classes;
using PIV.Forms;
using PIV.Properties;
using System;
using System.Windows.Forms;

namespace PIV
{
	public partial class FrmPiV : Form
	{

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
		/// Instantiates the Application
		/// </summary>
		public FrmPiV()
		{
			InitializeComponent();
			DebugOutput("In FrmPiV");
			BtnPrevious.Top = (Height / 2) - (BtnPrevious.Height / 2);
			BtnNext.Top = (Height / 2) - (BtnNext.Height / 2);

			if (string.IsNullOrEmpty(Settings.Default.CurrentlySelectedFolder.FileSystemPath))
				ImageUtilities.LoadImagesFromFolder(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
			else
				ImageUtilities.LoadImagesFromFolder(Settings.Default.CurrentlySelectedFolder.FileSystemPath);

			PbMain.Image = null;
			PbMain.Image = ImageUtilities.GetFirstImage();
			LblCurrentFolder.Text = ImageUtilities.CurrentFolder;
			LblFilename.Text = ImageUtilities.GetCurrentImageName();
		}

		#region ControlBox

		/// <summary>
		/// Closes the program
		/// </summary>
		///<remarks>
		/// Saves the Settings.Default
		/// </remarks>
		private void BtnClose_DoubleClick(object sender, EventArgs e)
		{
			DebugOutput("In BtnClose_DoubleClick");
			Settings.Default.Save();
			Settings.Default.Reload();
			Close();
		}

		/// <summary>
		/// Changes the appearance of the ImageBox on Mouse Over
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnClose_MouseEnter(object sender, EventArgs e)
		{
			DebugOutput("In BtnClose_MouseEnter");
			BtnClose.BorderStyle = BorderStyle.Fixed3D;
			BtnMinimise_MouseLeave(sender, e);
			BtnRestore_MouseLeave(sender, e);
		}

		/// <summary>
		/// Changes the appearance of the ImageBox on Mouse Leave
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnClose_MouseLeave(object sender, EventArgs e)
		{
			DebugOutput("In BtnClose_MouseLeave");
			BtnClose.BorderStyle = BorderStyle.None;
		}

		/// <summary>
		/// Changes the appearance of the ImageBox on Mouse Over
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnRestore_MouseEnter(object sender, EventArgs e)
		{
			DebugOutput("In BtnRestore_MouseEnter");
			BtnRestore.BorderStyle = BorderStyle.Fixed3D;
			BtnMinimise_MouseLeave(sender, e);
			BtnClose_MouseLeave(sender, e);
		}

		/// <summary>
		/// Changes the appearance of the ImageBox on Mouse Leave
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnRestore_MouseLeave(object sender, EventArgs e)
		{
			DebugOutput("In BtnRestore_MouseLeave");
			BtnRestore.BorderStyle = BorderStyle.None;
		}

		/// <summary>
		/// Changes the appearance of the ImageBox on Mouse Over
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnMinimise_MouseEnter(object sender, EventArgs e)
		{
			DebugOutput("In BtnMinimise_MouseEnter");
			BtnMinimise.BorderStyle = BorderStyle.Fixed3D;
			BtnRestore_MouseLeave(sender, e);
			BtnClose_MouseLeave(sender, e);
		}

		/// <summary>
		/// Changes the appearance of the ImageBox on Mouse Leave
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnMinimise_MouseLeave(object sender, EventArgs e)
		{
			DebugOutput("In BtnMinimise_MouseLeave");
			BtnMinimise.BorderStyle = BorderStyle.None;
		}

		#endregion

		#region FolderExplorerTab

		/// <summary>
		/// Opens to folder browser and sets the Main Image
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnFolders_Click(object sender, EventArgs e)
		{
			DebugOutput("In BtnFolders_Click");
			FrmFolderExplorer folderExplorer = new FrmFolderExplorer();
			folderExplorer.ShowDialog();
			ImageUtilities.LoadImagesFromFolder(folderExplorer.CurrentFolder.FileSystemPath);
			PbMain.Image = null;
			PbMain.Image = ImageUtilities.GetFirstImage();
			LblCurrentFolder.Text = ImageUtilities.CurrentFolder;
			LblFilename.Text = ImageUtilities.GetCurrentImageName();
		}

		#endregion

		#region PreviousAndNextButtons

		/// <summary>
		/// Loads the next image when the Next Button is Clicked or
		/// Hides the button and shows a message box when you reach the end of the images to view
		/// </summary>
		private void BtnNext_Click(object sender, EventArgs e)
		{
			DebugOutput("In BtnNext_Click");

			if (ImageUtilities.OutOfRangeForNextIndex)
			{
				BtnNext.Visible = false;
				MessageBox.Show("Reached the end");
			}
			else
			{
				PbMain.Image = null;
				PbMain.Image = ImageUtilities.GetNextImage();
				LblFilename.Text = ImageUtilities.GetCurrentImageName();
				BtnNext.Visible = true;
				BtnPrevious.Visible = true;
			}
		}

		/// <summary>
		/// Loads the previous image when the Previous Button is Clicked or
		/// Hides the button and shows a message box when you reach the begining of the images to view
		/// </summary>
		private void BtnPrevious_Click(object sender, EventArgs e)
		{
			DebugOutput("In BtnPrevious_Click");

			if (ImageUtilities.OutOfRangeForPreviousIndex)
			{
				BtnPrevious.Visible = false;
				MessageBox.Show("Reached the Begining");
			}
			else
			{
				BtnNext.Visible = true;
				BtnPrevious.Visible = true;
				PbMain.Image = null;
				PbMain.Image = ImageUtilities.GetPreviousImage();
				LblFilename.Text = ImageUtilities.GetCurrentImageName();
			}
		}

		#endregion

		#region PbMain's ContextMenuStrip Events

		private string MoveToFolder;
		/// <summary>
		/// Called when the PbMain's (The Main Image) ContextMenuStrip has the "Move To" selection clicked
		/// Opens the folder explorer and moves the image to the selected folder.
		/// Loads the Next Image if there is one.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MoveToToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DebugOutput("In MoveToToolStripMenuItem_Click");

			FrmFolderExplorer folderExplorer = new FrmFolderExplorer();
			folderExplorer.ShowDialog();
			MoveToFolder = folderExplorer.CurrentFolder.FileSystemPath;
			PbMain.Image = null;
			PbMain.Refresh();
			GC.Collect();
			PbMain.Image = ImageUtilities.GetNextImage();
			LblFilename.Text = ImageUtilities.GetCurrentImageName();
			ImageUtilities.Move(MoveToFolder);

		}

		#endregion

	}
}
