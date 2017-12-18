namespace Watermarker
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnSelectWatermark = new System.Windows.Forms.Button();
            this.txtWatermark = new System.Windows.Forms.TextBox();
            this.btnSelectSaveLocation = new System.Windows.Forms.Button();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSaveFormat = new System.Windows.Forms.Label();
            this.txtFiles = new System.Windows.Forms.RichTextBox();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.cbSaveFormat = new System.Windows.Forms.ComboBox();
            this.cbGenerateSmall = new System.Windows.Forms.CheckBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblDemensions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(327, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start watermarking photos";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(11, 73);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(327, 28);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "Select folder to watermark";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(343, 75);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(425, 22);
            this.txtFolder.TabIndex = 3;
            // 
            // btnSelectWatermark
            // 
            this.btnSelectWatermark.Location = new System.Drawing.Point(11, 154);
            this.btnSelectWatermark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectWatermark.Name = "btnSelectWatermark";
            this.btnSelectWatermark.Size = new System.Drawing.Size(327, 28);
            this.btnSelectWatermark.TabIndex = 4;
            this.btnSelectWatermark.Text = "Select watermark";
            this.btnSelectWatermark.UseVisualStyleBackColor = true;
            this.btnSelectWatermark.Click += new System.EventHandler(this.btnSelectWatermark_Click);
            // 
            // txtWatermark
            // 
            this.txtWatermark.Location = new System.Drawing.Point(343, 156);
            this.txtWatermark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWatermark.Name = "txtWatermark";
            this.txtWatermark.ReadOnly = true;
            this.txtWatermark.Size = new System.Drawing.Size(425, 22);
            this.txtWatermark.TabIndex = 5;
            // 
            // btnSelectSaveLocation
            // 
            this.btnSelectSaveLocation.Location = new System.Drawing.Point(11, 113);
            this.btnSelectSaveLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectSaveLocation.Name = "btnSelectSaveLocation";
            this.btnSelectSaveLocation.Size = new System.Drawing.Size(327, 28);
            this.btnSelectSaveLocation.TabIndex = 6;
            this.btnSelectSaveLocation.Text = "Select save location";
            this.btnSelectSaveLocation.UseVisualStyleBackColor = true;
            this.btnSelectSaveLocation.Click += new System.EventHandler(this.btnSelectSaveLocation_Click);
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Location = new System.Drawing.Point(343, 116);
            this.txtSaveLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.ReadOnly = true;
            this.txtSaveLocation.Size = new System.Drawing.Size(425, 22);
            this.txtSaveLocation.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 466);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 17);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "By: Jake Garza";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(345, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 17);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status: Idle";
            // 
            // lblSaveFormat
            // 
            this.lblSaveFormat.AutoSize = true;
            this.lblSaveFormat.Location = new System.Drawing.Point(12, 231);
            this.lblSaveFormat.Name = "lblSaveFormat";
            this.lblSaveFormat.Size = new System.Drawing.Size(88, 17);
            this.lblSaveFormat.TabIndex = 10;
            this.lblSaveFormat.Text = "Save format:";
            // 
            // txtFiles
            // 
            this.txtFiles.Location = new System.Drawing.Point(184, 229);
            this.txtFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.ReadOnly = true;
            this.txtFiles.Size = new System.Drawing.Size(588, 217);
            this.txtFiles.TabIndex = 12;
            this.txtFiles.Text = "";
            // 
            // BGWorker
            // 
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            // 
            // cbSaveFormat
            // 
            this.cbSaveFormat.AllowDrop = true;
            this.cbSaveFormat.FormattingEnabled = true;
            this.cbSaveFormat.Items.AddRange(new object[] {
            "jpg",
            "png",
            "gif",
            "tif"});
            this.cbSaveFormat.Location = new System.Drawing.Point(108, 228);
            this.cbSaveFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSaveFormat.Name = "cbSaveFormat";
            this.cbSaveFormat.Size = new System.Drawing.Size(68, 24);
            this.cbSaveFormat.TabIndex = 13;
            this.cbSaveFormat.Text = "jpg";
            // 
            // cbGenerateSmall
            // 
            this.cbGenerateSmall.AutoSize = true;
            this.cbGenerateSmall.Checked = true;
            this.cbGenerateSmall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGenerateSmall.Location = new System.Drawing.Point(587, 459);
            this.cbGenerateSmall.Name = "cbGenerateSmall";
            this.cbGenerateSmall.Size = new System.Drawing.Size(252, 21);
            this.cbGenerateSmall.TabIndex = 14;
            this.cbGenerateSmall.Text = "Generate Seperate Smaller Images";
            this.cbGenerateSmall.UseVisualStyleBackColor = true;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(405, 460);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(75, 22);
            this.txtWidth.TabIndex = 15;
            this.txtWidth.Text = "300";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(506, 460);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(75, 22);
            this.txtHeight.TabIndex = 16;
            this.txtHeight.Text = "200";
            // 
            // lblDemensions
            // 
            this.lblDemensions.AutoSize = true;
            this.lblDemensions.Location = new System.Drawing.Point(486, 463);
            this.lblDemensions.Name = "lblDemensions";
            this.lblDemensions.Size = new System.Drawing.Size(14, 17);
            this.lblDemensions.TabIndex = 17;
            this.lblDemensions.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 492);
            this.Controls.Add(this.lblDemensions);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.cbGenerateSmall);
            this.Controls.Add(this.cbSaveFormat);
            this.Controls.Add(this.txtFiles);
            this.Controls.Add(this.lblSaveFormat);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSaveLocation);
            this.Controls.Add(this.btnSelectSaveLocation);
            this.Controls.Add(this.txtWatermark);
            this.Controls.Add(this.btnSelectWatermark);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Watermarker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnSelectWatermark;
        private System.Windows.Forms.TextBox txtWatermark;
        private System.Windows.Forms.Button btnSelectSaveLocation;
        private System.Windows.Forms.TextBox txtSaveLocation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSaveFormat;
        private System.Windows.Forms.RichTextBox txtFiles;
        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.ComboBox cbSaveFormat;
        private System.Windows.Forms.CheckBox cbGenerateSmall;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblDemensions;
    }
}

