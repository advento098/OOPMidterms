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
using System.Xml.Serialization;



namespace OOPMidterms
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

        public void submitbtn_Click(object sender, EventArgs e)
        {
            Hashtable table = new Hashtable();
            
            Student student = new Student(nametb.Text, stdnumbertb.Text, coursetb.Text, agetb.Text, gendertb.Text);
            table.Add(student.stdnumber, student);

            
            foreach (DictionaryEntry entry in table)
            {
                Student stud = (Student)entry.Value;
                // Console.WriteLine("Student Id: {0}, Name: {1}, GPA: {2}", stud.Id, stud.Name, stud.GPA);
                Console.WriteLine("Student Name: {0}, Age: {1}, Student Number: {2}", stud.name, stud.age, stud.stdnumber);
            }
        }
        // ang problem lang di sya nag pepersist... pag inexit yung program di na nya alam kung ano yung prevous data

        // Class constructor 
        class Student {
            public string name { get; set; }
            public string stdnumber { get; set; }
            public string course{ get; set; }
            public string age{ get; set; }
            public string gender { get; set; }
            public Student(string name, string stdnumber, string course, string age, string gender) { 
                this.name = name;
                this.stdnumber = stdnumber;
                this.course = course;
                this.age = age;
                this.gender = gender;
            }
        }
        
        // Functions for Ease of Access


    }
}
