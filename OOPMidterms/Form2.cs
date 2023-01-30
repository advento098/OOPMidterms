using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPMidterms
{
    public partial class Form2 : Form
    {
        Form1 fm = Form1.Instance;
        public static Form2 Instance;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Student info = (Student)Form1.Instance.stdtable[Form1.Instance.studentNumber];
            stdNoLbl.Text = "Student" + " " + info.StdNo;
            name.Text = info.name;
            stdNo.Text = info.stdnumber;
            course.Text = info.course;
            age.Text = info.age;
            gender.Text = info.gender;
        }
    }
}

