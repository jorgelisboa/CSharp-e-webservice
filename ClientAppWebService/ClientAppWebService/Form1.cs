using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ClientAppWebService
{
    public partial class Form1 : Form
    {
        localhost.WebService1 service = new localhost.WebService1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String Coutries_Json = service.Countries();
            DataTable Countries = JsonConvert.DeserializeObject<DataTable>(Coutries_Json); //Desserializando o arquivo que era JSON
            dataGridView1.DataSource = Countries;
        }
    }
}
