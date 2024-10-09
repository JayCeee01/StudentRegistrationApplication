using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationData
{
    internal class Student_Data
    {
        public string fname, lname, mname, gender, date_day, date_month, date_year, course;

        public Student_Data()
        {

        }

        public Student_Data(string fname, string lname, string mname, string gender, string date_day, string date_month, string date_year, string course)
        {
            this.fname = fname;
            this.lname = lname;
            this.mname = mname;
            this.gender = gender;
            this.date_day = date_month;
            this.date_year = date_year;
            this.course = course;
        }

      

        public void showInfo(string fname, string lname, string mname, string gender, string date_day, string date_month, string date_year, string course)
        {

            MessageBox.Show("Student Name: " + fname + " " + mname + " " + lname + "\n" + "Gender: " + gender +
            "\nDate of Birth: " + date_day + "/" + date_month + "/" + date_year + "\nProgram: " + course);
        }

        public void showInfo(string fname, string lname, string mname, string course)
        {

            MessageBox.Show("Student Name: " + fname + " " + mname + " " + lname + "\nProgram: " + course);
        }

        public void showInfo(string fname, string lname, string course)
        {

            MessageBox.Show("Student Name: " + fname + " "  + lname  + "\nProgram: " + course);
        }





    }
}
