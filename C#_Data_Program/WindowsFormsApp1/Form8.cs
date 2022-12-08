using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
            // 
        {
            /*HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://services.nvd.nist.gov/rest/json/cves/2.0?");
            // cpeName=cpe:2.3:o:microsoft:windows_10:-:*:*:*:*:*:*:*
            HttpResponseMessage response = client.GetAsync("cpeName=cpe:2.3:o:microsoft:windows_10:-:*:*:*:*:*:*:*").Result;

            var vun = response.Content.ReadAsAsync<List<vunerability>>().Result;
            dataGridView1.DataSource = vun;*/
        }
    }
}
