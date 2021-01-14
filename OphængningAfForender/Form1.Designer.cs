namespace OphængningAfForender
{
	partial class Form1
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageMain = new System.Windows.Forms.TabPage();
			this.tabPageCalibration = new System.Windows.Forms.TabPage();
			this.tabPageCommunication = new System.Windows.Forms.TabPage();
			this.tabPageShowImage = new System.Windows.Forms.TabPage();
			this.tabPageResults = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageMain);
			this.tabControl1.Controls.Add(this.tabPageCalibration);
			this.tabControl1.Controls.Add(this.tabPageCommunication);
			this.tabControl1.Controls.Add(this.tabPageShowImage);
			this.tabControl1.Controls.Add(this.tabPageResults);
			this.tabControl1.Location = new System.Drawing.Point(12, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1909, 1006);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageMain
			// 
			this.tabPageMain.Location = new System.Drawing.Point(4, 22);
			this.tabPageMain.Name = "tabPageMain";
			this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMain.Size = new System.Drawing.Size(1901, 980);
			this.tabPageMain.TabIndex = 0;
			this.tabPageMain.Text = "Main";
			this.tabPageMain.UseVisualStyleBackColor = true;
			// 
			// tabPageCalibration
			// 
			this.tabPageCalibration.Location = new System.Drawing.Point(4, 22);
			this.tabPageCalibration.Name = "tabPageCalibration";
			this.tabPageCalibration.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCalibration.Size = new System.Drawing.Size(1361, 566);
			this.tabPageCalibration.TabIndex = 1;
			this.tabPageCalibration.Text = "Calibration";
			this.tabPageCalibration.UseVisualStyleBackColor = true;
			// 
			// tabPageCommunication
			// 
			this.tabPageCommunication.Location = new System.Drawing.Point(4, 22);
			this.tabPageCommunication.Name = "tabPageCommunication";
			this.tabPageCommunication.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCommunication.Size = new System.Drawing.Size(1361, 566);
			this.tabPageCommunication.TabIndex = 2;
			this.tabPageCommunication.Text = "Communication";
			this.tabPageCommunication.UseVisualStyleBackColor = true;
			// 
			// tabPageShowImage
			// 
			this.tabPageShowImage.Location = new System.Drawing.Point(4, 22);
			this.tabPageShowImage.Name = "tabPageShowImage";
			this.tabPageShowImage.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageShowImage.Size = new System.Drawing.Size(1901, 980);
			this.tabPageShowImage.TabIndex = 3;
			this.tabPageShowImage.Text = "Show Image";
			this.tabPageShowImage.UseVisualStyleBackColor = true;
			// 
			// tabPageResults
			// 
			this.tabPageResults.Location = new System.Drawing.Point(4, 22);
			this.tabPageResults.Name = "tabPageResults";
			this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageResults.Size = new System.Drawing.Size(1901, 980);
			this.tabPageResults.TabIndex = 4;
			this.tabPageResults.Text = "Results ";
			this.tabPageResults.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 1011);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageMain;
		private System.Windows.Forms.TabPage tabPageCalibration;
		private System.Windows.Forms.TabPage tabPageCommunication;
		private System.Windows.Forms.TabPage tabPageShowImage;
		private System.Windows.Forms.TabPage tabPageResults;
	}
}

