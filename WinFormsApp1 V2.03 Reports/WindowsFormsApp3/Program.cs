using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.MainForms;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInForm());
            //Application.Run(new SelectReport());
        }
        public static SqlDataReader Login(string userName, string password, bool type ,SqlConnection con)
        {
            try
            {
                // writing sql query Instructor_Login
                SqlCommand cm;
                if (type)
                    cm = new SqlCommand($"Instructor_Login", con);
                else
                    cm = new SqlCommand($"Student_Login", con);
                
                // Executing the SQL query  
                // 2. set the command object so it knows
                //    to execute a stored procedure
                cm.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which
                //    will be passed to the stored procedure
                cm.Parameters.Add(new SqlParameter("@username", userName));
                cm.Parameters.Add(new SqlParameter("@password", password));

                // execute the command
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                //while (sdr.Read())
                //{
                //    Console.WriteLine("TEST : "+sdr["Stud_username"] + " " + sdr["Stud_password"]+ " END TEST"); // Displaying Record  
                //}
                return sdr;
                //return null;

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
                return null;

            }
            // Closing the connection  
            finally
            {
                //con.Close();

            }
        }

        public static List<Question> GetExam(int eid)
        {
            SqlConnection con = null;


            List<Question> Questions = new List<Question>();
            try
            {
                con = new SqlConnection("data source=.; database=Examination_System; integrated security=SSPI");
                con.Open();

                SqlCommand cm = new SqlCommand($"Select_Exam", con);

                cm.CommandType = CommandType.StoredProcedure;


                cm.Parameters.Add(new SqlParameter("@Eid", eid));

                SqlDataReader sdr = cm.ExecuteReader();

                // Iterating Data  
                while (sdr.Read())
                {

                    Question question = new Question();
                    question.ID = Convert.ToInt32(sdr["QID"]);
                    question.QuestionTxt = Convert.ToString(sdr["Question"]);
                    question.Choices.Add(Convert.ToString(sdr["Choice"]));

                    int i = 0;
                    bool flag = true;
                    for (i = 0; i < Questions.Count(); i++)
                    {
                        if (Questions[i].ID == question.ID)
                        {
                            Questions[i].Choices.Add(question.Choices.ElementAt(0));
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        Questions.Add(question);


                }
                con.Close();
                return Questions;
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
                return null;
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }

        }
    }
}
