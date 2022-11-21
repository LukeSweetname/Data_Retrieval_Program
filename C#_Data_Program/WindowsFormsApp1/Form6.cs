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
            sqlCmd.CommandText = "SELECT OSname, OSversion, OSmanufacturer FROM softwareData WHERE fieldId = ?";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(sqlCmd);

            DataTable dtrecord = new DataTable();
            sqlDataAdap.Fill(dtrecord);
            dataGridView1.DataSource = dtrecord;
        }
    }
}
