using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmDisplayMessage : Form
    {
        
        public frmDisplayMessage()
        {
            //Jerome Jerico L. Capuz BSCS301 ComProg
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void displayMessage(string fname, string lname, string mname, string gender, string date_day, string date_month, string date_year, string course, Image id)
        {
            textBox1.Text = "Student Name: " + fname + " " + mname + " " + lname + Environment.NewLine + "Gender: " + gender +
            Environment.NewLine + "Date of Birth: " + date_day + "/" + date_month + "/" + date_year + Environment.NewLine + "Program: " + course;
            labelTitle.Text = "Account Successfullly Registered!";
            pictureBox1.Image = id;
        }

        public void displayMessage(string fname, string lname, string mname, string course, Image id)
        {
            textBox1.Text = "Student Name: " + fname + " " + mname + " " + lname + Environment.NewLine + "Program: " + course;
            labelTitle.Text = "Account Successfullly Registered!";
            pictureBox1.Image = id;
        }

        public void displayMessage(string fname, string lname, string course, Image id)
        {
            textBox1.Text = "Student Name: " + fname + " " + lname + Environment.NewLine + "Program: " + course;
            labelTitle.Text = "Account Successfullly Registered!";
            pictureBox1.Image = id;
        }

        public void displayMessage()
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = "Something went wrong! Please fill out all of the boxes";
            labelTitle.Text = "An error has occured!";
        }

        private void frmDisplayMessage_Load(object sender, EventArgs e)
        {
            
        }

        private void labelTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }

}
