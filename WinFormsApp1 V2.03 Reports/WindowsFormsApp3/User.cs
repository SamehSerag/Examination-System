using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public class User
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string userName { get; set; }
		public int Did { get; set; }
		public List<Course> Courses { get; set;}

		//public Student() { }
		public User(int id, string name, string username, int did)
		{
			Id = id;
			Name = name;
			userName = username;
			Did = did;
            Courses = new List<Course>();
            GetCourses(id);

		}
        private void GetCourses(int eid)
        {
            SqlConnection con = null;


            try
            {
                con = new SqlConnection("data source=.; database=Examination_System; " +
                    "integrated security=SSPI");
                con.Open();

                SqlCommand cm = new SqlCommand($"Select_Courses", con);

                cm.CommandType = CommandType.StoredProcedure;


                cm.Parameters.Add(new SqlParameter("@Sid", eid));

                SqlDataReader sdr = cm.ExecuteReader();

                // Iterating Data  
                while (sdr.Read())
                {

                    Course course = new Course(Convert.ToInt32(sdr["CID"]),
                        Convert.ToString(sdr["Course_Name"]));

                    Courses.Add(course);

                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, Problem with adding courses" + e);
            }
        }

	}
}