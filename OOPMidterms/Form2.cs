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

        public static Form2 Instance;
        //Class1 fm1 = new Class1();

        //Student readStdInfo = fm.stdtable

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



/*switch (Form1.Instance.studentNumber)
            {
                case 1:
                    stdNoLbl.Text = "Student" + " " + item.StdNo;
                    stdNo.Text = item.stdnumber;
                    course.Text = item.course;
                    age.Text = item.age;
                    gender.Text = item.gender;
                    break;
                case 2:
                    stdNoLbl.Text = "Student" + " " + item.StdNo;
                    stdNo.Text = item.stdnumber;
                    course.Text = item.course;
                    age.Text = item.age;
                    gender.Text = item.gender;
                    break;
                case 3:
                    stdNoLbl.Text = "Student" + " " + item.StdNo;
                    stdNo.Text = item.stdnumber;
                    course.Text = item.course;
                    age.Text = item.age;
                    gender.Text = item.gender;
                    break;
                case 4:
                    stdNoLbl.Text = "Student" + " " + item.StdNo;
                    stdNo.Text = item.stdnumber;
                    course.Text = item.course;
                    age.Text = item.age;
                    gender.Text = item.gender;
                    break;
                case 5:
                    stdNoLbl.Text = "Student" + " " + item.StdNo;
                    stdNo.Text = item.stdnumber;
                    course.Text = item.course;
                    age.Text = item.age;
                    gender.Text = item.gender;
                    break;

                default:
                    break;
            }

        }*/