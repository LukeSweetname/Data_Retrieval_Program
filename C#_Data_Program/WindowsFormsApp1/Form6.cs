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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        string connectionString = "server=lochnagar.abertay.ac.uk;user id=sql2202448;password=Fz2ggjKkinH6;database=sql2202448";


        private void button4_Click(object sender, EventArgs e)
        {
            Form4 formname = new Form4();
            formname.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = new MySqlCommand();
            sqlCmd.Connection = new MySqlConnection(connectionString);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT OSname, OSversion, OSmanufacturer FROM softwareData";
            MySqlDataAdapter sqlDataAdap1 = new MySqlDataAdapter(sqlCmd);

            DataTable dtrecord = new DataTable();
            sqlDataAdap1.Fill(dtrecord);
            dataGridView1.DataSource = dtrecord;
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
