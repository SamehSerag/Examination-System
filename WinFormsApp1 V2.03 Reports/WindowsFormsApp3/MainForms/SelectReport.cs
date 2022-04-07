using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Report_Forms;

namespace WindowsFormsApp3.MainForms
{
    public partial class SelectReport : Form
    {
        public SelectReport()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtID2.Text.Equals(""))
            {
                btnGenerate.Enabled = false;
            }
            else
            {
                btnGenerate.Enabled = true;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SelectReport_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            comboBox1.SelectedText = "Select Report";
            btnGenerate.Enabled = false;

            label3.Visible = false;
            txtID2.Visible = false; 
            label2.Visible = false;
            txtID.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             Select Report
                All Students In Spcific Department
                Student Grades
                Instructor Courses Info
                Course Topics
                Exam
                Exam Model Answer For Student
             */
            label3.Visible = false;
            txtID2.Visible = false;
            txtID.Text = "";
            txtID2.Text = "";
            if (comboBox1.SelectedIndex != 0)
            {
                label2.Visible = true;
                txtID.Visible = true;
                if (comboBox1.SelectedIndex == 1)
                    label2.Text = "Department ID";
                else if (comboBox1.SelectedIndex == 2)
                    label2.Text = "Student ID";
                else if (comboBox1.SelectedIndex == 3)
                    label2.Text = "Instructor ID";
                else if (comboBox1.SelectedIndex == 4)
                    label2.Text = "Course ID";
                else if (comboBox1.SelectedIndex == 5)
                    label2.Text = "Exam ID";
                else if (comboBox1.SelectedIndex == 6)
                {
                    label3.Visible = true;
                    txtID2.Visible = true;
                    label3.Text = "Exam ID";
                    label2.Text = "Student ID";
                }

            }
            else
            {
                label2.Visible = false;
                txtID.Visible = false;
                label3.Visible = false;
                txtID2.Visible = false;

                

                btnGenerate.Enabled = false;
            }

            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (!txtID.Text.Equals("") && !txtID2.Visible)
            {
                btnGenerate.Enabled = true;
               
            }
            else
            {
                btnGenerate.Enabled = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                Form1 form1 = new Form1(txtID.Text);
                this.Hide();
                form1.ShowDialog();
                this.Show();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Form2 form2 = new Form2();
                form2.ID = txtID.Text;

                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Form3 form3 = new Form3();
                form3.ID = txtID.Text;

                this.Hide();
                form3.ShowDialog();
                this.Show();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Form4 form4 = new Form4();
                form4.ID = txtID.Text;

                this.Hide();
                form4.ShowDialog();
                this.Show();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                Form5 form5 = new Form5();
                form5.ID = txtID.Text;

                this.Hide();
                form5.ShowDialog();
                this.Show();
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                Form6 form6 = new Form6();
                form6.SID = txtID.Text;
                form6.EID = txtID2.Text;

                this.Hide();
                form6.ShowDialog();
                this.Show();
            }
        }
    }
}
