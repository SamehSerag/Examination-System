using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class QuestionForm
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFinishExam = new System.Windows.Forms.Button();
            this.labelOutOf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AccessibleName = "";
            this.labelQuestion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelQuestion.Location = new System.Drawing.Point(6, 47);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelQuestion.Size = new System.Drawing.Size(764, 65);
            this.labelQuestion.TabIndex = 9;
            this.labelQuestion.Text = "Whats";
            this.labelQuestion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNext.Location = new System.Drawing.Point(655, 399);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(123, 38);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPrev.Location = new System.Drawing.Point(12, 399);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(130, 39);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFinishExam
            // 
            this.btnFinishExam.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFinishExam.ForeColor = System.Drawing.Color.Red;
            this.btnFinishExam.Location = new System.Drawing.Point(655, 7);
            this.btnFinishExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinishExam.Name = "btnFinishExam";
            this.btnFinishExam.Size = new System.Drawing.Size(123, 38);
            this.btnFinishExam.TabIndex = 16;
            this.btnFinishExam.Text = "Finish Exam";
            this.btnFinishExam.UseVisualStyleBackColor = true;
            this.btnFinishExam.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelOutOf
            // 
            this.labelOutOf.AutoSize = true;
            this.labelOutOf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelOutOf.ForeColor = System.Drawing.Color.Green;
            this.labelOutOf.Location = new System.Drawing.Point(318, 12);
            this.labelOutOf.Name = "labelOutOf";
            this.labelOutOf.Size = new System.Drawing.Size(121, 28);
            this.labelOutOf.TabIndex = 17;
            this.labelOutOf.Text = "1 Out of 10";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 449);
            this.Controls.Add(this.labelOutOf);
            this.Controls.Add(this.btnFinishExam);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.labelQuestion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private List<Question> questionsList;
        private List<List<RadioButton>> radioButtonListOfList;
        private int questionNumber = 0;
        private Button btnFinishExam;
        private Label labelOutOf;
        private int ExamID;
    }
}