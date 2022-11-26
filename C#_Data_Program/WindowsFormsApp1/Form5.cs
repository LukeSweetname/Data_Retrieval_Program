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
        string connectionString = "server=lochnagar.abertay.ac.uk;user id=sql2202448;password=Fz2ggjKkinH6;database=sql2202448";
        int fieldId = 0;

        public Form5()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            MySqlCommand sqlCmd = new MySqlCommand();
            sqlCmd.Connection = new MySqlConnection(connectionString);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT fieldId, systemName, systemModel, systemManufacturer, systemType, systemIPaddress, systemMACAddress, systemPurchaseDate, systemExtraDetails FROM hardwareData;";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(sqlCmd);

            DataTable dtrecord = new DataTable();
            sqlDataAdap.Fill(dtrecord);
            dataGridView1.DataSource = dtrecord;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            MySqlCommand sqlCmd = new MySqlCommand();

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlDataAdapter sqlDataAdaptor = new MySqlDataAdapter();

            sqlCmd.Connection = new MySqlConnection(connectionString);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = ("UPDATE hardwareData SET systemName = @systemName, systemModel = @systemModel, systemManufacturer = @systemManufacturer, systemType = @systemType, systemIPaddress = @systemIPaddress, systemMACAddress = @systemMACAddress, systemPurchaseDate = @systemPurchaseDate, systemExtraDetaisl = @systemExtraDetails", con);
            
            sqlCmd.Parameters.Add("@systemName", MySqlDbType.VarChar, 255, "systemName");
            sqlCmd.Parameters.Add("@systemModel", MySqlDbType.VarChar, 255, "systemModel");
            sqlCmd.Parameters.Add("@systemManufacturer", MySqlDbType.VarChar, 255, "systemManufacturer");
            sqlCmd.Parameters.Add("@systemType", MySqlDbType.VarChar, 255, "systemType");
            sqlCmd.Parameters.Add("@systemIPaddress", MySqlDbType.VarChar, 255, "systemIPaddress");
            sqlCmd.Parameters.Add("@systemMACAddress", MySqlDbType.VarChar, 255, "systemMACAddress");
            sqlCmd.Parameters.Add("@systemPurchaseDate", MySqlDbType.VarChar, 255, "systemPurchaseDate");
            sqlCmd.Parameters.Add("@systemExtraDetails", MySqlDbType.Text, ' ', "systemExtraDetails");
            sqlCmd.ExecuteNonQuery();
            con.Close();

            
            ;
            /*con.Open();

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

            con.Close();*/
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand sqlCmd = new MySqlCommand("INSERT into hardwareData(systemName, systemModel, systemManufacturer, systemType, systemIPaddress, systemMACAddress, systemPurchaseDate, systemExtraDetails)" +
                    "VALUES(@systemName, @systemModel, @systemManufacturer, @systemType, @systemIPaddress, @systemMACAddress, @systemPurchaseDate, @systemExtraDetails)", con);
                con.Open();
                sqlCmd.Parameters.AddWithValue("@systemName", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@systemModel", textBox2.Text);
                sqlCmd.Parameters.AddWithValue("@systemManufacturer", textBox3.Text);
                sqlCmd.Parameters.AddWithValue("@systemType", textBox4.Text);
                sqlCmd.Parameters.AddWithValue("@systemIPaddress", textBox5.Text);
                sqlCmd.Parameters.AddWithValue("@systemMACAddress", textBox6.Text);
                sqlCmd.Parameters.AddWithValue("@systemPurchaseDate", textBox7.Text);
                sqlCmd.Parameters.AddWithValue("@systemExtraDetails", textBox8.Text);
                sqlCmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Provide Details");
            }







        }

        private void button9_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.SelectedCells[0].RowIndex;

            fieldId = Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[RowIndex].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[RowIndex].Cells[8].Value.ToString();
        }
      
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand sqlCmd = new MySqlCommand("UPDATE hardwareData SET systemName=@systemName, systemModel=@systemModel, systemManufacturer=@systemManufacturer, systemType=@systemType, systemIPaddress=@systemIPaddress, systemMACAddress=@systemMACAddress, systemPurchaseDate=@systemPurchaseDate, systemExtraDetails=@systemExtraDetails where fieldID = @fieldId", con);
                con.Open();
                sqlCmd.Parameters.AddWithValue("@fieldId", fieldId);
                sqlCmd.Parameters.AddWithValue("@systemName", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@systemModel", textBox2.Text);
                sqlCmd.Parameters.AddWithValue("@systemManufacturer", textBox3.Text);
                sqlCmd.Parameters.AddWithValue("@systemType", textBox4.Text);
                sqlCmd.Parameters.AddWithValue("@systemIPaddress", textBox5.Text);
                sqlCmd.Parameters.AddWithValue("@systemMACAddress", textBox6.Text);
                sqlCmd.Parameters.AddWithValue("@systemPurchaseDate", textBox7.Text);
                sqlCmd.Parameters.AddWithValue("@systemExtraDetails", textBox8.Text);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select a record to Update");
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (fieldId != 0)
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand sqlCmd = new MySqlCommand("DELETE FROM hardwareData WHERE fieldId = @fieldId", con);
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
    }
}
