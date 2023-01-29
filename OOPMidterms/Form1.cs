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
            Student student = new Student(nametb.Text, stdnumbertb.Text, coursetb.Text, agetb.Text, gendertb.Text);
            stdtable.Add(student.stdnumber, student);
            MessageBox.Show("Student Added");
            // itong nasa taas lang talaga importante ehhehe

            // mga logs lang para masundan natin yung data
            Console.WriteLine("All Students: ");
            foreach (DictionaryEntry entry in stdtable)
            {
                Student student2 = (Student)entry.Value;
                Console.WriteLine("Name: {0}, Age: {1}, Student Number: {2}, Course: {3}", student2.name, student2.age, student2.stdnumber, student2.course);
            }
            Console.WriteLine("End of List \n");
            // end of logs 
        }
        // ang problem lang di sya nag pepersist... pag inexit yung program di na nya alam kung ano yung prevous data
    }
}

public class Student {
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


    