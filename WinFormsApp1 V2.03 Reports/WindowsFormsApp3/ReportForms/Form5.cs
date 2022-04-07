﻿using System;
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
    public partial class Form5 : Form
    {
        public string ID { get; set; }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ExamQuestionsChoices examQuestionsChoices = new ExamQuestionsChoices();
            examQuestionsChoices.SetParameterValue("@eid", ID);

            crystalReportViewer5.ReportSource = examQuestionsChoices;
        }
    }
}
