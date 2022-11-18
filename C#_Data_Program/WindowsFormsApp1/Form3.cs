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
using MySql.Data.MySqlClient;
//using System.Collections;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check OS name
            ManagementClass management1 = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection managementobject1 = management1.GetInstances();

            foreach (ManagementObject mngObject1 in managementobject1)
            {
                textBox1.Text = mngObject1.Properties["Name"].Value.ToString();
                break;
            }

            // Check OS version
            ManagementClass management2 = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection managementobject2 = management1.GetInstances();

            foreach (ManagementObject mngObject1 in managementobject1)
            {
                textBox2.Text = mngObject1.Properties["Name"].Value.ToString();
                break;
            }

            // Check OS manufacturer
            ManagementClass management3 = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection managementobject3 = management1.GetInstances();

            foreach (ManagementObject mngObject1 in managementobject1)
            {
                textBox3.Text = mngObject1.Properties["Name"].Value.ToString();
                break;
            }
        }
    }
}
