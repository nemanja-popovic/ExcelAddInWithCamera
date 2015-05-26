namespace ExcelCamAddIn
{
    partial class WinFormsCameraControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTakePicture = new System.Windows.Forms.Button();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.groupBoxCommands = new System.Windows.Forms.GroupBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnResolution = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            this.groupBoxCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTakePicture
            // 
            this.btnTakePicture.Location = new System.Drawing.Point(3, 19);
            this.btnTakePicture.Name = "btnTakePicture";
            this.btnTakePicture.Size = new System.Drawing.Size(275, 23);
            this.btnTakePicture.TabIndex = 1;
            this.btnTakePicture.Text = "Take picture";
            this.btnTakePicture.UseVisualStyleBackColor = true;
            this.btnTakePicture.Click += new System.EventHandler(this.btnTakePicture_Click);
            // 
            // imgVideo
            // 
            this.imgVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgVideo.Location = new System.Drawing.Point(0, 0);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(449, 326);
            this.imgVideo.TabIndex = 2;
            this.imgVideo.TabStop = false;
            // 
            // groupBoxCommands
            // 
            this.groupBoxCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCommands.Controls.Add(this.btnResolution);
            this.groupBoxCommands.Controls.Add(this.btnSettings);
            this.groupBoxCommands.Controls.Add(this.btnTakePicture);
            this.groupBoxCommands.Location = new System.Drawing.Point(0, 332);
            this.groupBoxCommands.Name = "groupBoxCommands";
            this.groupBoxCommands.Size = new System.Drawing.Size(446, 51);
            this.groupBoxCommands.TabIndex = 3;
            this.groupBoxCommands.TabStop = false;
            this.groupBoxCommands.Text = "Commands";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(365, 19);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnResolution
            // 
            this.btnResolution.Location = new System.Drawing.Point(284, 19);
            this.btnResolution.Name = "btnResolution";
            this.btnResolution.Size = new System.Drawing.Size(75, 23);
            this.btnResolution.TabIndex = 3;
            this.btnResolution.Text = "Resolution";
            this.btnResolution.UseVisualStyleBackColor = true;
            this.btnResolution.Click += new System.EventHandler(this.btnResolution_Click);
            // 
            // WinFormsCameraControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxCommands);
            this.Controls.Add(this.imgVideo);
            this.Name = "WinFormsCameraControl";
            this.Size = new System.Drawing.Size(449, 386);
            this.Load += new System.EventHandler(this.WinFormsCameraControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            this.groupBoxCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTakePicture;
        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.GroupBox groupBoxCommands;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnResolution;
    }
}
