using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using SharedClasses;
using System.Net;
using REST.Controllers;

namespace WebAPIClient
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }






        void Display()
        {


            HttpResponseMessage response = new HttpResponseMessage();

            CustomClass cus = new CustomClass();

           
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://localhost:41967/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    string str = "api/default/" + textBox1.Text;
                    response = client.GetAsync(str).Result;
                    if (response.StatusCode != HttpStatusCode.BadRequest)
                    {

                        cus = response.Content.ReadAsAsync<CustomClass>().Result;

                    }
                    else
                    {  
                            var e = response.Content.ReadAsStringAsync().Result;
                            throw new Exception(e);
                        

                    }

   


                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message, "Error Message");
                   
                }
            }




            if (cus.StrList != null)
            {
                foreach (string s in cus.StrList)
                {
                    comboBox2.Items.Add(s);
                }
                textBox2.Text = cus.UpperCase;
                textBox3.Text = cus.StringLength.ToString();
                //CustomClass cus = new CustomClass();
                var li = cus.WordLenList;
                foreach (WordLength s in li)
                {

                    comboBox3.Items.Add(s.word + ", " + s.length);
                }
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
            }

            
        }      


        private void button1_Click(object sender, EventArgs e)
        {
              comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                Display();
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
    

