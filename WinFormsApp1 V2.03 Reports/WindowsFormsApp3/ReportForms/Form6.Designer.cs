
namespace WindowsFormsApp3.Report_Forms
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer6 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ExamModelAnswer1 = new WindowsFormsApp3.CrystalReport.ExamModelAnswer();
            this.SuspendLayout();
            // 
            // crystalReportViewer6
            // 
            this.crystalReportViewer6.ActiveViewIndex = -1;
            this.crystalReportViewer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer6.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer6.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer6.Name = "crystalReportViewer6";
            this.crystalReportViewer6.ReportSource = this.ExamModelAnswer1;
            this.crystalReportViewer6.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer6.TabIndex = 0;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer6);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer6;
        private CrystalReport.ExamModelAnswer ExamModelAnswer1;
    }
}