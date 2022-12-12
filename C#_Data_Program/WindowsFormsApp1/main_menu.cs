using System;
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
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            software_get formname = new software_get();
            formname.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new hardware_get();
            myForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hardware_get formname = new hardware_get();
            formname.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            hardware_change formname = new hardware_change();
            formname.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 formname = new Form6();
            formname.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            link_form formname = new link_form();
            formname.Show();
            this.Hide();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
