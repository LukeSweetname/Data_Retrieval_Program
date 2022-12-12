using System;
using System.Management;
// https://ourcodeworld.com/articles/read/294/how-to-retrieve-basic-and-advanced-hardware-and-software-information-gpu-hard-drive-processor-os-printers-in-winforms-with-c-sharp
// Used the above link to identify the necessary references to access system management libraries
// Copyright (c) 2016 Carlos Delgado | Code (C#)
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
using System.Net.NetworkInformation;

// https://www.youtube.com/watch?v=izpntJlcs8o
// Used the above link to identify the correct references needed for the IP address to be retrieved
// Copyright (c) 2021 Ameer Hamza YouTube (TM) | Code (C#)

using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using static WindowsFormsApp1.connection_string;
// https://dev.mysql.com/downloads/windows/visualstudio/ 
// Used above link to download visual studio/mysql functionality

// https://ourcodeworld.com/articles/read/294/how-to-retrieve-basic-and-advanced-hardware-and-software-information-gpu-hard-drive-processor-os-printers-in-winforms-with-c-sharp
// Copyright (c) 2016 Carlos Delgado | Code (C#)

// https://learn.microsoft.com/en-us/aspnet/web-forms/overview/presenting-and-managing-data/model-binding/retrieving-data
// Copyright (c) Microsoft (TM) forums 2022 | Code (C#)

// https://www.guru99.com/c-sharp-windows-forms-application.html
// Copyright (c) Barbara Thompson 2022 | Code (C#)

// https://www.youtube.com/watch?v=bkzOvlqD1s4&t=100s
// Copyright (c) DJ Oamen Youtube (TM) 2015 | Code (C#)
// Used the above links as general inspiration for the project
namespace WindowsFormsApp1
{
    public partial class hardware_get : Form
    {
        string connection_string = Utils.ConnectionString;
        public hardware_get()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // adding database link
        {
            
            MySqlConnection conn = new MySqlConnection(connection_string);
            // https://learn.microsoft.com/en-us/troubleshoot/sql/connect/network-related-or-instance-specific-error-occurred-while-establishing-connection
            // Copyright (c) Microsoft (TM) forums 2022 | Code (C#)
            // Used the above code to troubleshoot errors with the database connection

            conn.Open();

            string systemName;
            string systemModel;
            string systemManufacturer;
            string systemType;
            string systemIPaddress;
            string systemMACAddress;
            string systemPurchaseDate;
            string systemExtraDetails;


            systemName = textBox1.Text;
            systemModel = textBox2.Text;
            systemManufacturer = textBox3.Text;
            systemType = textBox4.Text;
            systemIPaddress = textBox5.Text;
            systemMACAddress = textBox6.Text;
            systemPurchaseDate = dateTimePicker1.Text;
            systemExtraDetails = textBox7.Text;

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
            cmd.CommandText = "INSERT INTO hardwareData (systemName, systemModel, systemManufacturer, systemType, systemIPaddress, systemMACAddress, systemPurchaseDate, systemExtraDetails)" +
                "VALUES ('" + systemName + "','" + systemModel + "','" + systemManufacturer + "','" + systemType + "','" + systemIPaddress + "','" + systemMACAddress + "','" + systemPurchaseDate + "','" + systemExtraDetails + "')";
            cmd.ExecuteNonQuery();
           
            conn.Close(); // close the connection
            Console.WriteLine("\nConnection successfully terminated.");
            MessageBox.Show("You have successfully added this data to the database, please click exit or return to the menu.");

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
        // Code for clearing the text boxes 
        // https://www.youtube.com/watch?v=bkzOvlqD1s4&t=100s
        // Used above link to find out how to clear program worksheet
        // // Copyright (c) DJ Oamen Youtube (TM) 2015 | Code (C#)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // https://www.section.io/engineering-education/working-with-system-information-in-c-sharp-windows-form-application/
            // Used the information in the above link to teach myself how to retrieve system information.
            // The above link was used for retrieving the name, model, manufacturer and type.
            // Copyright Kipkopus Samuel (c) 2022 | Code (c#)

            // https://stackoverflow.com/questions/36011380/retrieving-system-and-os-info
            // Used the above link to identify namespaces to retrieve system data
            // Namespaces were used for all retrieval methods
            // Copyright Stack Overflow (c) (TM) 2016 | Code (C#)


            // Check computer name
            String q1 = Environment.MachineName;
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

            // https://www.youtube.com/watch?v=izpntJlcs8o
            // Used the above link to identify the correct code for retrieving and displaying correctly, the systems IP address
            // Copyright (c) 2021 Ameer Hamza YouTube (TM) | Code (C#)
            // Check IP address
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in ip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    textBox5.Text = address.ToString();
                }
            }
            // Get MAC address
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            // giving the variable var temp the value of sMacAddress
            var temp = sMacAddress;

            var regex = "(.{2})(.{2})(.{2})(.{2})(.{2})(.{2})";
            var replace = "$1:$2:$3:$4:$5:$6";
            var newformat = Regex.Replace(temp, regex, replace);
            
            // returning new format into textbox 6
            textBox6.Text = newformat; 

            // Retrieving MAC address
            /*
            ManagementScope theScope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");
            ObjectQuery theQuery = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher theSearcher = new ManagementObjectSearcher(theScope, theQuery);
            ManagementObjectCollection theCollectionOfResults = theSearcher.Get();

            foreach (ManagementObject theCurrentObject in theCollectionOfResults)
            {
                if (theCurrentObject["MACAddress"] != null)
                {
                    textBox6.Text = theCurrentObject["MACAddress"].ToString();
                }
            }*/
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main_menu formname = new main_menu();
            formname.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
