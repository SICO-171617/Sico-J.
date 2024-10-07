namespace StudentInfoApplication
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
            label3 = new Label();
            studentIDtxt = new TextBox();
            lastNametxt = new TextBox();
            firstNametxt = new TextBox();
            listStudentID = new ListView();
            listFirstName = new ListView();
            listLastName = new ListView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 61);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "STUDENT ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 61);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "LAST NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 61);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "FIRST NAME";
            // 
            // studentIDtxt
            // 
            studentIDtxt.Location = new Point(46, 79);
            studentIDtxt.Name = "studentIDtxt";
            studentIDtxt.Size = new Size(150, 23);
            studentIDtxt.TabIndex = 3;
            // 
            // lastNametxt
            // 
            lastNametxt.Location = new Point(202, 79);
            lastNametxt.Name = "lastNametxt";
            lastNametxt.Size = new Size(150, 23);
            lastNametxt.TabIndex = 4;
            // 
            // firstNametxt
            // 
            firstNametxt.Location = new Point(358, 79);
            firstNametxt.Name = "firstNametxt";
            firstNametxt.Size = new Size(150, 23);
            firstNametxt.TabIndex = 5;
            // 
            // listStudentID
            // 
            listStudentID.Location = new Point(46, 173);
            listStudentID.Name = "listStudentID";
            listStudentID.Size = new Size(150, 97);
            listStudentID.TabIndex = 6;
            listStudentID.UseCompatibleStateImageBehavior = false;
            listStudentID.View = View.List;
            // 
            // listFirstName
            // 
            listFirstName.Location = new Point(202, 173);
            listFirstName.Name = "listFirstName";
            listFirstName.Size = new Size(150, 97);
            listFirstName.TabIndex = 7;
            listFirstName.UseCompatibleStateImageBehavior = false;
            listFirstName.View = View.List;
            // 
            // listLastName
            // 
            listLastName.Location = new Point(358, 173);
            listLastName.Name = "listLastName";
            listLastName.Size = new Size(150, 97);
            listLastName.TabIndex = 8;
            listLastName.UseCompatibleStateImageBehavior = false;
            listLastName.View = View.List;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 155);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 9;
            label4.Text = "Student ID List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 155);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 10;
            label5.Text = "First Name List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 155);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 11;
            label6.Text = "Last Name List";
            // 
            // Button1
            // 
            Button1.Location = new Point(433, 108);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 12;
            Button1.Text = "SUBMIT";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 314);
            Controls.Add(Button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listLastName);
            Controls.Add(listFirstName);
            Controls.Add(listStudentID);
            Controls.Add(firstNametxt);
            Controls.Add(lastNametxt);
            Controls.Add(studentIDtxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox studentIDtxt;
        private TextBox lastNametxt;
        private TextBox firstNametxt;
        private ListView listStudentID;
        private ListView listFirstName;
        private ListView listLastName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Button1;
    }
}
