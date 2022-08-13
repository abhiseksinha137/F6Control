using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace geigerControl
{
    class geigerClass
    {
        private TextBox _txtbx;
        private ComboBox _cmbBx;
        public int baudrate = 9600;
        public SerialPort com=new SerialPort(); // Add handler for received data in code
        // The handler will take data from readData
        public string log = "Com port is inactive.";
        

        public geigerClass(ComboBox cmbBx, TextBox txtbx)
        {
            _cmbBx = cmbBx;
            _txtbx = txtbx;

            // Add event handlers for combobox
            _cmbBx.MouseClick += _cmbBx_MouseClick;
            _cmbBx.SelectedIndexChanged += _cmbBx_SelectedIndexChanged;
        }



        public string readData()
        {
            int intBuffer;
            intBuffer = com.BytesToRead;
            byte[] byteBuffer = new byte[intBuffer];
            com.Read(byteBuffer, 0, intBuffer);
            return com.ReadLine();
        }

        private void _cmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            startConnection();
        }

        private void startConnection()
        {
            try
            {
                closeCom();
                com.PortName = _cmbBx.Text; //new SerialPort(_cmbBx.Text, baudrate);
                com.BaudRate = baudrate;
                com.Open();
                log = "Com Port connected and active."; 
            }
            catch (Exception ex)
            {
                log = ex.Message;
            }
            
        }
        public void writeSerial(string text)
        {
            try
            {
                com.WriteLine(text);
                log = text;
            }
            catch (Exception ex)
            {
                log = ex.Message;
            }
            
            
        }


        private void populate_cmbbx()
        {
            string[] ports = SerialPort.GetPortNames();
            _cmbBx.Items.Clear();
            foreach (string port in ports)
                _cmbBx.Items.Add(port);
        }

        private void _cmbBx_MouseClick(object sender, MouseEventArgs e)
        {
            populate_cmbbx();
        }
        
        public void closeCom()
        {
            try
            {
                com.Close();
                log = "com closed.";
            }
            catch (Exception)
            {

                
            }
        }
        ~geigerClass() // Destructor
        {
            closeCom();
        }



    }
}
