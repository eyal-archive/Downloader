namespace Downloader
{
	public partial class DownloaderForm
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
			this.uxProgressBar = new System.Windows.Forms.ProgressBar();
			this.uxDownloadButton = new System.Windows.Forms.Button();
			this.uxCancelButton = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.uxCounter = new System.Windows.Forms.ToolStripStatusLabel();
			this.uxPauseButton = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// uxProgressBar
			// 
			this.uxProgressBar.Location = new System.Drawing.Point(16, 15);
			this.uxProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.uxProgressBar.Name = "uxProgressBar";
			this.uxProgressBar.Size = new System.Drawing.Size(179, 28);
			this.uxProgressBar.TabIndex = 0;
			// 
			// uxDownloadButton
			// 
			this.uxDownloadButton.Location = new System.Drawing.Point(16, 50);
			this.uxDownloadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.uxDownloadButton.Name = "uxDownloadButton";
			this.uxDownloadButton.Size = new System.Drawing.Size(179, 28);
			this.uxDownloadButton.TabIndex = 1;
			this.uxDownloadButton.Text = "Download";
			this.uxDownloadButton.UseVisualStyleBackColor = true;
			this.uxDownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
			// 
			// uxCancelButton
			// 
			this.uxCancelButton.Enabled = false;
			this.uxCancelButton.Location = new System.Drawing.Point(16, 86);
			this.uxCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.uxCancelButton.Name = "uxCancelButton";
			this.uxCancelButton.Size = new System.Drawing.Size(179, 28);
			this.uxCancelButton.TabIndex = 2;
			this.uxCancelButton.Text = "Cancel";
			this.uxCancelButton.UseVisualStyleBackColor = true;
			this.uxCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxCounter});
			this.statusStrip1.Location = new System.Drawing.Point(0, 170);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(211, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// uxCounter
			// 
			this.uxCounter.Name = "uxCounter";
			this.uxCounter.Size = new System.Drawing.Size(0, 17);
			// 
			// uxPauseButton
			// 
			this.uxPauseButton.Enabled = false;
			this.uxPauseButton.Location = new System.Drawing.Point(16, 121);
			this.uxPauseButton.Name = "uxPauseButton";
			this.uxPauseButton.Size = new System.Drawing.Size(179, 28);
			this.uxPauseButton.TabIndex = 4;
			this.uxPauseButton.Text = "Pause";
			this.uxPauseButton.UseVisualStyleBackColor = true;
			// 
			// DownloaderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(211, 192);
			this.Controls.Add(this.uxPauseButton);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.uxCancelButton);
			this.Controls.Add(this.uxDownloadButton);
			this.Controls.Add(this.uxProgressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "DownloaderForm";
			this.Text = "Downloader";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar uxProgressBar;
		private System.Windows.Forms.Button uxDownloadButton;
		private System.Windows.Forms.Button uxCancelButton;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel uxCounter;
		private System.Windows.Forms.Button uxPauseButton;
	}
}

