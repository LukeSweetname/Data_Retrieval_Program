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

        string connectionString = "server=lochnagar.abertay.ac.uk;user id=sql2202448;password=Fz2ggjKkinH6;database=sql2202448";

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM hardwareData where systemName = @systemName";
            cmd.Parameters.AddWithValue("@systemName", textBox1.Text);
            cmd.Parameters.AddWithValue("@systemName", textBox1.Text);
            cmd.Parameters.AddWithValue("@systemName", textBox1.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader["hardwareData"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.Parameters.AddWithValue("@systemName", textBox1.Text);
            cmd.Parameters.AddWithValue("@systemModel", textBox2.Text);
            cmd.Parameters.AddWithValue("@systemManufacturer", textBox3.Text);
            cmd.Parameters.AddWithValue("@systemType", textBox4.Text);
            cmd.Parameters.AddWithValue("@systemIPaddress", textBox5.Text);
            cmd.Parameters.AddWithValue("@systemPurchaseDate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@systemMACaddress", textBox6.Text);
            cmd.Parameters.AddWithValue("@systemExtraDetails", textBox7.Text);

            cmd.CommandText = "INSERT INTO hardwareData (systemName, systemModel, systemManufacturer, systemType, systemIPaddress, systemPurchaseDate, systemMACaddress, systemExtraDetails)" +
                "VALUES (@systemName, @systemModel, @systemManufacturer, @systemType, @systemIPaddress, @systemPurchaseDate, @systemMACaddress, @systemExtraDetails)";

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Data was added to database");
            else
                MessageBox.Show("Data was not added to database");
            con.Close();


        }
    }
}
