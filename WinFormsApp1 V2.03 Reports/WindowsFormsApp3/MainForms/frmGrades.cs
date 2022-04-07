using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmGrades : Form
    {
        public int ID;
        public frmGrades()
        {
            InitializeComponent();
        }
        public frmGrades(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void frmGrades_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            grdGradesView.RowsAdded += (obj, arg) => AutoHeightGrid(grdGradesView);
            grdGradesView.RowsRemoved += (obj, arg) => AutoHeightGrid(grdGradesView);
            SqlConnection con = null;


            List<Question> Questions = new List<Question>();
            try
            {
                con = new SqlConnection("data source=.; database=Examination_System; integrated security=SSPI");
                //con.Open();

                SqlCommand cm = new SqlCommand($"SelectStudentGrades", con);
                cm.CommandType = CommandType.StoredProcedure;

                
                cm.Parameters.Add(new SqlParameter("@Sid", ID));

                SqlDataAdapter Da = new SqlDataAdapter(cm);
                DataTable DT = new DataTable();

                Da.Fill(DT);
                grdGradesView.DataSource = DT;
                grdGradesView.Columns["Course"].ReadOnly = true;
                grdGradesView.Columns["Grade"].ReadOnly = true;
                grdGradesView.Columns["Course"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception excep)
            {
                Console.WriteLine("OOPs, something went wrong." + excep);
            }


        }
        void AutoHeightGrid(DataGridView grid)
        {
            var proposedSize = grid.GetPreferredSize(new Size(0, 0));
            grid.Height = proposedSize.Height;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
