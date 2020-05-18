using GongSolutions.Shell;
using PIV.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace PIV.Forms
{
	public partial class FrmFolderExplorer : Form
	{

		internal ShellItem CurrentFolder { get; set; }

		/// <summary>
		/// Instantiates the FolderExplorer
		/// </summary>
		public FrmFolderExplorer()
		{
			InitializeComponent();
			if (!string.IsNullOrEmpty(Settings.Default.CurrentlySelectedFolder.FileSystemPath))
				shellView1.CurrentFolder = Settings.Default.CurrentlySelectedFolder;
		}

		/// <summary>
		/// Executed when the BtnDone is Clicked.
		/// Trys to save the Selected Folder to Settings.Default.CurrentlySelectedFolder
		/// </summary>
		/// <remarks>
		/// TODO: Currently does not save the new CurrentlySelectedFolder value.
		/// </remarks>
		private void BtnDone_Click(object sender, EventArgs e)
		{
			CurrentFolder = shellView1.CurrentFolder;
			FileInfo finfo = new FileInfo(CurrentFolder.FileSystemPath);
			Settings.Default.LastFolder = finfo.DirectoryName;
			Settings.Default.CurrentlySelectedFolder = CurrentFolder;
			Settings.Default.Save();
			Settings.Default.Reload();
			Close();
		}
	}
}
