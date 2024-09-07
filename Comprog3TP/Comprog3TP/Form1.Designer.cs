namespace Comprog3TP
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
            lb_mask_word = new Label();
            label2 = new Label();
            wrong_guessed_list = new ListBox();
            tb_guess = new Button();
            tb_answer = new TextBox();
            SuspendLayout();
            // 
            // lb_mask_word
            // 
            lb_mask_word.AutoSize = true;
            lb_mask_word.BackColor = SystemColors.ActiveCaption;
            lb_mask_word.Font = new Font("Segoe UI", 16F);
            lb_mask_word.Location = new Point(41, 54);
            lb_mask_word.Name = "lb_mask_word";
            lb_mask_word.Size = new Size(172, 30);
            lb_mask_word.TabIndex = 0;
            lb_mask_word.Text = "Guess The Word";
            lb_mask_word.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(237, 54);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Previous Guesses";
            // 
            // wrong_guessed_list
            // 
            wrong_guessed_list.FormattingEnabled = true;
            wrong_guessed_list.ItemHeight = 15;
            wrong_guessed_list.Location = new Point(237, 76);
            wrong_guessed_list.Name = "wrong_guessed_list";
            wrong_guessed_list.Size = new Size(120, 94);
            wrong_guessed_list.TabIndex = 2;
            // 
            // tb_guess
            // 
            tb_guess.Location = new Point(67, 119);
            tb_guess.Name = "tb_guess";
            tb_guess.Size = new Size(116, 51);
            tb_guess.TabIndex = 3;
            tb_guess.Text = "Guess";
            tb_guess.UseVisualStyleBackColor = true;
            tb_guess.Click += tb_guess_Click;
            // 
            // tb_answer
            // 
            tb_answer.Location = new Point(24, 87);
            tb_answer.Name = "tb_answer";
            tb_answer.Size = new Size(207, 23);
            tb_answer.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 198);
            Controls.Add(tb_answer);
            Controls.Add(tb_guess);
            Controls.Add(wrong_guessed_list);
            Controls.Add(label2);
            Controls.Add(lb_mask_word);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_mask_word;
        private Label label2;
        private ListBox wrong_guessed_list;
        private Button tb_guess;
        private TextBox tb_answer;
    }
}
