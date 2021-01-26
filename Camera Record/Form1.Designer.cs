namespace Camera_Record
{
    partial class frmAddDrugImage
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
            this.vspWebcam = new AForge.Controls.VideoSourcePlayer();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.cboVideoSources = new System.Windows.Forms.ComboBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbRotate270 = new System.Windows.Forms.PictureBox();
            this.pbRotate180 = new System.Windows.Forms.PictureBox();
            this.pbRotate90 = new System.Windows.Forms.PictureBox();
            this.pbCapturedImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotate270)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotate180)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotate90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // vspWebcam
            // 
            this.vspWebcam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vspWebcam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vspWebcam.Location = new System.Drawing.Point(22, 25);
            this.vspWebcam.Margin = new System.Windows.Forms.Padding(4);
            this.vspWebcam.MaximumSize = new System.Drawing.Size(288, 216);
            this.vspWebcam.MinimumSize = new System.Drawing.Size(288, 216);
            this.vspWebcam.Name = "vspWebcam";
            this.vspWebcam.Size = new System.Drawing.Size(288, 216);
            this.vspWebcam.TabIndex = 5;
            this.vspWebcam.VideoSource = null;
            this.vspWebcam.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.vspWebcam_NewFrame);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(183, 260);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 26);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Camera";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(434, 260);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(102, 26);
            this.btnCapture.TabIndex = 3;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // cboVideoSources
            // 
            this.cboVideoSources.FormattingEnabled = true;
            this.cboVideoSources.Location = new System.Drawing.Point(22, 260);
            this.cboVideoSources.Margin = new System.Windows.Forms.Padding(4);
            this.cboVideoSources.Name = "cboVideoSources";
            this.cboVideoSources.Size = new System.Drawing.Size(148, 24);
            this.cboVideoSources.TabIndex = 4;
            // 
            // pbSave
            // 
            this.pbSave.Image = global::Camera_Record.Properties.Resources.save_icon_1320167995084087448;
            this.pbSave.Location = new System.Drawing.Point(635, 190);
            this.pbSave.Margin = new System.Windows.Forms.Padding(4);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(32, 26);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 35;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            this.pbSave.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pbSave.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pbRotate270
            // 
            this.pbRotate270.Image = global::Camera_Record.Properties.Resources._270_normal;
            this.pbRotate270.Location = new System.Drawing.Point(635, 142);
            this.pbRotate270.Margin = new System.Windows.Forms.Padding(4);
            this.pbRotate270.Name = "pbRotate270";
            this.pbRotate270.Size = new System.Drawing.Size(32, 26);
            this.pbRotate270.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbRotate270.TabIndex = 32;
            this.pbRotate270.TabStop = false;
            this.pbRotate270.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pbRotate270.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pbRotate180
            // 
            this.pbRotate180.Image = global::Camera_Record.Properties.Resources._180_normal;
            this.pbRotate180.Location = new System.Drawing.Point(635, 94);
            this.pbRotate180.Margin = new System.Windows.Forms.Padding(4);
            this.pbRotate180.Name = "pbRotate180";
            this.pbRotate180.Size = new System.Drawing.Size(32, 26);
            this.pbRotate180.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbRotate180.TabIndex = 31;
            this.pbRotate180.TabStop = false;
            this.pbRotate180.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pbRotate180.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pbRotate90
            // 
            this.pbRotate90.Image = global::Camera_Record.Properties.Resources._90_normal;
            this.pbRotate90.Location = new System.Drawing.Point(635, 46);
            this.pbRotate90.Margin = new System.Windows.Forms.Padding(4);
            this.pbRotate90.Name = "pbRotate90";
            this.pbRotate90.Size = new System.Drawing.Size(32, 26);
            this.pbRotate90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbRotate90.TabIndex = 30;
            this.pbRotate90.TabStop = false;
            this.pbRotate90.Click += new System.EventHandler(this.pbRotate_Click);
            this.pbRotate90.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pbRotate90.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pbCapturedImage
            // 
            this.pbCapturedImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbCapturedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCapturedImage.Location = new System.Drawing.Point(333, 25);
            this.pbCapturedImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbCapturedImage.MaximumSize = new System.Drawing.Size(288, 216);
            this.pbCapturedImage.MinimumSize = new System.Drawing.Size(288, 216);
            this.pbCapturedImage.Name = "pbCapturedImage";
            this.pbCapturedImage.Size = new System.Drawing.Size(288, 216);
            this.pbCapturedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCapturedImage.TabIndex = 2;
            this.pbCapturedImage.TabStop = false;
            // 
            // frmAddDrugImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 305);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbRotate270);
            this.Controls.Add(this.pbRotate180);
            this.Controls.Add(this.pbRotate90);
            this.Controls.Add(this.vspWebcam);
            this.Controls.Add(this.cboVideoSources);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.pbCapturedImage);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddDrugImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Drug Image";
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotate270)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotate180)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotate90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCapturedImage;
        private AForge.Controls.VideoSourcePlayer vspWebcam;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.ComboBox cboVideoSources;
        private System.Windows.Forms.PictureBox pbRotate270;
        private System.Windows.Forms.PictureBox pbRotate180;
        private System.Windows.Forms.PictureBox pbRotate90;
        private System.Windows.Forms.PictureBox pbSave;
    }
}

