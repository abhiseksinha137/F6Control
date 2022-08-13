using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geigerControl
{
    public partial class Form2 : Form
    {
        geigerClass gc;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gc = new geigerClass(comboBox1, textBox1);
            gc.writeSerial("");
            textBox1.Text = gc.log;
            gc.com.DataReceived += gc_ReceivedData;

        }

        private void gc_ReceivedData(object sender, SerialDataReceivedEventArgs e)
        {
            textBox1.Text = gc.readData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
