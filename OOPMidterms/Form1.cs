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
        public static Form1 Instance;

        public int studentNumber;
        Form2 fm = new Form2();

        public Hashtable stdtable = new Hashtable();
        // gumawa nalang ako  dito ng hash table
        // para maccess yung items sa hashtable ganto
        // Student kahit-anong-varName = (Student)stdtable["student number"];
        public Form1()
        {
            InitializeComponent();
            Instance = this;
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
                MessageBox.Show("No student number is selected\n Please select one and register");
            }
            
            else if (studentNumber > 0 )
            {   
                if(stdtable.ContainsKey(studentNumber.ToString()))
                {
                    MessageBox.Show("Student already registered\nPlease select another student");
                }
                else
                {
                    Student std = new Student(studentNumber, nametb.Text, stdnumbertb.Text, coursetb.Text, agetb.Text, gendertb.Text);
                    stdtable.Add(studentNumber.ToString(), std);
                    MessageBox.Show("Student" + " " + studentNumber.ToString() + " " + "is registered");
                    studentNumber = 0;
                    stdNoLabel.Text = "Student ##";
                    nametb.Text = "";
                    stdnumbertb.Text = "";
                    coursetb.Text = "";
                    agetb.Text = "";
                    gendertb.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Field is empty or not complete\nPlease complete the registration");
            }
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
                MessageBox.Show("No student information to show\nPlease register");
            }
            else if (studentNumber > 0)
            {
                this.Hide();
                fm.ShowDialog();
            }  
        }
    }
}

    public class Student {

        public int StdNo { get; set; }
        public string name { get; set; }
        public string stdnumber { get; set; }
        public string course{ get; set; }
        public string age{ get; set; }
        public string gender { get; set; }
        public Student(int stdNo, string name, string stdnumber, string course, string age, string gender) { 
            
            this.StdNo= stdNo;
            this.name = name;
            this.stdnumber = stdnumber;
            this.course = course;
            this.age = age;
            this.gender = gender;
        }
     }


    