using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUET_ResultManagementSystem
{
    class CoursesGateway
    {
        DBConnector connector = null;
        SqlConnection connection = null;

        public CoursesGateway()
        {
            connector = new DBConnector();
            connection = connector.Connect;
        }
        public void MessageShow(string Message, string text)// to display customize message Box
        {
            messageForm.MessageString = Message;
            messageForm mf = new messageForm();
            mf.Text = text;
            mf.ShowDialog();
        }
        public DataSet getCoursesCode(Courses c)
        {
            DataSet dataSet = null;
            try
            {
                
                connection.Open();
                string queryString = "SELECT course_code FROM courseTable WHERE department_ID = '"+c.DepartmentId + "' AND year = '"+c.Year+ "' AND semester = '"+c.Semester+"' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                dataSet = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(queryString, connection);

                da.Fill(dataSet);
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageShow("Check department name, \nyear, \nsemester \n Again","Error.");
            }
            finally
            {
                connection.Close();
            }
            return dataSet;
        }
        public string getOneCourseTitleByCoursesCode(string s)
        {
            string courseTitle = null;
            try
            {

                connection.Open();
                string queryString = "SELECT course_title FROM courseTable WHERE course_code = '"+s+"' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                courseTitle = dataReader["course_title"].ToString();

            }
            catch
            {
                MessageShow("Course not found", "Error!");
            }
            finally
            {
                connection.Close();
            }
            return courseTitle;
        }
        public string getCourseTypeByCoursesCode(string s)
        {
            string courseTitle = null;
            try
            {

                connection.Open();
                string queryString = "SELECT course_type FROM courseTable WHERE course_code = '" + s + "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                courseTitle = dataReader["course_type"].ToString();

            }
            catch
            {
                MessageShow("Data read Error!", "Error!");
            }
            finally
            {
                connection.Close();
            }
            return courseTitle;
        }

        public Courses getOneCourseInfoByCoursesCode(string s)
        {
            Courses course = new Courses();
            try
            {

                connection.Open();
                string queryString = "SELECT * FROM courseTable WHERE course_code = '" + s + "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    course.Title = dataReader["course_title"].ToString();
                    course.CreditHour = Convert.ToDouble(dataReader["credit_hour"]);
                }
            }
            catch
            {
                MessageShow("Course not found.","Error!");
            }
            finally
            {
                connection.Close();
            }
            return course;
        }
    }
}
