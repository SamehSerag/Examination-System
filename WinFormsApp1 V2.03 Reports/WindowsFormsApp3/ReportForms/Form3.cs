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
    public partial class Form3 : Form
    {
        public string ID { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            InstructCourse instructCourse = new InstructCourse();
            instructCourse.SetParameterValue("@ins_id", ID);

            crystalReportViewer3.ReportSource = instructCourse;
        }
    }
}
