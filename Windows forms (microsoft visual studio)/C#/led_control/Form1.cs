using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace led_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.PortName = "com2";  // The port through which the Arduino board is connected to the system
            serialPort1.Close();

        }

        private void btnOn_Click(object sender, EventArgs e)
        {

            serialPort1.Open();
            serialPort1.WriteLine("1,0,0");
            serialPort1.Close();

        }

        private void btnOff_Click(object sender, EventArgs e)
        {

            serialPort1.Open();
            serialPort1.WriteLine("2,0,0");
            serialPort1.Close();

        }

        private void btnBlink_Click(object sender, EventArgs e)
        {

            serialPort1.Open();
            serialPort1.WriteLine("3,"+txtCount.Text+","+txtSpeed.Text);
            serialPort1.Close();

        }

    }

}