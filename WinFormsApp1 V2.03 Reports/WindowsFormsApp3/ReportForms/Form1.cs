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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        //public string ID { get; set; } 
        public Form1(string ID)
        {
            InitializeComponent();

            CrystalReport1 crystal = new CrystalReport1();
            crystal.SetParameterValue("@dept_id", ID);
            crystalReportViewer1.ReportSource = crystal;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
