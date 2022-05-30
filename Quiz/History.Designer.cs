
namespace Quiz
{
    partial class History
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
            this.question = new System.Windows.Forms.Label();
            this.button_finish = new System.Windows.Forms.Button();
            this.button_answer = new System.Windows.Forms.Button();
            this.answer_1 = new System.Windows.Forms.RadioButton();
            this.answer_2 = new System.Windows.Forms.RadioButton();
            this.answer_3 = new System.Windows.Forms.RadioButton();
            this.answer_4 = new System.Windows.Forms.RadioButton();
            this.button_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question.Location = new System.Drawing.Point(68, 55);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(1113, 62);
            this.question.TabIndex = 0;
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_finish
            // 
            this.button_finish.Location = new System.Drawing.Point(324, 441);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(137, 57);
            this.button_finish.TabIndex = 1;
            this.button_finish.Text = "Завершить";
            this.button_finish.UseVisualStyleBackColor = true;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // button_answer
            // 
            this.button_answer.Location = new System.Drawing.Point(542, 441);
            this.button_answer.Name = "button_answer";
            this.button_answer.Size = new System.Drawing.Size(137, 57);
            this.button_answer.TabIndex = 2;
            this.button_answer.Text = "Ответить";
            this.button_answer.UseVisualStyleBackColor = true;
            this.button_answer.Click += new System.EventHandler(this.button_answer_Click);
            // 
            // answer_1
            // 
            this.answer_1.AutoSize = true;
            this.answer_1.Location = new System.Drawing.Point(162, 176);
            this.answer_1.Name = "answer_1";
            this.answer_1.Size = new System.Drawing.Size(21, 20);
            this.answer_1.TabIndex = 3;
            this.answer_1.TabStop = true;
            this.answer_1.UseVisualStyleBackColor = true;
            // 
            // answer_2
            // 
            this.answer_2.AutoSize = true;
            this.answer_2.Location = new System.Drawing.Point(162, 290);
            this.answer_2.Name = "answer_2";
            this.answer_2.Size = new System.Drawing.Size(21, 20);
            this.answer_2.TabIndex = 4;
            this.answer_2.TabStop = true;
            this.answer_2.UseVisualStyleBackColor = true;
            // 
            // answer_3
            // 
            this.answer_3.AutoSize = true;
            this.answer_3.Location = new System.Drawing.Point(834, 176);
            this.answer_3.Name = "answer_3";
            this.answer_3.Size = new System.Drawing.Size(21, 20);
            this.answer_3.TabIndex = 5;
            this.answer_3.TabStop = true;
            this.answer_3.UseVisualStyleBackColor = true;
            // 
            // answer_4
            // 
            this.answer_4.AutoSize = true;
            this.answer_4.Location = new System.Drawing.Point(834, 290);
            this.answer_4.Name = "answer_4";
            this.answer_4.Size = new System.Drawing.Size(21, 20);
            this.answer_4.TabIndex = 6;
            this.answer_4.TabStop = true;
            this.answer_4.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(760, 441);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(137, 57);
            this.button_next.TabIndex = 7;
            this.button_next.Text = "Следующий";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 567);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.answer_4);
            this.Controls.Add(this.answer_3);
            this.Controls.Add(this.answer_2);
            this.Controls.Add(this.answer_1);
            this.Controls.Add(this.button_answer);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.question);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button button_finish;
        private System.Windows.Forms.Button button_answer;
        private System.Windows.Forms.RadioButton answer_1;
        private System.Windows.Forms.RadioButton answer_2;
        private System.Windows.Forms.RadioButton answer_3;
        private System.Windows.Forms.RadioButton answer_4;
        private System.Windows.Forms.Button button_next;
    }
}