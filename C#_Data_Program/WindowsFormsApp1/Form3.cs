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
                string temp = mngObject1.Properties["Name"].Value.ToString();
                string[] subs = temp.Split('|');
                string finalres = subs[0];
                textBox1.Text = finalres;
                break;
            }

            // Check OS version
            ManagementClass management2 = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection managementobject2 = management2.GetInstances();

            foreach (ManagementObject mngObject2 in managementobject2)
            {
                textBox2.Text = mngObject2.Properties["Version"].Value.ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "lochnagar.abertay.ac.uk";
            string database = "sql2202448";
            string username = "sql2202448";
            string password = "Fz2ggjKkinH6";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "USERNAME=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            // https://learn.microsoft.com/en-us/troubleshoot/sql/connect/network-related-or-instance-specific-error-occurred-while-establishing-connection
            // Copyright (c) Microsoft (TM) forums 2022 | Code (C#)
            // Used the above code to troubleshoot errors with the database connection

            conn.Open();

            string OSname;
            string OSversion;
            string OSmanufacturer;

            OSname = textBox1.Text;
            OSversion = textBox2.Text;
            OSmanufacturer = textBox3.Text;
            

            // https://stackoverflow.com/questions/22806870/incorrect-datetime-value-database-error-number-1292
            // Copyright Stack Overflow (c) (TM) 2022 | Code (C#)
            // Used above link to investigate datetime error and resolve error.

            // https://www.c-sharpcorner.com/article/connect-mysql-with-c-sharp-net-framework-in-visual-studio-2019/
            // Copyright Ojash Shrestha (c) 2021 | Code (C#)

            // https://www.youtube.com/watch?v=lXAgHdhbEzo
            // Copyright OpenEducation (c) Youtube (TM) 2021 | Code (C#)
            // Used the above links as inspiration for my database connection for my program. 
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO softwareData (OSname, OSversion, OSmanufacturer)" +
                "VALUES ('" + OSname + "','" + OSversion + "','" + OSmanufacturer + "')";
            cmd.ExecuteNonQuery();

            conn.Close(); // close the connection
            Console.WriteLine("\nConnection successfully terminated.");
            MessageBox.Show("You have successfully added this data to the database, please click exit or return to the menu");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
