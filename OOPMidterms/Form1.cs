using OOPMidterms.Properties;
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

namespace OOPMidterms
{
    public partial class Form1 : Form
    {
        int studentNumber;
        Form2 fm = new Form2();

        Hashtable stdtable = new Hashtable();
        // gumawa nalang ako  dito ng hash table
        // para maccess yung items sa hashtable ganto
        // Student kahit-anong-varName = (Student)stdtable["student number"];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void submitbtn_Click(object sender, EventArgs e)
        {
            if (studentNumber == 0 && String.IsNullOrEmpty(nametb.Text) && String.IsNullOrEmpty(stdnumbertb.Text)
                && String.IsNullOrEmpty(coursetb.Text) && String.IsNullOrEmpty(agetb.Text) && String.IsNullOrEmpty(gendertb.Text))
            {
                MessageBox.Show("Field is empty or not complete\n Please complete the registration");
            }
            else if (studentNumber == 0 && nametb.Text.Length > 2 && stdnumbertb.Text.Length > 2 && coursetb.Text.Length > 2
                && agetb.Text.Length > 1 && gendertb.Text.Length > 1)
            {
                MessageBox.Show("No student number is selected\n Please select 1 and register");
            }
            else if (studentNumber > 0)
            {
                Student student = new Student(studentNumber, nametb.Text, stdnumbertb.Text, coursetb.Text, agetb.Text, gendertb.Text);
                stdtable.Add(student.numberOfstudent, student);
                MessageBox.Show("Student Added");
                // itong nasa taas lang talaga importante ehhehe

                // mga logs lang para masundan natin yung data
                Console.WriteLine("All Students: ");
                foreach (DictionaryEntry entry in stdtable)
                {
                    Student student2 = (Student)entry.Value;
                    Console.WriteLine("Student {0}, Name: {1}, Age: {2}, Student Number: {3}, Course: {4}",
                        student2.numberOfstudent, student2.name, student2.age, student2.stdnumber, student2.course);
                }
                Console.WriteLine("End of List \n");
                // end of logs 
            }


        }

        private void selectStudent_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void std1_Click(object sender, EventArgs e)
        {
            studentNumber = 1;
            stdNoLabel.Text = "Student" + " " + studentNumber.ToString();
        }

        private void std2_Click(object sender, EventArgs e)
        {
            studentNumber = 2;
            stdNoLabel.Text = "Student" + " " + studentNumber.ToString();
        }

        private void std3_Click(object sender, EventArgs e)
        {
            studentNumber = 3;
            stdNoLabel.Text = "Student" + " " + studentNumber.ToString();
        }

        private void std4_Click(object sender, EventArgs e)
        {
            studentNumber = 4;
            stdNoLabel.Text = "Student" + " " + studentNumber.ToString();
        }

        private void std5_Click(object sender, EventArgs e)
        {
            studentNumber = 5;
            stdNoLabel.Text = "Student" + " " + studentNumber.ToString();
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            if (studentNumber == 0) 
            {
                MessageBox.Show("No student information to show\n Please register");
            }
            else if (studentNumber > 0)
            {
                this.Hide();
                fm.ShowDialog();
            }

            
        }
        // ang problem lang di sya nag pepersist... pag inexit yung program di na nya alam kung ano yung prevous data


    }
}

    public class Student {

        public int numberOfstudent { get; set; }
        public string name { get; set; }
        public string stdnumber { get; set; }
        public string course{ get; set; }
        public string age{ get; set; }
        public string gender { get; set; }
        public Student(int stdNo, string name, string stdnumber, string course, string age, string gender) { 
            
            this.numberOfstudent= stdNo;
            this.name = name;
            this.stdnumber = stdnumber;
            this.course = course;
            this.age = age;
            this.gender = gender;
        }
     }


    