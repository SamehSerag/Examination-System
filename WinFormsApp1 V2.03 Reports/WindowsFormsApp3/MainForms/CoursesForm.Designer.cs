using System.Collections.Generic;

namespace WinFormsApp1
{
    partial class CoursesForm
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
            this.labelStartExam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStartExam
            // 
            this.labelStartExam.AutoSize = true;
            this.labelStartExam.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelStartExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.labelStartExam.Location = new System.Drawing.Point(150, 24);
            this.labelStartExam.Name = "labelStartExam";
            this.labelStartExam.Size = new System.Drawing.Size(381, 38);
            this.labelStartExam.TabIndex = 1;
            this.labelStartExam.Text = "Select Course To Start Exam";
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 382);
            this.Controls.Add(this.labelStartExam);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CoursesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoursesForm";
            this.Load += new System.EventHandler(this.CoursesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStartExam;
        private List<Course> courses;
    }
}