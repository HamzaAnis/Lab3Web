using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3Web
{
    public partial class Form1 : Form
    {
        private string address;
        private string city;
        private string companayName;
        private readonly List<string> companyDetails = new List<string>();
        private string companyName2;
        private string contactName;
        private string contactNumb;
        private string country;
        private readonly Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
        private string fax;
        private List<string> FormData;
        private string phone;
        private string postal;
        private string region;
        private string title;

        public Form1()
        {
            InitializeComponent();
            FormData = new List<string>();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            address = textBox6.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (data.ContainsKey(companyName2))
            {
                var temp = data[companyName2];
                textbox1.Text = temp[0];
                textBox2.Text = temp[1];
                textBox3.Text = temp[2];
                textBox4.Text = temp[3];
                textBox5.Text = temp[4];
                textBox6.Text = temp[5];
                textBox7.Text = temp[6];
                textBox8.Text = temp[7];
                textBox9.Text = temp[8];
                textBox10.Text = temp[9];
            }
            else
            {
                MessageBox.Show("Company Not Found.Please try again.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //OK button
        private void button3_Click(object sender, EventArgs e)
        {
            if (companayName != null)
            {
                companyDetails.Add(companayName);
                companyDetails.Add(title);
                companyDetails.Add(contactName);
                companyDetails.Add(phone);
                companyDetails.Add(fax);
                companyDetails.Add(address);
                companyDetails.Add(postal);
                companyDetails.Add(city);
                companyDetails.Add(region);
                companyDetails.Add(country);
                data.Add(companayName, companyDetails);
                textbox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter the Company name!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            companayName = textbox1.Text;
            ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //title =rt
            title = textBox2.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            D = textBox11.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            phone = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            fax = textBox5.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            city = textBox8.Text;
        }

        private void contctName_TextChanged(object sender, EventArgs e)
        {
            contactName = textBox3.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            postal = textBox7.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            region = textBox9.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            country = textBox10.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            contactName = textBox12.Text;
        }
    }
}