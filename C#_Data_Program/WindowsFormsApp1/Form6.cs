﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static WindowsFormsApp1.connection_string;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        int fieldId = 0;
        string connectionString = "server=lochnagar.abertay.ac.uk;user id=sql2202448;password=Fz2ggjKkinH6;database=sql2202448";

        public Form6()
        {
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = new MySqlCommand();
            sqlCmd.Connection = new MySqlConnection(connectionString);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT fieldId, OSname, OSversion, OSmanufacturer FROM softwareData";
            MySqlDataAdapter sqlDataAdap1 = new MySqlDataAdapter(sqlCmd);

            DataTable dtrecord = new DataTable();
            sqlDataAdap1.Fill(dtrecord);
            dataGridView1.DataSource = dtrecord;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form4 formname = new Form4();
            formname.Show();
            this.Hide();
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

        private void Selectbtn_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.SelectedCells[0].RowIndex;

            fieldId = Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[RowIndex].Cells[3].Value.ToString();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand sqlCmd = new MySqlCommand("UPDATE softwareData SET OSName=@OSName, OSVersion=@OSVersion, OSManufacturer=@OSManufacturer where fieldID = @fieldId", con);
                con.Open();
                sqlCmd.Parameters.AddWithValue("@fieldId", fieldId);
                sqlCmd.Parameters.AddWithValue("@OSName", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@OSVersion", textBox2.Text);
                sqlCmd.Parameters.AddWithValue("@OSManufacturer", textBox3.Text);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select a record to Update");
            }
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand sqlCmd = new MySqlCommand("INSERT into softwareData(OSName, OSVersion, OSManufacturer)" +
                    "VALUES(@OSName, @OSVersion, @OSManufacturer)", con);
                con.Open();
                sqlCmd.Parameters.AddWithValue("@OSName", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@OSVersion", textBox2.Text);
                sqlCmd.Parameters.AddWithValue("@OSManufacturer", textBox3.Text);
                sqlCmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Provide Details");
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (fieldId != 0)
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand sqlCmd = new MySqlCommand("DELETE FROM softwareData WHERE fieldId = @fieldId", con);
                con.Open();
                sqlCmd.Parameters.AddWithValue("@fieldId", fieldId);
                sqlCmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
