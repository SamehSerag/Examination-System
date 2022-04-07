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
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
            
            courses = new List<Course>();
            courses = SelectCourses(LogInForm.user.Id);

            if (courses != null)
            {
                //labelStartExam.Text = "IF  " + courses.Count;

                int row = 1;
                int column = 0;
                for (int i = 0; i < courses.Count; i++, column++)
                {
                    if (i % 3 == 0 && i != 0)
                    {
                        row++;
                        column = 0;
                    }
                    //labelStartExam.Text += "G ";
                    Button btn = new Button();
                    btn.Text = courses[i].Name;
                    //Segoe UI, 13.8pt, style=Bold
                    btn.Font = new Font("Segoe UI", (float)13.8, FontStyle.Bold);
                    btn.Location = new Point(12 + column * 180, 80 * row);
                    btn.Size = new Size(150, 50);


                    btn.Click += new EventHandler(FireExam);

                    btn.Name = courses[i].Name;

                    this.Controls.Add(btn);

                }
            }
            else
            {
                MessageBox.Show("No Available Exams");

            }

        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
        }
        private List<Course> SelectCourses(int sid)
        {
            
            SqlConnection con = null;


            List<Course> courses = new List<Course>();
            try
            {
                con = new SqlConnection("data source=.; database=Examination_System; integrated security=SSPI");
                con.Open();

                SqlCommand cm = new SqlCommand($"Select_Courses", con);

                cm.CommandType = CommandType.StoredProcedure;


                cm.Parameters.Add(new SqlParameter("@Sid", sid));

                SqlDataReader sdr = cm.ExecuteReader();

                // Iterating Data  
                while (sdr.Read())
                {
                    courses.Add(new Course(
                                   Convert.ToInt32(sdr["CID"]), 
                                   Convert.ToString(sdr["Course_Name"])) 
                                    );
                }

                return courses;

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong with select courses." + e);
                return null;
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
 
        }
        private void FireExam(object sender, EventArgs e)
        {
            var btn = sender as Button;
            
            int examID = GenerateExam(btn.Text);
            this.Close();
            QuestionForm questionForm = new QuestionForm(examID);
            questionForm.ShowDialog();


        }
        private int GenerateExam(string cname)
        {
            SqlConnection con = null;
            Random random = new Random();
            int MCQRandNum = random.Next(11); /// < 11 (max = 10)
            int TFRandNum = 10 - MCQRandNum;

            try
            {
                con = new SqlConnection("data source=.; database=Examination_System; integrated security=SSPI");
                con.Open();

                SqlCommand cm = new SqlCommand($"Exam_generation", con);

                cm.CommandType = CommandType.StoredProcedure;


                cm.Parameters.Add(new SqlParameter("@cname", cname));
                cm.Parameters.Add(new SqlParameter("@MCQNum", MCQRandNum));
                cm.Parameters.Add(new SqlParameter("@TFNum", TFRandNum));

                SqlDataReader sdr = cm.ExecuteReader();
                //Console.WriteLine(sdr["EID"]);
                // Iterating Data  
                if(sdr.Read())
                    return Convert.ToInt32(sdr["EID"]);

                return 0;

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong with Generate Exam." + e);
                return 0;
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
