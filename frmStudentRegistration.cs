using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using StudentRegistrationData;
using System.Xml.Linq;
using System.Security.Policy;
using System.IO;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 31; i++)
            {
                comboBox1.Items.Add(i + 1);
            }

            for (int i = 0; i < 12; i++)
            {
                comboBox3.Items.Add(i + 1);
            }

            for (int i = 0; i <= 34; i++)
            {
                comboBox2.Items.Add(i + 1990);
            }

            string[] courses = { "Bachelor of Science in Computer Science (BSCS)", "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Science in Computer Engineering (BSCpE)",
            "Bachelor of Science in Accounting Information System (BSAIS)", "Bachelor of Science in Hospitality Management (BSHM)", "Bachelor of Science in Tourism Management (BSTM)",
            "Associate in Computer Technology (ACT)", "Associate in Retail Technology (ART)"};

            for(int i = 0; i < courses.Length; i++)
            {
                comboBox4.Items.Add(courses[i]);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDisplayMessage display = new frmDisplayMessage();

            try
            {
                string fname = textBox2.Text;
                string lname = textBox1.Text;
                string mname = textBox3.Text;
                string date_day = comboBox1.Text;
                string date_month = comboBox3.Text;
                string date_year = comboBox2.Text;
                string course = comboBox4.Text;
                string gender = "";
                string urlArchivo = "";

                if (radioButton2.Checked == true)
                {
                    gender = "Male";
                }
                else if (radioButton1.Checked == true)
                {
                    gender = "Female";
                }

                if (textBox2.Text != "" && textBox1.Text != "" && textBox3.Text != "" && comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1 && comboBox4.SelectedIndex > -1){
                    if ((radioButton1.Checked == true && radioButton2.Checked == false) || (radioButton1.Checked == false && radioButton2.Checked == true))
                    {

                        

                        display.displayMessage(fname, lname, mname, gender, date_day, date_month, date_year, course, urlArchivo);
                        display.Show();
                    } else
                    {
                       display.displayMessage();
                    }
                } else if (textBox2.Text != "" && textBox1.Text != "" && textBox3.Text != "" && comboBox4.SelectedIndex > -1)
                {
                    display.displayMessage(fname, lname, mname, course);
                    display.Show();
                } else if (textBox2.Text != "" && textBox1.Text != "" && comboBox4.SelectedIndex > -1)
                {
                    display.displayMessage(fname, lname, course);
                    display.Show();
                    
                }
                else
                {
                    display.displayMessage();
                    display.Show();
                    
                } 

            } 
            catch (FormatException)
            {
                display.displayMessage();
                display.Show();
            }

            
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                string urlArchivo = openFileDialog1.FileName;
                //display.displayMessage(urlArchivo);


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
