using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Text.RegularExpressions;
using System.Threading;

namespace F6Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        camera cam2;
        camera cam1;
        string geigerData="";

        private string stageBtnPressed;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form Location
            this.Location = new Point(0, 0);
            // Camera
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                cmbxCam1.Items.Add(device.Name);

            cam1 = new camera(picCam1);
            cam2 = new camera(picCam2);


            txtbxDelay.Text = "500";


            // Initialize Geiger
            commGeiger.baudrate = 115200;
            commGeiger.DataReceived += new customControl.ComboSerialComm(commGeiger_DataReceived);
        }

        delegate void SetTextCallback(string text);
        private void commGeiger_DataReceived()
        {
            geigerData =formatString(commGeiger.ReadData());
            Thread demoThread =
       new Thread(new ThreadStart(this.ThreadProcSafe));
            demoThread.Start();
        }
        private void ThreadProcSafe()
        {
            ThreadHelperClass.SetText(this, lblGeigerData, geigerData);
        }
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lblGeigerData.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblGeigerData.Text = formatString(text);
            }
        }

        public String formatString(string text)
        {
            string ret = "";

            if (text == "")
                return "";
            
 
            text = Regex.Replace(text, @"\s+", "");
            text = text.Replace("||", ",");
            String[] parts = text.Split(',');
            string counts = parts[0];
            string dose = parts[1];
            ret = "Counts = " + counts + " CMP"+ Environment.NewLine  +"Dose = " + dose + " uSvh";
            return ret;

        }
        private void cmbxCam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cam1.startCam(cmbxCam1);
        }

      
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cam1.stopCamera();
            cam2.stopCamera();
            connShutter.closeCOM();
            connStage.closeCOM();
        }



        public void populateCamCmbx(ref ComboBox cmbx, camera cam)
        {
            cmbx.Items.Clear();
            foreach (String deviceName in cam.getWebcams())
            {
                cmbx.Items.Add(deviceName);
            }
        }

        private void cmbxCam2_MouseClick(object sender, MouseEventArgs e)
        {
            populateCamCmbx(ref cmbxCam2, cam2);
        }

        private void cmbxCam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cam2.startCam(cmbxCam2);
        }

        private void btnCam2Stop_Click(object sender, EventArgs e)
        {
            cam2.stopCamera();
            
        }

        private void cmbxCam1_MouseClick(object sender, MouseEventArgs e)
        {
            populateCamCmbx(ref cmbxCam1, cam1);
        }

        private void btnCam1Stop_Click(object sender, EventArgs e)
        {
            cam1.stopCamera();
        }

        private void conn1_Load(object sender, EventArgs e)
        {

        }

        private void btnShutterOpen_Click(object sender, EventArgs e)
        {
            if (connShutter.sendSerialFun("120"))
            {
                lblShutter.Text = "Open";
                lblShutter.ForeColor = Color.Red;
            }
        }

        private void btnShutterClose_Click(object sender, EventArgs e)
        {
            if (connShutter.sendSerialFun("0"))
            {
                lblShutter.Text = "Closed";
                lblShutter.ForeColor = Color.Green;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        // ************************* Stage ************************************************
        private void writeLog(String text)
        {
            txtbxLog.Text = txtbxLog.Text + text + Environment.NewLine ;
        }
        private void btnStageFwd_Click(object sender, EventArgs e)
        {

        }
        private void moveStage(String text)
        {
            if (connStage.sendSerialFun(text)){
                writeLog(text);
            }
            else
            {
                writeLog(connStage.log);
            }
        }

        

        private void btnStageRight_MouseDown(object sender, MouseEventArgs e)
        {
            stageBtnPressed = "R";
            timer1.Enabled = true;
        }

        private void btnStageFwd_MouseDown(object sender, MouseEventArgs e)
        {
            stageBtnPressed = "F";
            timer1.Enabled = true;
        }

        private void btnStageLeft_MouseDown(object sender, MouseEventArgs e)
        {
            stageBtnPressed = "L";
            timer1.Enabled = true;
        }

        private void btnStageBack_MouseDown(object sender, MouseEventArgs e)
        {
            stageBtnPressed = "D";
            timer1.Enabled = true;
        }

        private void btnStage_Click(object sender, EventArgs e)
        {
            moveStage(stageBtnPressed);
        }

        private void txtbxLog_TextChanged(object sender, EventArgs e)
        {
            txtbxLog.SelectionStart = txtbxLog.Text.Length;
            txtbxLog.ScrollToCaret();
        }

        private void txtbxDelay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval=int.Parse(txtbxDelay.Text);
                writeLog("Interval set to " + txtbxDelay.Text + " ms");
            }
            catch (Exception)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveStage(stageBtnPressed);
        }

        private void btnStage_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            txtbxLog.Text = this.Size.ToString() + this.Location.ToString();
        }

        private void commGeiger_Load(object sender, EventArgs e)
        {

        }
    }
}
