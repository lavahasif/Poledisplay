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

namespace Poledisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SerialPort sp = new SerialPort();

             sp.PortName = textBox1.Text;
                // 9600
                sp.BaudRate = Int32.Parse(textBox2.Text);
                sp.Parity = Parity.None;
                sp.DataBits = 8;
                sp.StopBits = StopBits.One;
                sp.Open();
                         byte[] bytesToSend = new byte[1] { 0x0C }; // send hex code 0C to clear screen
                                sp.Write(bytesToSend, 0, 1);
                // sp.WriteLine("                                        ");
                sp.WriteLine("Hello world");

                sp.Close();
                sp.Dispose();
                sp = null;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort sp = new SerialPort();

                sp.PortName = textBox1.Text;
                // 9600
                sp.BaudRate = Int32.Parse(textBox2.Text);
                sp.Parity = Parity.None;
                sp.DataBits = 8;
                sp.StopBits = StopBits.One;
                sp.Open();
                // sp.Write(Convert.ToString((char)12));
                
                byte[] bytesToSend = new byte[1] { 0x0C }; // send hex code 0C to clear screen
                sp.Write(bytesToSend, 0, 1);

                sp.Close();
                sp.Dispose();
                sp = null;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message);
            }

        }
    }
    
    
  
}