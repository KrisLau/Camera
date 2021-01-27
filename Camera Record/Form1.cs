using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using AForge.Video;
using System.Diagnostics;
using AForge.Video.DirectShow;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Globalization;
using System.Net;

namespace Camera_Record
{
    public partial class frmAddDrugImage : Form
    {
        private byte[] m_CurrentImage;
        private Stopwatch m_Stopwatch = null;
        private FilterInfoCollection m_VideoDevices;
        private VideoCaptureDevice m_VideoDevice;
        private VideoCapabilities[] m_SnapshotCapabilities;
        private ArrayList m_ListCamera = new ArrayList();
        public string m_PathFolder = Application.StartupPath + @"\DrugImageCapture\";
        private static bool m_NeedSnapshot = false;

        public frmAddDrugImage()
        {
            InitializeComponent();
            GetCameraList();
        }

        private static string m_UsbCamera;
        public string UsbCamera
        {
            get { return m_UsbCamera; }
            set { m_UsbCamera = value; }
        }

        #region Methods
        private void btnStart_Click(object sender, EventArgs e)
        {
            OpenCamera();
        }

        private void OpenCamera()
        {        
            try
            {
                UsbCamera = cboVideoSources.SelectedIndex.ToString();
                m_VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (m_VideoDevices.Count != 0)
                {
                    // add all devices to combo
                    foreach (FilterInfo device in m_VideoDevices)
                    {
                        m_ListCamera.Add(device.Name);
                    }
                }
                else
                {
                    MessageBox.Show("Camera devices found");
                }

                m_VideoDevice = new VideoCaptureDevice(m_VideoDevices[Convert.ToInt32(UsbCamera)].MonikerString);
                m_SnapshotCapabilities = m_VideoDevice.SnapshotCapabilities;
                if (m_SnapshotCapabilities.Length == 0)
                {
                    MessageBox.Show("Camera capture not supported");
                }

                OpenVideoSource(m_VideoDevice);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }
        
        //Delegate for capture & update picturebox 
        public delegate void CaptureSnapshot(Bitmap image);
        public void UpdateCaptureSnapshot(Bitmap image)
        {
            try
            {
                m_NeedSnapshot = false;
                pbCapturedImage.Image = image;
                m_CurrentImage = imageToByteArray(pbCapturedImage.Image);
                pbCapturedImage.Update();
            }
            catch
            {
                // No implementation
            }
        }

        public void OpenVideoSource(IVideoSource source)
        {
            try
            {
                // set busy cursor
                this.Cursor = Cursors.WaitCursor;

                // stop current video source
                CloseCurrentVideoSource();

                // start new video source
                vspWebcam.VideoSource = source;
                vspWebcam.Start();

                // reset stop watch
                m_Stopwatch = null;


                this.Cursor = Cursors.Default;
            }
            catch
            {
                // No implementation
            }
        }

        private void GetCameraList()
        {
            m_VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (m_VideoDevices.Count != 0)
            {
                // add all devices to combo
                foreach (FilterInfo device in m_VideoDevices)
                {
                    cboVideoSources.Items.Add(device.Name);

                }
            }
            else
            {
                cboVideoSources.Items.Add("No devices found");
            }

            cboVideoSources.SelectedIndex = 0;
        }

        public void CloseCurrentVideoSource()
        {
            try
            {

                if (vspWebcam.VideoSource != null)
                {
                    vspWebcam.SignalToStop();

                    // wait ~ 3 seconds
                    for (int i = 0; i < 30; i++)
                    {
                        if (!vspWebcam.IsRunning)
                            break;
                        System.Threading.Thread.Sleep(100);
                    }

                    if (vspWebcam.IsRunning)
                    {
                        vspWebcam.Stop();
                    }

                    vspWebcam.VideoSource = null;
                }
            }
            catch { }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        #endregion

        #region Event Handlers
        private void vspWebcam_NewFrame(object sender, ref Bitmap image)
        {
            try
            {
                DateTime now = DateTime.Now;
                Graphics g = Graphics.FromImage(image);

                // paint current time
                SolidBrush brush = new SolidBrush(Color.Red);
                g.DrawString(now.ToString(), this.Font, brush, new PointF(5, 5));
                brush.Dispose();

                if (m_NeedSnapshot)
                {
                    this.Invoke(new CaptureSnapshot(UpdateCaptureSnapshot), image);
                }
                g.Dispose();
            }
            catch
            { }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            m_NeedSnapshot = true;
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            string imageName = "sampleImage";
            string captureName = imageName + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bmp";
            Image imageToSave = byteArrayToImage(m_CurrentImage);

            if(imageToSave != null)
            {
                if (Directory.Exists(m_PathFolder))
                {
                    imageToSave.Save(m_PathFolder + captureName, ImageFormat.Bmp);
                }
                else
                {
                    Directory.CreateDirectory(m_PathFolder);
                    imageToSave.Save(m_PathFolder + captureName, ImageFormat.Bmp);
                }

                MessageBox.Show("Image saved sucessfully as " + captureName, "Sucess");
            }
            else
            {
                MessageBox.Show("Image failed to save.", "Save Failed");
            }
        }

        private void pbRotate_Click(object sender, EventArgs e)
        {
            PictureBox pbSender = (PictureBox)sender;
            Image imageToFlip = byteArrayToImage(m_CurrentImage);

            switch (pbSender.Name)
            {
                case "pbRotate90":
                    imageToFlip.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    UpdateCaptureSnapshot((Bitmap)imageToFlip);
                    break;
                case "pbRotate180":
                    imageToFlip.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    UpdateCaptureSnapshot((Bitmap)imageToFlip);
                    break;
                case "pbRotate270":
                    imageToFlip.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    UpdateCaptureSnapshot((Bitmap)imageToFlip);
                    break;
                default:
                    break;
            }
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            PictureBox pbSender = (PictureBox)sender;
            switch (pbSender.Name)
            {
                case "pbRotate90":
                    pbRotate90.Image = global::Camera_Record.Properties.Resources._90_hover;
                    break;
                case "pbRotate180":
                    pbRotate180.Image = global::Camera_Record.Properties.Resources._180_hover;
                    break;
                case "pbRotate270":
                    pbRotate270.Image = global::Camera_Record.Properties.Resources._270_hover;
                    break;
                case "pbSave":
                    pbSave.Image = global::Camera_Record.Properties.Resources.save_icon_hover;
                    break;
                default:
                    break;
            }
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pbSender = (PictureBox)sender;
            switch (pbSender.Name)
            {
                case "pbRotate90":
                    pbRotate90.Image = global::Camera_Record.Properties.Resources._90_normal;
                    break;
                case "pbRotate180":
                    pbRotate180.Image = global::Camera_Record.Properties.Resources._180_normal;
                    break;
                case "pbRotate270":
                    pbRotate270.Image = global::Camera_Record.Properties.Resources._270_normal;
                    break;
                case "pbSave":
                    pbSave.Image = global::Camera_Record.Properties.Resources.save_icon_1320167995084087448;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
