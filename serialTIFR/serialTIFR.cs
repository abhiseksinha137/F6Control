using System;
using System.IO.Ports;
using System.Windows.Forms;
namespace serialTIFR
{
    public delegate void TIFRSerialComm();  // delegate
    public class serialTIFR
    {
        public SerialPort com;
        public string log;
        public int baudrate = 9600;

        public event TIFRSerialComm DataReceived; // event
        public serialTIFR()
        {
            com = new SerialPort();
            com.DataReceived += new SerialDataReceivedEventHandler(com_DataReceived);
        }

        //Event for data received
        private void com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DataReceived?.Invoke();
        }

        public void startConnection(String portName)
        {
            try
            {
                closeCom();
                com.PortName = portName; //new SerialPort(_cmbBx.Text, baudrate);
                com.BaudRate = baudrate;
                com.Open();
                log = "Com Port connected and active.";

            }
            catch (Exception ex)
            {
                log = ex.Message;
            }

        }


        public String ReadData()
        {
            try
            {
                int intBuffer;
                intBuffer = com.BytesToRead;
                byte[] byteBuffer = new byte[intBuffer];
                com.Read(byteBuffer, 0, intBuffer);
                return com.ReadLine();
             }
            catch (Exception ex)
            {
                log = ex.Message;
                return "";
            }
            
        }

        public void sendSerial(string text)
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
        public void closeCom()
        {
            try
            {
                com.Close();
                log = "com closed.";
            }
            catch (Exception ex)
            {
                log = ex.Message;
            }
        }

        
    }
}
