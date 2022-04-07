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
    public partial class Form4 : Form
    {
        public string ID;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CourseTopics courseTopics = new CourseTopics();
            courseTopics.SetParameterValue("@sid", ID);

            crystalReportViewer4.ReportSource = courseTopics;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
