namespace StudentRegistrationApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            LastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            FirstName = new TextBox();
            MiddleName = new TextBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            DOBDay = new ComboBox();
            DOBMonth = new ComboBox();
            DOBYear = new ComboBox();
            label7 = new Label();
            courseName = new ComboBox();
            RegisterBtn = new Button();
            browse = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 24);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 0;
            label1.Text = "STUDENT REGISTRATION FORM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 57);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "LAST NAME";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(381, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 168);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LastName
            // 
            LastName.Location = new Point(46, 81);
            LastName.Name = "LastName";
            LastName.Size = new Size(279, 23);
            LastName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 126);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "FIRST NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 190);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 5;
            label4.Text = "MIDDLE NAME";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(46, 144);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(279, 23);
            FirstName.TabIndex = 6;
            // 
            // MiddleName
            // 
            MiddleName.Location = new Point(46, 208);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(279, 23);
            MiddleName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 249);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 8;
            label5.Text = "Gender";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(96, 247);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(153, 247);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 282);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 11;
            label6.Text = "Date of Birth";
            // 
            // DOBDay
            // 
            DOBDay.FormattingEnabled = true;
            DOBDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            DOBDay.Location = new Point(46, 300);
            DOBDay.Name = "DOBDay";
            DOBDay.Size = new Size(73, 23);
            DOBDay.TabIndex = 12;
            // 
            // DOBMonth
            // 
            DOBMonth.FormattingEnabled = true;
            DOBMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August,", "September", "October", "November ", "December" });
            DOBMonth.Location = new Point(125, 300);
            DOBMonth.Name = "DOBMonth";
            DOBMonth.Size = new Size(120, 23);
            DOBMonth.TabIndex = 13;
            // 
            // DOBYear
            // 
            DOBYear.FormattingEnabled = true;
            DOBYear.Items.AddRange(new object[] { "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010" });
            DOBYear.Location = new Point(251, 300);
            DOBYear.Name = "DOBYear";
            DOBYear.Size = new Size(77, 23);
            DOBYear.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 336);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 15;
            label7.Text = "Program to Apply";
            // 
            // courseName
            // 
            courseName.FormattingEnabled = true;
            courseName.Items.AddRange(new object[] { "BSCS", "BSIT", "BSBA", "BMMA", "BSTM", "BSHM" });
            courseName.Location = new Point(46, 354);
            courseName.Name = "courseName";
            courseName.Size = new Size(279, 23);
            courseName.TabIndex = 16;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.Tomato;
            RegisterBtn.ForeColor = Color.White;
            RegisterBtn.Location = new Point(96, 393);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(159, 35);
            RegisterBtn.TabIndex = 17;
            RegisterBtn.Text = "Register Student";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // browse
            // 
            browse.Location = new Point(425, 282);
            browse.Name = "browse";
            browse.Size = new Size(75, 23);
            browse.TabIndex = 18;
            browse.Text = "Browse";
            browse.UseVisualStyleBackColor = true;
            browse.Click += browse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(592, 450);
            Controls.Add(browse);
            Controls.Add(RegisterBtn);
            Controls.Add(courseName);
            Controls.Add(label7);
            Controls.Add(DOBYear);
            Controls.Add(DOBMonth);
            Controls.Add(DOBDay);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(MiddleName);
            Controls.Add(FirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LastName);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox LastName;
        private Label label3;
        private Label label4;
        private TextBox FirstName;
        private TextBox MiddleName;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private ComboBox DOBDay;
        private ComboBox DOBMonth;
        private ComboBox DOBYear;
        private Label label7;
        private ComboBox courseName;
        private Button RegisterBtn;
        private Button browse;
        private OpenFileDialog openFileDialog1;
    }
}
