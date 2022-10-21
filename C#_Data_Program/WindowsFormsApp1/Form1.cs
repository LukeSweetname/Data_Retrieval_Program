using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            const string messages =
            "Please confirm you wish to close the system";
            const string caption = "Form Closing";
            var results = MessageBox.Show(messages, caption,
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // No button was pressed
            if (results == DialogResult.No)
            {
                // Cancel closing form
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
            textBox1.Enabled = false;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
        }
    }
}
