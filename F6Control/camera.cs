using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using System.Drawing;

namespace F6Control
{
    public class camera
    {
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        PictureBox _picBx;
        ComboBox _cmbbx;

        public  camera(PictureBox picBx)  // Contructor
        {
            _picBx = picBx;
        }
        public String[] getWebcams()
        {
            List<String> camsList = new List<String>();
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                camsList.Add(device.Name);
            return camsList.ToArray();
        }


        public void startCam(ComboBox cmbx)
        {
            device = new VideoCaptureDevice(filter[cmbx.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            bitmap = new Bitmap(bitmap, _picBx.Size);
            _picBx.Image = bitmap;
        }


        public void stopCamera() {
            try
            {
                if (device.IsRunning)
                    device.Stop();
            }
            catch (Exception) { }
            try
            {
                _picBx.Image = null;
            }
            catch (Exception)
            {

                
            }
        }
        ~camera()  // Destructor
        {
            stopCamera();
        }
    }
}
