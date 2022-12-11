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
using static WindowsFormsApp1.connection_string;



namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        int fieldId = 0;
        string connectionString = "server=lochnagar.abertay.ac.uk;user id=sql2202448;password=Fz2ggjKkinH6;database=sql2202448";
        public Form7()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
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
            Form4 formname = new Form4();
            formname.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = new MySqlCommand();
            sqlCmd.Connection = new MySqlConnection(connectionString);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT fieldId, systemName, systemModel FROM hardwareData;";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(sqlCmd);

            DataTable dtrecord = new DataTable();
            sqlDataAdap.Fill(dtrecord);
            dataGridView2.DataSource = dtrecord;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView2.SelectedCells[0].RowIndex;

            fieldId = Convert.ToInt32(dataGridView2.Rows[RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView2.Rows[RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[RowIndex].Cells[2].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = new MySqlCommand();
            sqlCmd.Connection = new MySqlConnection(connectionString);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT fieldId, OSname, OSversion FROM softwareData";
            MySqlDataAdapter sqlDataAdap1 = new MySqlDataAdapter(sqlCmd);

            DataTable dtrecord = new DataTable();
            sqlDataAdap1.Fill(dtrecord);
            dataGridView1.DataSource = dtrecord;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.SelectedCells[0].RowIndex;

            fieldId = Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
            textBox4.Text = dataGridView1.Rows[RowIndex].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.Rows[RowIndex].Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = new MySqlCommand();
            sqlCmd.Connection = new MySqlConnection(connectionString);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT id, Hardwareid, Softwareid FROM LinkTable;";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(sqlCmd);

            DataTable dtrecord = new DataTable();
            sqlDataAdap.Fill(dtrecord);
            dataGridView3.DataSource = dtrecord;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && (textBox4.Text != ""))
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand sqlCmd = new MySqlCommand("INSERT into LinkTable(Hardwareid, Softwareid)" +
                    "VALUES(@systemName, @OSName)", con);
                con.Open();
                sqlCmd.Parameters.AddWithValue("@systemName", textBox2.Text);
                sqlCmd.Parameters.AddWithValue("@OSName", textBox5.Text);
                sqlCmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Provide Details");
            }
        }
    }
}
