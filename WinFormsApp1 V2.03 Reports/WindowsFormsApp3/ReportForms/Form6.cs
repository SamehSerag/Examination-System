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
    public partial class Form6 : Form
    {
        public string EID { get; set; }
        public string SID { get; set; }

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ExamModelAnswer examModelAnswer = new ExamModelAnswer();
            examModelAnswer.SetParameterValue("@eid", EID);
            examModelAnswer.SetParameterValue("@sid", SID);

            crystalReportViewer6.ReportSource = examModelAnswer;
        }
    }
}
