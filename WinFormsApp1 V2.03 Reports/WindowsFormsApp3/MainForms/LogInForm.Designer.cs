using System.Collections.Generic;
namespace WinFormsApp1
{
    partial class LogInForm
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
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.radioInstructor = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioStudent
            // 
            this.radioStudent.AccessibleName = "radioStudent";
            this.radioStudent.AutoSize = true;
            this.radioStudent.Checked = true;
            this.radioStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioStudent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioStudent.Location = new System.Drawing.Point(237, 233);
            this.radioStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(101, 32);
            this.radioStudent.TabIndex = 13;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "Student";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleName = "btnLogin";
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogin.Location = new System.Drawing.Point(403, 295);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 43);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLoginAction);
            // 
            // radioInstructor
            // 
            this.radioInstructor.AccessibleName = "";
            this.radioInstructor.AutoSize = true;
            this.radioInstructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioInstructor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioInstructor.Location = new System.Drawing.Point(391, 233);
            this.radioInstructor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioInstructor.Name = "radioInstructor";
            this.radioInstructor.Size = new System.Drawing.Size(117, 32);
            this.radioInstructor.TabIndex = 11;
            this.radioInstructor.Text = "Instructor";
            this.radioInstructor.UseVisualStyleBackColor = true;
            this.radioInstructor.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(70, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleName = "";
            this.txtPassword.Location = new System.Drawing.Point(237, 174);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(271, 30);
            this.txtPassword.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(70, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Name :";
            // 
            // txtUserName
            // 
            this.txtUserName.AccessibleName = "txtUserName";
            this.txtUserName.Location = new System.Drawing.Point(237, 118);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(271, 30);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(82, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 54);
            this.label3.TabIndex = 14;
            this.label3.Text = "Examination System";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 388);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioStudent);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.radioInstructor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton radioInstructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        public static User user;
        private QuestionForm questionForm;
        //private List<Question> questionList;
    }
}
