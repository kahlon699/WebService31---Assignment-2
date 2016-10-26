using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService31;
using System.ServiceModel;
using System.Windows.Forms;
using System.ServiceModel.Description;

namespace ClientSide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public ServiceReference1.Service1Client client;
      
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("basicHttpBinding");
            comboBox1.Items.Add("wsHttpBinding");
            comboBox1.Items.Add("netTcpBinding");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            comboBox2.Text = "";
            comboBox3.Text = "";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        void Display()
        {
            try
            {
                List<string> str = client.ConvertToArray(textBox1.Text).ToList();
                foreach (string s in str)
                {
                    comboBox2.Items.Add(s);
                }
                textBox2.Text = client.ConvertToUpperCase(textBox1.Text);
                textBox3.Text = client.LengthOfString(textBox1.Text).ToString();
                //CustomClass cus = new CustomClass();
                var li = client.WordLengths(textBox1.Text);
                foreach (CustomClass s in li)
                {

                    comboBox3.Items.Add(s.word + ", " + s.length);
                }
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;

            }
            catch (FaultException <MyError> er)
            {
                string msg = "Error:" + er.Detail.Errorcode + "\n" + er.Detail.ErrorMsg;
                MessageBox.Show(msg, "Error Message");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex>=0)
            {

                if (comboBox1.SelectedItem.ToString() == "basicHttpBinding")
                {
                    client = new ServiceReference1.Service1Client("Basic");
                    Display();

                    //Uri baseAddress = new Uri("http://localhost:8733/Design_Time_Addresses/WebService31");
                    //string address = "http://localhost:8733/Design_Time_Addresses/WebService31/Service1";
                    //using (ServiceHost serviceHost = new ServiceHost(typeof(Service1), baseAddress))
                    //{
                    //    serviceHost.AddServiceEndpoint(typeof(IService1), new BasicHttpBinding(), address);
                    //    serviceHost.Open();
                    //    Display();            


                    //    serviceHost.Close();
                    //}


                }
                else if (comboBox1.SelectedItem.ToString() == "wsHttpBinding")
                {
                    client = new ServiceReference1.Service1Client("WS");
                    Display();
                   

                }
                else if (comboBox1.SelectedItem.ToString() == "netTcpBinding")
                {
                  
                    client = new ServiceReference1.Service1Client("NetTCP");
                    Display();
                   

                }
            }
            else
            {
                MessageBox.Show("Select Endoint Binding from the list");
            }

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

