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

namespace Arduino_RGB_Controller
{
    public partial class Form1 : Form
    {
        // Configuration for Arduino
        SerialPort currentPort = new SerialPort();
        //bool portFound;
        int baudRate = 9600;
        public static string portName = "COM3";
        //string returnMessage = "";
        //string arduinoMessage = "SmartScreenPort";

        public Form1()
        {
            InitializeComponent();

            //Initialize TrackBar
            trackBarRed.SetRange(0, 255);
            trackBarGreen.SetRange(0, 255);
            trackBarBlue.SetRange(0, 255);

            //SetComPort();
            Connect();
        }

        private void Connect()
        {
            currentPort.PortName = portName;
            currentPort.BaudRate = baudRate;
            currentPort.Open();

            if (currentPort.IsOpen)
            {
                //send information
                currentPort.Write("R");
                currentPort.Write(Convert.ToChar(0).ToString());
                currentPort.Write("G");
                currentPort.Write(Convert.ToChar(255).ToString());
                currentPort.Write("B");
                currentPort.Write(Convert.ToChar(255).ToString());
            }
            /*if (portFound)
            {
                currentPort.Open();
                if (currentPort.IsOpen)
                {
                    //currentPort.Write(new[] { Convert.ToByte("c"), Convert.ToByte("R") }, 0, 2);
                    currentPort.Write("c");
                    //currentPort.Write(new[] { Convert.ToByte(trackBarRed.Value), Convert.ToByte(trackBarGreen.Value), Convert.ToByte(trackBarBlue.Value) }, 0, 3);
                    currentPort.Write("R");
                    //currentPort.WriteLine(Convert.ToString(trackBarRed.Value));
                    //currentPort.WriteLine("G");
                    //currentPort.WriteLine(Convert.ToString(trackBarGreen.Value));
                    //currentPort.WriteLine("B");
                    //currentPort.WriteLine(Convert.ToString(trackBarBlue.Value));
                }
                currentPort.Close();
            }
            else
            {
                arduinoPortText.Text = "Arduino not found";
                arduinoPortText.ForeColor = Color.Red;
            }*/
        }

        /// Searching Arduino ///

        /*private void SetComPort()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    currentPort = new SerialPort(port, baudRate);

                    if (DetectArduino())
                    {
                        portFound = true;
                        arduinoPortText.Text = "Connected to : " + currentPort.PortName;
                        arduinoPortText.ForeColor = Color.Green;
                        break;
                    }
                    else
                    {
                        portFound = false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }*/

        /*private bool DetectArduino()
        {
            try
            {
                currentPort.Open();
                currentPort.WriteLine("w");

                returnMessage = "";

                while (!returnMessage.Contains(arduinoMessage))
                {
                    returnMessage += Convert.ToString(Convert.ToChar(currentPort.ReadChar()));
                }

                currentPort.Close();

                if (returnMessage.Contains(arduinoMessage))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }*/

        // TrackBar

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            panelRed.BackColor = Color.FromArgb(trackBarRed.Value,0,0);
            panelColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            Connect();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            panelGreen.BackColor = Color.FromArgb(0, trackBarGreen.Value, 0);
            panelColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            Connect();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            panelBlue.BackColor = Color.FromArgb(0, 0, trackBarBlue.Value);
            panelColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            Connect();
        }

      
    }
}
