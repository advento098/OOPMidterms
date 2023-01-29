namespace OOPMidterms
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.student1 = new System.Windows.Forms.Button();
            this.student2 = new System.Windows.Forms.Button();
            this.student3 = new System.Windows.Forms.Button();
            this.student4 = new System.Windows.Forms.Button();
            this.student5 = new System.Windows.Forms.Button();
            this.dropDownButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.studentNumberInput = new System.Windows.Forms.TextBox();
            this.courseInput = new System.Windows.Forms.TextBox();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.genderInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(997, 79);
            this.label2.TabIndex = 1;
            this.label2.Text = "WELCOME TO REGISTRATION FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(326, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "SHOW INFO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dropDownButton);
            this.flowLayoutPanel2.Controls.Add(this.student1);
            this.flowLayoutPanel2.Controls.Add(this.student2);
            this.flowLayoutPanel2.Controls.Add(this.student3);
            this.flowLayoutPanel2.Controls.Add(this.student4);
            this.flowLayoutPanel2.Controls.Add(this.student5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(343, 130);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(291, 268);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(291, 69);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(291, 70);
            this.flowLayoutPanel2.TabIndex = 10;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // student1
            // 
            this.student1.BackColor = System.Drawing.SystemColors.Control;
            this.student1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student1.Location = new System.Drawing.Point(3, 73);
            this.student1.Name = "student1";
            this.student1.Size = new System.Drawing.Size(285, 32);
            this.student1.TabIndex = 1;
            this.student1.Text = "Student 1";
            this.student1.UseVisualStyleBackColor = false;
            this.student1.Click += new System.EventHandler(this.student1_Click);
            // 
            // student2
            // 
            this.student2.BackColor = System.Drawing.SystemColors.Control;
            this.student2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student2.Location = new System.Drawing.Point(3, 111);
            this.student2.Name = "student2";
            this.student2.Size = new System.Drawing.Size(285, 32);
            this.student2.TabIndex = 2;
            this.student2.Text = "Student 2";
            this.student2.UseVisualStyleBackColor = false;
            this.student2.Click += new System.EventHandler(this.student2_Click);
            // 
            // student3
            // 
            this.student3.BackColor = System.Drawing.SystemColors.Control;
            this.student3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student3.Location = new System.Drawing.Point(3, 149);
            this.student3.Name = "student3";
            this.student3.Size = new System.Drawing.Size(285, 32);
            this.student3.TabIndex = 3;
            this.student3.Text = "Student 3";
            this.student3.UseVisualStyleBackColor = false;
            this.student3.Click += new System.EventHandler(this.student3_Click);
            // 
            // student4
            // 
            this.student4.BackColor = System.Drawing.SystemColors.Control;
            this.student4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student4.Location = new System.Drawing.Point(3, 187);
            this.student4.Name = "student4";
            this.student4.Size = new System.Drawing.Size(285, 32);
            this.student4.TabIndex = 4;
            this.student4.Text = "Student 4";
            this.student4.UseVisualStyleBackColor = false;
            this.student4.Click += new System.EventHandler(this.student4_Click);
            // 
            // student5
            // 
            this.student5.BackColor = System.Drawing.SystemColors.Control;
            this.student5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student5.Location = new System.Drawing.Point(3, 225);
            this.student5.Name = "student5";
            this.student5.Size = new System.Drawing.Size(285, 32);
            this.student5.TabIndex = 5;
            this.student5.Text = "Student 5";
            this.student5.UseVisualStyleBackColor = false;
            this.student5.Click += new System.EventHandler(this.student5_Click);
            // 
            // dropDownButton
            // 
            this.dropDownButton.BackColor = System.Drawing.SystemColors.Control;
            this.dropDownButton.FlatAppearance.BorderSize = 0;
            this.dropDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropDownButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownButton.Image = global::OOPMidterms.Properties.Resources.dArrow;
            this.dropDownButton.Location = new System.Drawing.Point(3, 3);
            this.dropDownButton.Name = "dropDownButton";
            this.dropDownButton.Size = new System.Drawing.Size(285, 64);
            this.dropDownButton.TabIndex = 0;
            this.dropDownButton.TabStop = false;
            this.dropDownButton.Text = "SELECT STUDENT NUMBER";
            this.dropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.dropDownButton.UseVisualStyleBackColor = false;
            this.dropDownButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 10F);
            this.button2.Location = new System.Drawing.Point(326, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(323, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Calibri", 12F);
            this.nameInput.Location = new System.Drawing.Point(343, 251);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(291, 32);
            this.nameInput.TabIndex = 12;
            // 
            // studentNumberInput
            // 
            this.studentNumberInput.Font = new System.Drawing.Font("Calibri", 12F);
            this.studentNumberInput.Location = new System.Drawing.Point(343, 316);
            this.studentNumberInput.Name = "studentNumberInput";
            this.studentNumberInput.Size = new System.Drawing.Size(291, 32);
            this.studentNumberInput.TabIndex = 13;
            // 
            // courseInput
            // 
            this.courseInput.Font = new System.Drawing.Font("Calibri", 12F);
            this.courseInput.Location = new System.Drawing.Point(343, 377);
            this.courseInput.Name = "courseInput";
            this.courseInput.Size = new System.Drawing.Size(291, 32);
            this.courseInput.TabIndex = 14;
            // 
            // ageInput
            // 
            this.ageInput.Font = new System.Drawing.Font("Calibri", 12F);
            this.ageInput.Location = new System.Drawing.Point(343, 443);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(148, 32);
            this.ageInput.TabIndex = 15;
            // 
            // genderInput
            // 
            this.genderInput.Font = new System.Drawing.Font("Calibri", 12F);
            this.genderInput.Location = new System.Drawing.Point(498, 443);
            this.genderInput.Name = "genderInput";
            this.genderInput.Size = new System.Drawing.Size(136, 32);
            this.genderInput.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(466, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(452, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Student No.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(464, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(343, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(500, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gender";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(997, 726);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genderInput);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.courseInput);
            this.Controls.Add(this.studentNumberInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "--";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button dropDownButton;
        private System.Windows.Forms.Button student1;
        private System.Windows.Forms.Button student2;
        private System.Windows.Forms.Button student3;
        private System.Windows.Forms.Button student4;
        private System.Windows.Forms.Button student5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox studentNumberInput;
        private System.Windows.Forms.TextBox courseInput;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.TextBox genderInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

