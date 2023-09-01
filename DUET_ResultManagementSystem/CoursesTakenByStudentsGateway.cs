using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUET_ResultManagementSystem
{
    class CoursesTakenByStudentsGateway
    {
        DBConnector connector = null;
        SqlConnection connection = null;

        public CoursesTakenByStudentsGateway()
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
        public void addCourseToTable(Students s)
        {
            try
            {
                connection.Open();
                //insert into coursesTakenByStudentsTable
                string insertString = "INSERT INTO coursesTakenByStudentsTable(studentID, course_code) VALUES('" +s.ID+ "', '" +s.Name+ "') ";
                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();

                //get course info and insert to finalResultTable
                CoursesGateway coursesGateway = new CoursesGateway();
                Courses c = new Courses();
                c = coursesGateway.getOneCourseInfoByCoursesCode(s.Name);// here s.Name hold course code

                string insertString1 = "INSERT INTO finalResultTable(studentID, course_code , course_title, credit_hour) VALUES('" + s.ID + "', '" + s.Name + "', '"+c.Title+"', '"+c.CreditHour.ToString()+ "') ";
                SqlCommand command1 = new SqlCommand(insertString1, connection);
                command1.ExecuteNonQuery();

                MessageShow("Course added successfully." + "\n Add all of courses in this Semester. \n(One by One).","Add all courses.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageShow("Course didn't added.","Error");
            }
            finally
            {
                connection.Close();
            }
        }

        public List<CoursesTakenByStudents> getAllStudentsInformation(CoursesTakenByStudents cs)
        {
            List<CoursesTakenByStudents> students = null;
            try
            {
                connection.Open();

                string queryString = "SELECT * FROM coursesTakenByStudentsTable WHERE course_code = '" + cs.LetterGrade+ "' ORDER BY studentID ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                students = new List<CoursesTakenByStudents>();
                while (dataReader.Read())
                {
                    CoursesTakenByStudents Student = new CoursesTakenByStudents();
                    Student.StudentId = Convert.ToInt32(dataReader["studentID"]);

                    string finalMarks = dataReader["final_exam_or_lab"].ToString();
                    string ClasstestsMarks = dataReader["class_test_or_quiz"].ToString();
                    string AttendenceMarks = dataReader["attandence"].ToString();
                    string TotalMarks = dataReader["total"].ToString();
                    if (finalMarks != "" && ClasstestsMarks != "" && AttendenceMarks != "" && TotalMarks != "")
                    {
                        Student.FinalMarks = Convert.ToDouble(dataReader["final_exam_or_lab"]);
                        Student.ClasstestsMarks = Convert.ToDouble(dataReader["class_test_or_quiz"]);
                        Student.AttendenceMarks = Convert.ToDouble(dataReader["attandence"]);
                        Student.TotalMarks = Convert.ToDouble(dataReader["total"]);
                    }
                    else
                    {
                        Student.FinalMarks =0;
                        Student.ClasstestsMarks = 0;
                        Student.AttendenceMarks = 0;
                        Student.TotalMarks = 0;
                    }
                    Student.LetterGrade = dataReader["letter_grade"].ToString();
                    Student.GradePoint = dataReader["grade_point"].ToString();
                    students.Add(Student);
                }

            }
            catch
            {
                MessageShow("Student not found.","Error!");
            }
            finally
            {
                connection.Close();
            }

            return students;
        }
        public List<CoursesTakenByStudents> getOneStudentInfoById(CoursesTakenByStudents cs)
        {
            CoursesTakenByStudents CST = null;
            List<CoursesTakenByStudents> CSTList = new List<CoursesTakenByStudents>();
            try
            {
                connection.Open();

                string queryString = "SELECT  * FROM coursesTakenByStudentsTable WHERE course_code = '" + cs.LetterGrade + "' AND studentID = '" + cs.StudentId + "' ";
                //here LetterGrade = CourseCode
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    CST = new CoursesTakenByStudents();
                    CST.StudentId = cs.StudentId;
                    string finalMarks = dataReader["final_exam_or_lab"].ToString(); MessageBox.Show(finalMarks);
                    string ClasstestsMarks = dataReader["class_test_or_quiz"].ToString();
                    string AttendenceMarks = dataReader["attandence"].ToString();
                    string TotalMarks = dataReader["total"].ToString();
                    if (finalMarks != "" && ClasstestsMarks != "" && AttendenceMarks != "" && TotalMarks != "")
                    {
                        CST.FinalMarks = Convert.ToDouble(dataReader["final_exam_or_lab"]);
                        CST.ClasstestsMarks = Convert.ToDouble(dataReader["class_test_or_quiz"]);
                        CST.AttendenceMarks = Convert.ToDouble(dataReader["attandence"]);
                        CST.TotalMarks = Convert.ToDouble(dataReader["total"]);
                    }
                    else
                    {
                        CST.FinalMarks = 0;
                        CST.ClasstestsMarks = 0;
                        CST.AttendenceMarks = 0;
                        CST.TotalMarks = 0;
                    }
                    CST.LetterGrade = dataReader["letter_grade"].ToString();
                    CST.GradePoint = dataReader["grade_point"].ToString();
                    CSTList.Add(CST);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                connection.Close();
            }
            return CSTList;
        }

        public string getLetterGrade(double marks)
        {
            if (marks > 300)
                return "Invalid"; ;
            if (marks <= 300 && marks > 100)
                marks /= 3;
            if (marks <= 100 && marks >= 80)
                return "A Plus";
            else if (marks < 80 && marks >= 75)
                return "A Regular";
            else if (marks < 75 && marks >= 70)
                return "A Minus";
            else if (marks < 70 && marks >= 65)
                return "B Plus";
            else if (marks < 65 && marks >= 60)
                return "B Regular";
            else if (marks < 60 && marks >= 55)
                return "B Minus";
            else if (marks < 55 && marks >= 50)
                return "C+";
            else if (marks < 50 && marks >= 45)
                return "C Regular";
            else if (marks < 45 && marks >= 40)
                return "D";
            else
                return "F";

        }
        public string getGradePoint(string letterGrade)
        {
            if (letterGrade == "A Plus")
                return "4.00";
            else if (letterGrade == "A Regular")
                return "3.75";
            else if (letterGrade == "A Minus")
                return "3.50";
            else if (letterGrade == "B Plus")
                return "3.25";
            else if (letterGrade == "B Regular")
                return "3.00";
            else if (letterGrade == "B Minus")
                return "2.75";
            else if (letterGrade == "C Plus")
                return "2.50";
            else if (letterGrade == "C Regular")
                return "2.25";
            else if (letterGrade == "D")
                return "2.00";
            else
                return "0.00";

        }
        public void updateStudentRecord(CoursesTakenByStudents cts, string CourseCode)
        {
            try
            {
                connection.Open();
                // Update coursesTakenByStudentsTable Also finalResultTable
                string updateString = " UPDATE coursesTakenByStudentsTable SET final_exam_or_lab = '" + cts.FinalMarks + "', class_test_or_quiz = '" + cts.ClasstestsMarks + "', attandence = '" + cts.AttendenceMarks + "', total = '" + cts.TotalMarks + "', letter_grade = '" + cts.LetterGrade + "', grade_point = '" + cts.GradePoint + "' WHERE course_code = '" + CourseCode + "'  AND studentID = '" + cts.StudentId + "'; ";
                SqlCommand command = new SqlCommand(updateString, connection);
                command.ExecuteNonQuery();

                string updateString1 = " UPDATE finalResultTable SET  letter_grade = '" + cts.LetterGrade + "', grade_point = '" + cts.GradePoint + "' WHERE course_code = '" + CourseCode + "'  AND studentID = '" + cts.StudentId + "'; ";
                SqlCommand command1 = new SqlCommand(updateString1, connection);
                command1.ExecuteNonQuery();
            }
            catch
            {
                MessageShow("Error occured while updating Data","Error!");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
