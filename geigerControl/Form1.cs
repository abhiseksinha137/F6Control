using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geigerControl
{
    public partial class Form1 : Form
    {
        public SerialPort com;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            com = new SerialPort("COM3", 115200);
            com.ReadTimeout = 2000;
            com.Open();
            com.DataReceived += new SerialDataReceivedEventHandler(com_DataReceived);
        }

        private void com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int intBuffer;
            intBuffer = com.BytesToRead;
            byte[] byteBuffer = new byte[intBuffer];
            com.Read(byteBuffer, 0, intBuffer);
            this.Invoke(new EventHandler(DoUpDate));
        }

        private void DoUpDate(object s, EventArgs e)
        {
            String recv = com.ReadLine();
            recv= Regex.Replace(recv, @"\s+", "");
            recv=recv.Replace("||", ",");
            String[] parts = recv.Split(',');
            string counts = parts[0];
            string dose = parts[1];
            textBox1.Text = "Counts = " + counts + "   Dose = " + dose;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            com.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
