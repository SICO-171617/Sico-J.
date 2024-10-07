namespace EmployeeApplication
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            EmployeeIDtxt = new TextBox();
            FirstNametxt = new TextBox();
            LastNametxt = new TextBox();
            Positiontxt = new TextBox();
            SubmitBtn = new Button();
            DataGrid = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 39);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 39);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Employee List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 68);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Employee ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 129);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 194);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 257);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Position";
            // 
            // EmployeeIDtxt
            // 
            EmployeeIDtxt.Location = new Point(40, 86);
            EmployeeIDtxt.Name = "EmployeeIDtxt";
            EmployeeIDtxt.Size = new Size(100, 23);
            EmployeeIDtxt.TabIndex = 6;
            // 
            // FirstNametxt
            // 
            FirstNametxt.Location = new Point(40, 147);
            FirstNametxt.Name = "FirstNametxt";
            FirstNametxt.Size = new Size(100, 23);
            FirstNametxt.TabIndex = 7;
            // 
            // LastNametxt
            // 
            LastNametxt.Location = new Point(40, 212);
            LastNametxt.Name = "LastNametxt";
            LastNametxt.Size = new Size(100, 23);
            LastNametxt.TabIndex = 8;
            // 
            // Positiontxt
            // 
            Positiontxt.Location = new Point(40, 275);
            Positiontxt.Name = "Positiontxt";
            Positiontxt.Size = new Size(100, 23);
            Positiontxt.TabIndex = 9;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(54, 337);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(75, 23);
            SubmitBtn.TabIndex = 10;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // DataGrid
            // 
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(243, 68);
            DataGrid.Name = "DataGrid";
            DataGrid.Size = new Size(327, 150);
            DataGrid.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGrid);
            Controls.Add(SubmitBtn);
            Controls.Add(Positiontxt);
            Controls.Add(LastNametxt);
            Controls.Add(FirstNametxt);
            Controls.Add(EmployeeIDtxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "frmEmployeeDatabase";
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox EmployeeIDtxt;
        private TextBox FirstNametxt;
        private TextBox LastNametxt;
        private TextBox Positiontxt;
        private Button SubmitBtn;
        private DataGridView DataGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
