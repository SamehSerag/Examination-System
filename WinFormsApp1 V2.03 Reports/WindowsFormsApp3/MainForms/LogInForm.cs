using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.MainForms;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
        }

        private void BtnLoginAction(object sender, EventArgs e)
        {
            //MessageBox.Show("FF");
            SqlConnection con = null;

            con = new SqlConnection("data source=.; database=Examination_System; integrated security=SSPI");
            con.Open();
            SqlDataReader sdr;
            

            sdr = Program.Login(txtUserName.Text, txtPassword.Text, radioInstructor.Checked ,con);
            if (!sdr.Read())
                MessageBox.Show("User Name or Passowrd wrong");
            else if (radioInstructor.Checked)
            {
                SelectReport selectReport = new SelectReport();
                this.Hide();
                selectReport.ShowDialog();
                this.Show();
            }       
            else { 
                //MessageBox.Show("Welcome " + sdr["Stud_username"]);
                user = new User(
                    Convert.ToInt32(sdr["Stud_ID"]), 
                    Convert.ToString(sdr["Stud_Name"]),
                    Convert.ToString(sdr["Stud_username"]),
                    Convert.ToInt32(sdr["Dept_ID"])
                    );
                //questionForm = new QuestionForm(109);
                //questionForm.ShowDialog();
                this.Visible = false;
                SelectionForm selectionForm = new SelectionForm();
                selectionForm.ShowDialog();
                try
                {
                    this.Visible = true;
                }
                catch (Exception ex)
                {

                }

            }


            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
