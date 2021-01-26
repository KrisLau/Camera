namespace Camera_Record
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
            this.pbCapturedImage = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.cboVideoSources = new System.Windows.Forms.ComboBox();
            this.vspWebcam = new AForge.Controls.VideoSourcePlayer();
            this.lblCapturedImage = new System.Windows.Forms.Label();
            this.lblWebcam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(433, 142);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 33);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbCapturedImage
            // 
            this.pbCapturedImage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbCapturedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCapturedImage.Location = new System.Drawing.Point(591, 87);
            this.pbCapturedImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbCapturedImage.Name = "pbCapturedImage";
            this.pbCapturedImage.Size = new System.Drawing.Size(409, 281);
            this.pbCapturedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCapturedImage.TabIndex = 2;
            this.pbCapturedImage.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(433, 212);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(144, 33);
            this.btnCapture.TabIndex = 3;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // cboVideoSources
            // 
            this.cboVideoSources.FormattingEnabled = true;
            this.cboVideoSources.Location = new System.Drawing.Point(433, 87);
            this.cboVideoSources.Margin = new System.Windows.Forms.Padding(4);
            this.cboVideoSources.Name = "cboVideoSources";
            this.cboVideoSources.Size = new System.Drawing.Size(148, 24);
            this.cboVideoSources.TabIndex = 4;
            // 
            // vspWebcam
            // 
            this.vspWebcam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vspWebcam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.vspWebcam.Location = new System.Drawing.Point(16, 87);
            this.vspWebcam.Margin = new System.Windows.Forms.Padding(4);
            this.vspWebcam.Name = "vspWebcam";
            this.vspWebcam.Size = new System.Drawing.Size(409, 282);
            this.vspWebcam.TabIndex = 5;
            this.vspWebcam.VideoSource = null;
            this.vspWebcam.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.vspWebcam_NewFrame);
            // 
            // lblCapturedImage
            // 
            this.lblCapturedImage.AutoSize = true;
            this.lblCapturedImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapturedImage.Location = new System.Drawing.Point(587, 36);
            this.lblCapturedImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapturedImage.Name = "lblCapturedImage";
            this.lblCapturedImage.Size = new System.Drawing.Size(141, 20);
            this.lblCapturedImage.TabIndex = 6;
            this.lblCapturedImage.Text = "Captured Image";
            // 
            // lblWebcam
            // 
            this.lblWebcam.AutoSize = true;
            this.lblWebcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebcam.Location = new System.Drawing.Point(28, 36);
            this.lblWebcam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWebcam.Name = "lblWebcam";
            this.lblWebcam.Size = new System.Drawing.Size(81, 20);
            this.lblWebcam.TabIndex = 7;
            this.lblWebcam.Text = "Webcam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 393);
            this.Controls.Add(this.lblWebcam);
            this.Controls.Add(this.lblCapturedImage);
            this.Controls.Add(this.vspWebcam);
            this.Controls.Add(this.cboVideoSources);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.pbCapturedImage);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbCapturedImage;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.ComboBox cboVideoSources;
        private AForge.Controls.VideoSourcePlayer vspWebcam;
        private System.Windows.Forms.Label lblCapturedImage;
        private System.Windows.Forms.Label lblWebcam;
    }
}

