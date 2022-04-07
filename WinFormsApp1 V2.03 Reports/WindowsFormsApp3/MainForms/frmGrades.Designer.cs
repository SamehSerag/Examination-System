namespace WinFormsApp1
{
    partial class frmGrades
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
            this.grdGradesView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.bnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdGradesView)).BeginInit();
            this.SuspendLayout();
            // 
            // grdGradesView
            // 
            this.grdGradesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGradesView.Location = new System.Drawing.Point(0, 0);
            this.grdGradesView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdGradesView.Name = "grdGradesView";
            this.grdGradesView.RowHeadersWidth = 51;
            this.grdGradesView.RowTemplate.Height = 29;
            this.grdGradesView.Size = new System.Drawing.Size(433, 142);
            this.grdGradesView.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(12, 202);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 40);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bnExit
            // 
            this.bnExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bnExit.Location = new System.Drawing.Point(291, 202);
            this.bnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnExit.Name = "bnExit";
            this.bnExit.Size = new System.Drawing.Size(130, 40);
            this.bnExit.TabIndex = 17;
            this.bnExit.Text = "Exit";
            this.bnExit.UseVisualStyleBackColor = true;
            this.bnExit.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // frmGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 253);
            this.Controls.Add(this.bnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grdGradesView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrades";
            this.Load += new System.EventHandler(this.frmGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGradesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdGradesView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button bnExit;
    }
}