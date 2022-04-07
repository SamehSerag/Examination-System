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
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
        }
        public QuestionForm (int eid)
        {
            InitializeComponent ();
            ExamID = eid;
            btnPrev.Enabled = false;

            //questionsList = new List<Question>();
            radioButtonListOfList = new List< List<RadioButton> >();

            questionsList = Program.GetExam(eid);
            Question question1 = questionsList.ElementAt(questionNumber);
            labelQuestion.Text = "- " + question1.QuestionTxt;

            
            List<RadioButton> radioButtonQustionList = new List<RadioButton>();

            for(int i = 0; i < question1.Choices.Count(); i++)
            {
                RadioButton rb = new RadioButton();
                rb.AutoSize = false;
                rb.Size = new Size(this.ClientSize.Width-10, 50);

                rb.Text = question1.Choices.ElementAt(i);
                rb.Location = new Point(20, 100 + (i)*50);
                rb.Font = new Font("Berlin Sans FB", 12);

                radioButtonQustionList.Add(rb);
                // Adding this label to the form
                this.Controls.Add(rb);
            }
            radioButtonListOfList.Add(radioButtonQustionList);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
        }

        private void radioAnswerA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
            this.Controls.Clear();
            this.InitializeComponent();
            if (questionNumber+2 == questionsList.Count())
                btnNext.Enabled = false;
            labelOutOf.Text = questionNumber + 2 + " Out of " + questionsList.Count();
            Question question1 = questionsList.ElementAt(++questionNumber);
            labelQuestion.Text = "- " + question1.QuestionTxt;

            if(radioButtonListOfList.Count() <= questionNumber)
            {
                List<RadioButton> radioButtonQustionList = new List<RadioButton>();

                for (int i = 0; i < question1.Choices.Count(); i++)
                {
                    RadioButton rb = new RadioButton();
                    rb.AutoSize = false;
                    rb.Size = new Size(this.ClientSize.Width-10, 50);
                    rb.Text = question1.Choices.ElementAt(i);
                    rb.Location = new Point(30, 100 + (i) * 50);
                    rb.Font = new Font("Berlin Sans FB", 12);
                    radioButtonQustionList.Add(rb);
                    // Adding this label to the form
                    this.Controls.Add(rb);
                }
                radioButtonListOfList.Add(radioButtonQustionList);
            }
            else
            {
                for (int i = 0; 
                    i < radioButtonListOfList.ElementAt(questionNumber).Count()
                    ; i++)
                {
                    this.Controls.Add(radioButtonListOfList.
                        ElementAt(questionNumber).ElementAt(i));
                }
            }
            

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            if (questionNumber == 1)
                btnPrev.Enabled = false;

            labelOutOf.Text = questionNumber + " Out of " + questionsList.Count();
            Question question1 = questionsList.ElementAt(--questionNumber);
            labelQuestion.Text = "- " + question1.QuestionTxt;

            for (int i = 0; i < radioButtonListOfList.ElementAt(questionNumber).Count()
                ; i++)
            {
                this.Controls.Add(radioButtonListOfList.
                    ElementAt(questionNumber).ElementAt(i));
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            char?[] answers = new char?[ questionsList.Count()];

            for(int i = 0; i< radioButtonListOfList.Count(); i++)
            {
                for(int j = 0; j < radioButtonListOfList[i].Count(); j++)
                {
                    if (radioButtonListOfList[i][j].Checked)
                    {
                        answers[i] = (char)('a' + j);
                        break;
                    }

                }
                //answers[i] = null;
            }
            SendAnswers(answers);
            this.Close();
        }
        private void SendAnswers(char?[] answers)
        {
            SqlConnection con = null;


            List<Question> Questions = new List<Question>();
            try
            {
                con = new SqlConnection("data source=.; database=Examination_System; integrated security=SSPI");
                con.Open();

                SqlCommand cm = new SqlCommand($"Exam_Answers", con);

                cm.CommandType = CommandType.StoredProcedure;


                cm.Parameters.Add(new SqlParameter("@Eid", ExamID));
                cm.Parameters.Add(new SqlParameter("@SID", LogInForm.user.Id));
                cm.Parameters.Add(new SqlParameter("@ans1", answers[0] ?? '0'));
                cm.Parameters.Add(new SqlParameter("@ans2", answers[1] ?? '0'));
                cm.Parameters.Add(new SqlParameter("@ans3", answers[2] ?? '0'));
                cm.Parameters.Add(new SqlParameter("@ans4", answers[3] ?? '0'));
                cm.Parameters.Add(new SqlParameter("@ans5", answers[4] ?? '0'));
                cm.Parameters.Add(new SqlParameter("@ans6", answers[5] ?? '0'));
                cm.Parameters.Add(new SqlParameter("@ans7", answers[6] ?? '0'));
                cm.Parameters.Add(new SqlParameter("@ans8", answers[7] ?? '0'));
                cm.Parameters.Add(new SqlParameter("@ans9", answers[8] ?? '0'));
                cm.Parameters.Add(new SqlParameter("@ans10", answers[9] ?? '0'));

                SqlDataReader sdr = cm.ExecuteReader();

                cm = new SqlCommand($"Exam_Answers", con);

                cm.CommandType = CommandType.StoredProcedure;

                // Iterating Data  
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }

        }
    
    }
}
