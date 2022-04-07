using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
            labelWelcome.Text = "Welcome " + LogInForm.user.userName;
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            CoursesForm coursesForm = new CoursesForm();
            coursesForm.ShowDialog();

        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("HHH");
            frmGrades frmGrades = new frmGrades(LogInForm.user.Id);
            this.Visible = false;
            frmGrades.ShowDialog();
            this.Visible = true;

        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
        }
    }
}
