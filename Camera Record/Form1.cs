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
    public partial class Form1 : Form
    {
        private Stopwatch m_Stopwatch = null;
        private FilterInfoCollection m_VideoDevices;
        private VideoCaptureDevice m_VideoDevice;
        private VideoCapabilities[] m_SnapshotCapabilities;
        private ArrayList m_ListCamera = new ArrayList();
        public string m_PathFolder = Application.StartupPath + @"\DrugImageCapture\";
        private static bool m_NeedSnapshot = false;

        public Form1()
        {
            InitializeComponent();
            getCameraList();
        }

        private static string m_UsbCamera;
        public string UsbCamera
        {
            get { return m_UsbCamera; }
            set { m_UsbCamera = value; }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            OpenCamera();
        }

        #region Open Scan Camera
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
        #endregion


        //Delegate for capture, insert database, update picturebox 
        public delegate void CaptureSnapshot(Bitmap image);
        public void UpdateCaptureSnapshot(Bitmap image)
        {
            try
            {
                m_NeedSnapshot = false;
                pbCapturedImage.Image = image;
                pbCapturedImage.Update();

               
                string imageName = "sampleImage";
                string captureName = imageName + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bmp";

                if (Directory.Exists(m_PathFolder))
                {
                    pbCapturedImage.Image.Save(m_PathFolder + captureName, ImageFormat.Bmp);
                }
                else
                {
                    Directory.CreateDirectory(m_PathFolder);
                    pbCapturedImage.Image.Save(m_PathFolder + captureName, ImageFormat.Bmp);
                }
            }

            catch { }

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
            catch { }
        }

        private void getCameraList()
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

        private void btnCapture_Click(object sender, EventArgs e)
        {
            m_NeedSnapshot = true;
        }

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
    }
}
