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

namespace Domotique
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public SerialPort serialPort;
        
        public Form1()
        {
            InitializeComponent();
            instance = this;
            serialPort = null;
        }

        private void configurerPortsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Configuration_Ports cp = new Configuration_Ports();
            cp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Byte[] msgToSend = new Byte[3];
            try
            {
                msgToSend[0] = Convert.ToByte(textBox1.Text);
                msgToSend[1] = Convert.ToByte(textBox2.Text);
                msgToSend[2] = Convert.ToByte(textBox3.Text);

                serialPort.Write(msgToSend, 0, 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void fermerLapplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
