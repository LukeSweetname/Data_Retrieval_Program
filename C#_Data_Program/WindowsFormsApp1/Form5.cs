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
using WindowsFormsApp1.connection_class;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string connectionString = "server=lochnagar.abertay.ac.uk;user id=sql2202448;password=Fz2ggjKkinH6;database=sql2202448";

        private void button2_Click(object sender, EventArgs e)
        {

            MySqlCommand sqlCmd = new MySqlCommand();
            sqlCmd.Connection = new MySqlConnection(connectionString);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT fieldId, systemName, systemModel, systemManufacturer, systemType, systemIPaddress, systemPurchaseDate, systemExtraDetails FROM hardwareData;";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(sqlCmd);

            DataTable dtrecord = new DataTable();
            sqlDataAdap.Fill(dtrecord);
            dataGridView1.DataSource = dtrecord;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            MySqlCommand sqlCmd = new MySqlCommand();

            MySqlConnection con = new MySqlConnection(connectionString);

            MySqlDataAdapter sqlDataAdaptor = new MySqlDataAdapter();

            sqlCmd.Connection = new MySqlConnection(connectionString);
            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = ("UPDATE hardwareData SET systemName = @systemName, systemModel = @systemModel, systemManufacturer = @systemManufacturer, systemType = @systemType, systemIPaddress = @systemIPaddress, systemPurchaseDate = 

            con.Open();

            MySqlCommand sqlCmd = new MySqlCommand();
            sqlCmd.Connection = new MySqlConnection(connectionString);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE hardwareData SET systemName = ?, systemModel = ?, systemManufacturer = ?, systemType = ?, systemIPaddress = ?, systemPurchaseDate = ?, systemExtraDetails = ? WHERE fieldId = ?;";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(sqlCmd);

            DataTable dtrecord = new DataTable();
            sqlDataAdap.Update(dtrecord);
            dataGridView1.DataSource = dtrecord;

            int rowindex = dataGridView1.CurrentRow.Index;
            MessageBox.Show(rowindex.ToString());

            con.Close();

            */
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 formname = new Form4();
            formname.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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
