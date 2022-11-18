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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            string userName;
            string passWord;
            

            userName = textBox2.Text;
            passWord = textBox1.Text;
            

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
            cmd.CommandText = "SELECT * FROM user2 WHERE userName = '" + textBox2.Text + "' AND passWord = '" + textBox1.Text + "'";
            MySqlDataReader reader = cmd.ExecuteReader();

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

            reader.Close();
            cmd.Dispose();

            conn.Close(); // close the connection
            Console.WriteLine("\nConnection successfully terminated.");
        }
    }
}
