namespace PIV
{
	partial class FrmPiV
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.PanelForPbMain = new System.Windows.Forms.Panel();
			this.PbMain = new System.Windows.Forms.PictureBox();
			this.CmsPbMain = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.moveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.LblFilename = new System.Windows.Forms.Label();
			this.BtnMinimise = new System.Windows.Forms.PictureBox();
			this.BtnRestore = new System.Windows.Forms.PictureBox();
			this.BtnClose = new System.Windows.Forms.PictureBox();
			this.BtnNext = new System.Windows.Forms.Button();
			this.BtnPrevious = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BtnFolders = new System.Windows.Forms.Button();
			this.LblCurrentFolder = new System.Windows.Forms.Label();
			this.PanelForPbMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbMain)).BeginInit();
			this.CmsPbMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BtnMinimise)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BtnRestore)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// PanelForPbMain
			// 
			this.PanelForPbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.PanelForPbMain.AutoScroll = true;
			this.PanelForPbMain.Controls.Add(this.PbMain);
			this.PanelForPbMain.ForeColor = System.Drawing.Color.Black;
			this.PanelForPbMain.Location = new System.Drawing.Point(83, 43);
			this.PanelForPbMain.Name = "PanelForPbMain";
			this.PanelForPbMain.Size = new System.Drawing.Size(635, 379);
			this.PanelForPbMain.TabIndex = 1;
			// 
			// PbMain
			// 
			this.PbMain.ContextMenuStrip = this.CmsPbMain;
			this.PbMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PbMain.Location = new System.Drawing.Point(0, 0);
			this.PbMain.Name = "PbMain";
			this.PbMain.Size = new System.Drawing.Size(635, 379);
			this.PbMain.TabIndex = 0;
			this.PbMain.TabStop = false;
			// 
			// CmsPbMain
			// 
			this.CmsPbMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.CmsPbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.moveToToolStripMenuItem});
			this.CmsPbMain.Name = "CmsPbMain";
			this.CmsPbMain.Size = new System.Drawing.Size(136, 28);
			// 
			// moveToToolStripMenuItem
			// 
			this.moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
			this.moveToToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
			this.moveToToolStripMenuItem.Text = "Move To";
			this.moveToToolStripMenuItem.Click += new System.EventHandler(this.MoveToToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 425);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Filename";
			// 
			// LblFilename
			// 
			this.LblFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.LblFilename.AutoEllipsis = true;
			this.LblFilename.Location = new System.Drawing.Point(83, 425);
			this.LblFilename.Name = "LblFilename";
			this.LblFilename.Size = new System.Drawing.Size(705, 17);
			this.LblFilename.TabIndex = 5;
			this.LblFilename.Text = "...";
			// 
			// BtnMinimise
			// 
			this.BtnMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMinimise.Image = global::PIV.Properties.Resources.subtract;
			this.BtnMinimise.Location = new System.Drawing.Point(696, 2);
			this.BtnMinimise.MaximumSize = new System.Drawing.Size(30, 30);
			this.BtnMinimise.MinimumSize = new System.Drawing.Size(30, 30);
			this.BtnMinimise.Name = "BtnMinimise";
			this.BtnMinimise.Size = new System.Drawing.Size(30, 30);
			this.BtnMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.BtnMinimise.TabIndex = 8;
			this.BtnMinimise.TabStop = false;
			this.BtnMinimise.MouseEnter += new System.EventHandler(this.BtnMinimise_MouseEnter);
			this.BtnMinimise.MouseLeave += new System.EventHandler(this.BtnMinimise_MouseLeave);
			// 
			// BtnRestore
			// 
			this.BtnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnRestore.Image = global::PIV.Properties.Resources.newwindow;
			this.BtnRestore.Location = new System.Drawing.Point(732, 2);
			this.BtnRestore.MaximumSize = new System.Drawing.Size(30, 30);
			this.BtnRestore.MinimumSize = new System.Drawing.Size(30, 30);
			this.BtnRestore.Name = "BtnRestore";
			this.BtnRestore.Size = new System.Drawing.Size(30, 30);
			this.BtnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.BtnRestore.TabIndex = 7;
			this.BtnRestore.TabStop = false;
			this.BtnRestore.MouseEnter += new System.EventHandler(this.BtnRestore_MouseEnter);
			this.BtnRestore.MouseLeave += new System.EventHandler(this.BtnRestore_MouseLeave);
			// 
			// BtnClose
			// 
			this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnClose.Image = global::PIV.Properties.Resources.close;
			this.BtnClose.Location = new System.Drawing.Point(768, 2);
			this.BtnClose.MaximumSize = new System.Drawing.Size(30, 30);
			this.BtnClose.MinimumSize = new System.Drawing.Size(30, 30);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(30, 30);
			this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.BtnClose.TabIndex = 6;
			this.BtnClose.TabStop = false;
			this.BtnClose.DoubleClick += new System.EventHandler(this.BtnClose_DoubleClick);
			this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
			this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
			// 
			// BtnNext
			// 
			this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.BtnNext.FlatAppearance.BorderSize = 0;
			this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnNext.Image = global::PIV.Properties.Resources.arrow2_e;
			this.BtnNext.Location = new System.Drawing.Point(742, 213);
			this.BtnNext.Name = "BtnNext";
			this.BtnNext.Size = new System.Drawing.Size(37, 35);
			this.BtnNext.TabIndex = 3;
			this.BtnNext.UseVisualStyleBackColor = true;
			this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
			// 
			// BtnPrevious
			// 
			this.BtnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BtnPrevious.FlatAppearance.BorderSize = 0;
			this.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPrevious.Image = global::PIV.Properties.Resources.arrow2_w;
			this.BtnPrevious.Location = new System.Drawing.Point(24, 213);
			this.BtnPrevious.Name = "BtnPrevious";
			this.BtnPrevious.Size = new System.Drawing.Size(35, 35);
			this.BtnPrevious.TabIndex = 2;
			this.BtnPrevious.UseVisualStyleBackColor = true;
			this.BtnPrevious.Visible = false;
			this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PIV.Properties.Resources.Cat;
			this.pictureBox1.Location = new System.Drawing.Point(2, 1);
			this.pictureBox1.MaximumSize = new System.Drawing.Size(30, 30);
			this.pictureBox1.MinimumSize = new System.Drawing.Size(30, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(30, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// BtnFolders
			// 
			this.BtnFolders.FlatAppearance.BorderSize = 0;
			this.BtnFolders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
			this.BtnFolders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
			this.BtnFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnFolders.Location = new System.Drawing.Point(83, 2);
			this.BtnFolders.Name = "BtnFolders";
			this.BtnFolders.Size = new System.Drawing.Size(75, 23);
			this.BtnFolders.TabIndex = 9;
			this.BtnFolders.Text = "Folders";
			this.BtnFolders.UseVisualStyleBackColor = true;
			this.BtnFolders.Click += new System.EventHandler(this.BtnFolders_Click);
			// 
			// LblCurrentFolder
			// 
			this.LblCurrentFolder.AutoSize = true;
			this.LblCurrentFolder.Location = new System.Drawing.Point(94, 23);
			this.LblCurrentFolder.Name = "LblCurrentFolder";
			this.LblCurrentFolder.Size = new System.Drawing.Size(20, 17);
			this.LblCurrentFolder.TabIndex = 10;
			this.LblCurrentFolder.Text = "...";
			// 
			// FrmPiV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LblCurrentFolder);
			this.Controls.Add(this.BtnFolders);
			this.Controls.Add(this.BtnMinimise);
			this.Controls.Add(this.BtnRestore);
			this.Controls.Add(this.BtnClose);
			this.Controls.Add(this.LblFilename);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnNext);
			this.Controls.Add(this.BtnPrevious);
			this.Controls.Add(this.PanelForPbMain);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.Color.Gold;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmPiV";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.PanelForPbMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PbMain)).EndInit();
			this.CmsPbMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BtnMinimise)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BtnRestore)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel PanelForPbMain;
		private System.Windows.Forms.Button BtnPrevious;
		private System.Windows.Forms.Button BtnNext;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LblFilename;
		private System.Windows.Forms.PictureBox BtnClose;
		private System.Windows.Forms.PictureBox BtnRestore;
		private System.Windows.Forms.PictureBox BtnMinimise;
		private System.Windows.Forms.PictureBox PbMain;
		private System.Windows.Forms.Button BtnFolders;
		private System.Windows.Forms.ContextMenuStrip CmsPbMain;
		private System.Windows.Forms.ToolStripMenuItem moveToToolStripMenuItem;
		private System.Windows.Forms.Label LblCurrentFolder;
	}
}

