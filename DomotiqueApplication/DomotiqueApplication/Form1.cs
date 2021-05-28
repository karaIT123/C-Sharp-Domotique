using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace DomotiqueApplication
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public SerialPort serialPort;


        private delegate void msgDelegate(byte[] b);
        private msgDelegate showReceivedMessage;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        public void start()
        {
          serialPort.ReceivedBytesThreshold = 3;
          serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Byte[] mstToReceive = new Byte[3];

            for(int i = 0; i < 3; i++)
            {
                mstToReceive[i] = Convert.ToByte(serialPort.ReadByte());
            }

            showReceivedMessage = new msgDelegate(showMessage);
            Invoke(showReceivedMessage, mstToReceive);
        }

        private void showMessage(Byte[] b)
        {
            textBox1.Text = b[0].ToString();
            textBox2.Text = b[1].ToString();
            textBox3.Text = b[2].ToString();
        }

        private void configurerPortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration conf = new Configuration();
            conf.Show();
        }

        private void fermerLePortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                MessageBox.Show("Port fermé");
            }
            else
            {
                MessageBox.Show("Aucun port ouvert");
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* private void button1_Click(object sender, EventArgs e)
         {
             try
             {
                 if (serialPort != null)
                 { 
                     MessageBox.Show("port ouvert");
                 }
                 else
                 {
                     MessageBox.Show("Port fermé");
                 }
             }
              catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }*/
    }
}
