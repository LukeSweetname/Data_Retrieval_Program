using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

            string systemName;
            string systemModel;
            string systemManufacturer;
            string systemType;
            string systemIPaddress;
            string systemPurchaseDate;
            string systemExtraDetails;

            systemName = textBox1.Text;
            systemModel = textBox2.Text;
            systemManufacturer = textBox3.Text;
            systemType = textBox4.Text;
            systemIPaddress = textBox5.Text;
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
            MySqlConnection con = new MySqlConnection("server= lochnagar.abertay.ac.uk; database= sql2202448; username = sql2202448; password = Fz2ggjKkinH6");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from hardwareData where systemName = @systemName", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            conn.Close(); // close the connection
            Console.WriteLine("\nConnection successfully terminated.");

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

            string systemName;
            string systemModel;
            string systemManufacturer;
            string systemType;
            string systemIPaddress;
            string systemPurchaseDate;
            string systemExtraDetails;

            systemName = textBox1.Text;
            systemModel = textBox2.Text;
            systemManufacturer = textBox3.Text;
            systemType = textBox4.Text;
            systemIPaddress = textBox5.Text;
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
            cmd.CommandText = "INSERT INTO hardwareData (systemName, systemModel, systemManufacturer, systemType, systemIPaddress, systemPurchaseDate, systemExtraDetails)" +
                "VALUES ('" + systemName + "','" + systemModel + "','" + systemManufacturer + "','" + systemType + "','" + systemIPaddress + "','" + systemPurchaseDate + "','" + systemExtraDetails + "')";
            cmd.ExecuteNonQuery();

            conn.Close(); // close the connection
            Console.WriteLine("\nConnection successfully terminated.");

        }
    }
}
