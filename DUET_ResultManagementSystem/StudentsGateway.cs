using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUET_ResultManagementSystem
{
    

    class StudentsGateway
    {
        DBConnector connector = null;
        SqlConnection connection = null;
       public StudentsGateway()
        {
            connector = new DBConnector();
            connection = connector.Connect;
        }
        public void MessageShow(string s)// to display customize message Box
        {
            messageForm.MessageString = s;
            messageForm mf = new messageForm();
            mf.Show();
        }
        public void addNewStudent(Students s)
        {
            try
            {
                connection.Open();
                string InsertString = "INSERT INTO  studentsTable VALUES('" + s.ID + "', '" + s.Name + "', '" + s.Department + "', '" + s.Year + "', '" + s.Semester + "', '" + s.Session + "')";
                SqlCommand command = new SqlCommand(InsertString, connection);
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageShow("Data Write Error!");
            }
            finally
            {
                connection.Close();
            }

        }
        public List<Students> getAllStudentsInformation(Students s)
        {
            List<Students> students = null;
            try
            {
                connection.Open();

                string queryString = "SELECT * FROM studentsTable WHERE student_department = '"+s.Department+ "' AND current_year = '"+s.Year+ "' AND current_semester = '"+s.Semester+ "' ORDER BY studentID ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                students = new List<Students>();
                while (dataReader.Read())
                {
                   Students Student = new Students();
                    Student.ID = Convert.ToInt32(dataReader["studentID"]);
                    Student.Name = dataReader["student_name"].ToString();
                    Student.Department = s.Department;
                    Student.Year = s.Year;
                    Student.Semester = s.Semester;
                    Student.Session = dataReader["session"].ToString();
                    students.Add(Student);
                }
   
            }
            catch
            {
                MessageShow("Data read Error!");
            }
            finally
            {
                connection.Close();
            }

            return students;
        }
        public Students getOneStudentInformation(Students s)
        {
            Students student = new Students();
            try
            {
                connection.Open();

                string queryString = "SELECT * FROM studentsTable WHERE studentID = '"+s.ID+"' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                dataReader.Read();

                student.ID = Convert.ToInt32(dataReader["studentID"]);
                student.Name = dataReader["student_name"].ToString();
                student.Department = dataReader["student_department"].ToString();
                student.Year = dataReader["current_year"].ToString();
                student.Semester = dataReader["current_semester"].ToString();
                student.Session = dataReader["session"].ToString();

            }
            catch
            {
                MessageShow("No Student Found.");
            }
            finally
            {
                connection.Close();
            }

            return student;
        }
    }
}
