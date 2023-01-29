using OOPMidterms.Properties;
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
    public partial class Form1 : Form
    {
        Form2 fm = new Form2();
        private bool isCollapsed = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                flowLayoutPanel2.Height += 10;
                dropDownButton.Image = Resources.uArrow;
                if (flowLayoutPanel2.Size == flowLayoutPanel2.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }

            else
            {
                flowLayoutPanel2.Height -= 10;
                dropDownButton.Image = Resources.dArrow;
                if (flowLayoutPanel2.Size == flowLayoutPanel2.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void student1_Click(object sender, EventArgs e)
        {
            dropDownButton.Text = "Student 1";
            Class1 student1 = new Class1()
        }

        private void student2_Click(object sender, EventArgs e)
        {

        }

        private void student3_Click(object sender, EventArgs e)
        {

        }

        private void student4_Click(object sender, EventArgs e)
        {

        }

        private void student5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
