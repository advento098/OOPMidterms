using System;
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
    public partial class Form2 : Form
    {
        Form1 fm = new Form1(); 

        Student readStdInfo = (Student)Form1.stdtable.entry.Value;
        Console.WriteLine("Student {0}, Name: {1}, Age: {2}, Student Number: {3}, Course: {4}",
                        student2.numberOfstudent, student2.name, student2.age, student2.stdnumber, student2.course);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
