namespace WinFormsApp1
{
    partial class SelectionForm
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.labelWelcome.Location = new System.Drawing.Point(223, 17);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(236, 38);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome KKKKK";
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnGrade.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnGrade.Location = new System.Drawing.Point(12, 113);
            this.btnGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(218, 67);
            this.btnGrade.TabIndex = 1;
            this.btnGrade.Text = "Your Grades";
            this.btnGrade.UseVisualStyleBackColor = false;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnStartExam
            // 
            this.btnStartExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnStartExam.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnStartExam.Location = new System.Drawing.Point(435, 113);
            this.btnStartExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(218, 67);
            this.btnStartExam.TabIndex = 2;
            this.btnStartExam.Text = "Start Exam";
            this.btnStartExam.UseVisualStyleBackColor = false;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 219);
            this.Controls.Add(this.btnStartExam);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.labelWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectionForm";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnStartExam;
    }
}