namespace PIV.Forms
{
	partial class FrmFolderExplorer
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
			this.BtnDone = new System.Windows.Forms.Button();
			this.shellTreeView1 = new GongSolutions.Shell.ShellTreeView();
			this.shellView1 = new GongSolutions.Shell.ShellView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnDone
			// 
			this.BtnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnDone.FlatAppearance.BorderSize = 0;
			this.BtnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
			this.BtnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
			this.BtnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnDone.Location = new System.Drawing.Point(453, 9);
			this.BtnDone.Name = "BtnDone";
			this.BtnDone.Size = new System.Drawing.Size(75, 23);
			this.BtnDone.TabIndex = 0;
			this.BtnDone.Text = "Done";
			this.BtnDone.UseVisualStyleBackColor = true;
			this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
			// 
			// shellTreeView1
			// 
			this.shellTreeView1.Dock = System.Windows.Forms.DockStyle.Left;
			this.shellTreeView1.Location = new System.Drawing.Point(0, 0);
			this.shellTreeView1.Name = "shellTreeView1";
			this.shellTreeView1.ShellView = this.shellView1;
			this.shellTreeView1.ShowHidden = GongSolutions.Shell.ShowHidden.True;
			this.shellTreeView1.Size = new System.Drawing.Size(260, 450);
			this.shellTreeView1.TabIndex = 1;
			// 
			// shellView1
			// 
			this.shellView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shellView1.Location = new System.Drawing.Point(260, 0);
			this.shellView1.Name = "shellView1";
			this.shellView1.Size = new System.Drawing.Size(540, 450);
			this.shellView1.StatusBar = null;
			this.shellView1.TabIndex = 2;
			this.shellView1.Text = "shellView1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.BtnDone);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(260, 415);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(540, 35);
			this.panel1.TabIndex = 3;
			// 
			// FrmFolderExplorer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.shellView1);
			this.Controls.Add(this.shellTreeView1);
			this.ForeColor = System.Drawing.Color.Gold;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmFolderExplorer";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "FrmFolderExplorer";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnDone;
		private GongSolutions.Shell.ShellTreeView shellTreeView1;
		private GongSolutions.Shell.ShellView shellView1;
		private System.Windows.Forms.Panel panel1;
	}
}