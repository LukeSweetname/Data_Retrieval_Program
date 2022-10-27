using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // adding database link
        {
            SqlConnection conn;
            string connString = "Data Source = mayar.abertay.ac.uk; Initial Catalog = " +
                "sql2202448; User ID = sql2202448; Password = Fz2ggjKkinH6";
            conn = new SqlConnection(connString);
            {
                conn.Open(); // open the connection
                Console.WriteLine("Connection successfully established.\n");

                // add code

                conn.Close(); // close the connection
                Console.WriteLine("\nConnection successfully terminated.");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void motherboardTypeInput_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string messages =
            "Please confirm you wish to close the system";
            const string caption = "Form Closing";
            var results = MessageBox.Show(messages, caption,
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // No button was pressed
            if (results == DialogResult.No)
            {
                // Cancel closing form
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string messages =
            "Please confirm you wish to close the system";
            const string caption = "System Data Retrieval Closing";
            var results = MessageBox.Show(messages, caption,
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // No button was pressed
            if (results == DialogResult.Yes)
            {
                // Cancel closing form
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String q1 = Environment.MachineName; // Computer name
            textBox1.Text = q1;

            // Check model id
            ManagementClass management1 = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection managementobject1 = management1.GetInstances();

            foreach (ManagementObject mngObject1 in managementobject1)
            {
                textBox2.Text = mngObject1.Properties["Model"].Value.ToString();
                break;
            }

            // Check Manufacturer
            ManagementClass management2 = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection managementobject2 = management2.GetInstances();

            foreach (ManagementObject mngObject2 in managementobject2)
            {
                textBox3.Text = mngObject2.Properties["Manufacturer"].Value.ToString();
                break;
            }
            // Check Motherboard
            ManagementClass management4 = new ManagementClass("Win32_Processor");
            ManagementObjectCollection managementobject4 = management4.GetInstances();

            foreach (ManagementObject mngObject4 in managementobject4)
            {
                textBox4.Text = mngObject4.Properties["Name"].Value.ToString();
                break;
            }

            // Check IP address
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in ip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    textBox5.Text = address.ToString();
                }
            }
        }
    }
}
