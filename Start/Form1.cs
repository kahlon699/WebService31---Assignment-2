using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPIClient;
using ClientSide;
using WebService31;
namespace Start
{
    public partial class Form1 : Form
    {
        ClientSide.Form1 fo1;
        WebAPIClient.Form1 fo2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fo2 != null)
            {
                fo2.Dispose();
            }
            fo1 = new ClientSide.Form1();
            fo1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fo1 != null)
            {
                fo1.Dispose();
            }
            fo2 = new WebAPIClient.Form1();
            fo2.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
