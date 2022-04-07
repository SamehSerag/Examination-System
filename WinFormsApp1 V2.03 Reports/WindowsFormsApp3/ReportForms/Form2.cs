using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.CrystalReport;

namespace WindowsFormsApp3.Report_Forms
{
    public partial class Form2 : Form
    {
        public string ID { get; set; } 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StudentGrades studentGrades = new StudentGrades();
            studentGrades.SetParameterValue("@sid", ID);

            crystalReportViewer2.ReportSource = studentGrades;
        }
    }
}
