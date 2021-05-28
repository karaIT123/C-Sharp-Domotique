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
    public partial class Configuration_Ports : Form
    {

        public SerialPort serialPort;
        public static Configuration_Ports instance;

        String[] listPort = SerialPort.GetPortNames();
        String[] listBitsSec = { "7200", "9600", "14400" };
        String[] listParity = { "None", "Odd", "Even", "Mark", "Space" };
        String[] listBaudsRates = { "4", "5", "6", "7", "8" };
        String[] listStopBits = { "1", "1.5", "2" };
        String[] listFlowControl = { "Xon / Xoff", "Matériel", "Aucun" };

        String PortName;
        int BitsSec;
        int DataBits;
        Parity parity;
        StopBits stopBits;

       

        public Configuration_Ports()
        {
            InitializeComponent();

            instance = this;
            //serialPort = new SerialPort();

            Array.Sort(listPort);

            comboBoxPortName.Items.AddRange(listPort);
            comboBoxPortName.SelectedItem = listPort[0];

            comboBoxBitsSec.Items.AddRange(listBitsSec);
            comboBoxBitsSec.SelectedItem = listBitsSec[1];

            comboBoxDataBits.Items.AddRange(listBaudsRates);
            comboBoxDataBits.SelectedItem = listBaudsRates[4];

            comboBoxParity.Items.AddRange(listParity);
            comboBoxParity.SelectedItem = listParity[0];

            comboBoxFlowControl.Items.AddRange(listFlowControl);
            comboBoxFlowControl.SelectedItem = listFlowControl[2];

            comboBoxStopBits.Items.AddRange(listStopBits);
            comboBoxStopBits.SelectedItem = listStopBits[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //serialPort = new SerialPort("nom", 4, Parity.Odd,8, StopBits.);
            listBoxPort.Items.AddRange(listPort);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxPort.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch(comboBoxParity.SelectedItem)
            {
                case "None":
                    parity = Parity.None;
                    break;
                case "Odd":
                    parity = Parity.Odd;
                    break;
                case "Even":
                    parity = Parity.Even;
                    break;
                case "Mark":
                    parity = Parity.Mark;
                    break;
                case "Space":
                    parity = Parity.Space;
                    break;
                default:
                    parity = Parity.None;
                    break;
            }

            switch(comboBoxStopBits.SelectedItem)
            {
                case "1":
                    stopBits = StopBits.One;
                    break;
                case "1.5":
                    stopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    stopBits = StopBits.Two;
                    break;
                default:
                    stopBits = StopBits.One;
                    break;
            }

            PortName = comboBoxPortName.SelectedItem.ToString();
            BitsSec = Convert.ToInt32(comboBoxBitsSec.SelectedItem);
            DataBits = Convert.ToInt32(comboBoxDataBits.SelectedItem);
            //SerialPort serialPort = Form1.instance.serialPort;
            //serialPort = new SerialPort(PortName,BitsSec,parity,DataBits,stopBits);
            Form1.instance.serialPort = new SerialPort(PortName, BitsSec, parity, DataBits, stopBits);

            if (!Form1.instance.serialPort.IsOpen)
            {
                Form1.instance.serialPort.Open();
                MessageBox.Show(PortName + " ouvert");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Form1.instance.serialPort != null && Form1.instance.serialPort.IsOpen)
            {
                serialPort.Close();
                MessageBox.Show("Port fermé");
            }
            else
            {
                MessageBox.Show("Aucun port ouvert");
            }
        }
    }
}
