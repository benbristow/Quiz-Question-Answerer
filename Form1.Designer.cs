namespace Quiz_Question_Answerer
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
            this.txt_Question = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddAnswer = new System.Windows.Forms.Button();
            this.btn_RemoveAnswer = new System.Windows.Forms.Button();
            this.btn_Guess = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Question
            // 
            this.txt_Question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Question.Location = new System.Drawing.Point(12, 25);
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.Size = new System.Drawing.Size(389, 61);
            this.txt_Question.TabIndex = 0;
            this.txt_Question.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answers:";
            // 
            // btn_AddAnswer
            // 
            this.btn_AddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddAnswer.Location = new System.Drawing.Point(307, 282);
            this.btn_AddAnswer.Name = "btn_AddAnswer";
            this.btn_AddAnswer.Size = new System.Drawing.Size(44, 23);
            this.btn_AddAnswer.TabIndex = 4;
            this.btn_AddAnswer.Text = "+";
            this.btn_AddAnswer.UseVisualStyleBackColor = true;
            this.btn_AddAnswer.Click += new System.EventHandler(this.btn_AddAnswer_Click);
            // 
            // btn_RemoveAnswer
            // 
            this.btn_RemoveAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RemoveAnswer.Location = new System.Drawing.Point(357, 282);
            this.btn_RemoveAnswer.Name = "btn_RemoveAnswer";
            this.btn_RemoveAnswer.Size = new System.Drawing.Size(44, 23);
            this.btn_RemoveAnswer.TabIndex = 5;
            this.btn_RemoveAnswer.Text = "-";
            this.btn_RemoveAnswer.UseVisualStyleBackColor = true;
            this.btn_RemoveAnswer.Click += new System.EventHandler(this.btn_RemoveAnswer_Click);
            // 
            // btn_Guess
            // 
            this.btn_Guess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Guess.Location = new System.Drawing.Point(15, 282);
            this.btn_Guess.Name = "btn_Guess";
            this.btn_Guess.Size = new System.Drawing.Size(75, 23);
            this.btn_Guess.TabIndex = 6;
            this.btn_Guess.Text = "Guess";
            this.btn_Guess.UseVisualStyleBackColor = true;
            this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 105);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 171);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Reset.Location = new System.Drawing.Point(96, 282);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 312);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Guess);
            this.Controls.Add(this.btn_RemoveAnswer);
            this.Controls.Add(this.btn_AddAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Question);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quiz Question Answer Guesser";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_Question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddAnswer;
        private System.Windows.Forms.Button btn_RemoveAnswer;
        private System.Windows.Forms.Button btn_Guess;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Reset;
    }
}

