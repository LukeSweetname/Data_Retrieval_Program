﻿using System;
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
            ManagementObjectCollection managementobject2 = management2.GetInstances();

            foreach (ManagementObject mngObject2 in managementobject2)
            {
                textBox2.Text = mngObject2.Properties["VersionString"].Value.ToString();
                break;
            }

            // Check OS manufacturer
            ManagementClass management3 = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection managementobject3 = management3.GetInstances();

            foreach (ManagementObject mngObject3 in managementobject3)
            {
                textBox3.Text = mngObject3.Properties["Manufacturer"].Value.ToString();
                break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 formname = new Form4();
            formname.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // https://www.youtube.com/watch?v=bkzOvlqD1s4&t=100s
            // Used the above link to help create exit functionality
            // Copyright (c) DJ Oamen Youtube (TM) 2015 | Code (C#)
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
    }
}
