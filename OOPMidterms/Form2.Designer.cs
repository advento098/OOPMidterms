namespace OOPMidterms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stdNoLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.stdNo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stdNoLbl
            // 
            this.stdNoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stdNoLbl.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdNoLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stdNoLbl.Location = new System.Drawing.Point(0, 19);
            this.stdNoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stdNoLbl.Name = "stdNoLbl";
            this.stdNoLbl.Size = new System.Drawing.Size(748, 36);
            this.stdNoLbl.TabIndex = 1;
            this.stdNoLbl.Text = "Student -";
            this.stdNoLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stdNoLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stdNoLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 70);
            this.panel1.TabIndex = 19;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(330, 151);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(71, 26);
            this.name.TabIndex = 24;
            this.name.Text = "Name";
            // 
            // gender
            // 
            this.gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.White;
            this.gender.Location = new System.Drawing.Point(324, 451);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(84, 26);
            this.gender.TabIndex = 28;
            this.gender.Text = "Gender";
            // 
            // age
            // 
            this.age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.Color.White;
            this.age.Location = new System.Drawing.Point(339, 374);
            this.age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(51, 26);
            this.age.TabIndex = 27;
            this.age.Text = "Age";
            // 
            // course
            // 
            this.course.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.course.AutoSize = true;
            this.course.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.ForeColor = System.Drawing.Color.White;
            this.course.Location = new System.Drawing.Point(324, 295);
            this.course.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(82, 26);
            this.course.TabIndex = 26;
            this.course.Text = "Course";
            // 
            // stdNo
            // 
            this.stdNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stdNo.AutoSize = true;
            this.stdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdNo.ForeColor = System.Drawing.Color.White;
            this.stdNo.Location = new System.Drawing.Point(266, 224);
            this.stdNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stdNo.Name = "stdNo";
            this.stdNo.Size = new System.Drawing.Size(199, 26);
            this.stdNo.TabIndex = 25;
            this.stdNo.Text = "Student ID Number";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(748, 590);
            this.Controls.Add(this.name);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.age);
            this.Controls.Add(this.course);
            this.Controls.Add(this.stdNo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stdNoLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.Label stdNo;
    }
}