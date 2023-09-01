using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUET_ResultManagementSystem
{
    class FinalResultsGateway
    {
        DBConnector connector = null;
        SqlConnection connection = null;

        public FinalResultsGateway()
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

        public List<FinalResult> getResultsInfoById(int Id)
        {
            List<FinalResult> finalResults = new List<FinalResult>();
            try
            {
                connection.Open();
                string queryString = "SELECT  * FROM finalResultTable WHERE studentID = '" + Id + "' ORDER BY course_code  ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                FinalResult FR = null;
                while (dataReader.Read())
                {
                    FR = new FinalResult();
                    FR.CourseNo = dataReader["course_code"].ToString();
                    FR.CourseTitle = dataReader["course_title"].ToString();
                    FR.CreditHour = dataReader["credit_hour"].ToString();
                    FR.LetterGrade = dataReader["letter_grade"].ToString();
                    FR.GradePoint = dataReader["grade_point"].ToString();

                    finalResults.Add(FR);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                connection.Close();
            }
            return finalResults;
        }
        public double getSummationOfCreditAndGradePoint(int Id)
        {
            double totlaCredit = 0.00;
            
            try
            {
                connection.Open();
                string queryString = "SELECT  credit_hour, grade_point FROM finalResultTable WHERE studentID = '" + Id + "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                FinalResult FR = null;
                
                while (dataReader.Read())
                {
                    FR = new FinalResult();
                    FR.GradePoint = dataReader["grade_point"].ToString();
                    FR.CreditHour = dataReader["credit_hour"].ToString();
                    if(FR.GradePoint != "" && FR.CreditHour !="")
                        totlaCredit += (Convert.ToDouble(FR.GradePoint) * Convert.ToDouble(FR.CreditHour));
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
            return totlaCredit;
        }
        public double getTotlaCreditTaken(int Id)
        {
            double totlaCredit = 0.00;

            try
            {
                connection.Open();
                string queryString = "SELECT  credit_hour FROM finalResultTable WHERE studentID = '" + Id + "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                FinalResult FR = null;

                while (dataReader.Read())
                {
                    FR = new FinalResult();
                    FR.CreditHour = dataReader["credit_hour"].ToString();
                    totlaCredit += Convert.ToDouble(FR.CreditHour);
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
            return totlaCredit;
        }
        public double getCreditEarned(int Id)
        {
            double CreditEarned = 0;

            try
            {
                connection.Open();
                string queryString = "SELECT  credit_hour, grade_point FROM finalResultTable WHERE studentID = '" + Id + "' ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                FinalResult FR = null;

                while (dataReader.Read())
                {
                    FR = new FinalResult();
                    FR.GradePoint = dataReader["grade_point"].ToString();
                    FR.CreditHour = dataReader["credit_hour"].ToString();
                    if(FR.GradePoint != "0.00")
                        CreditEarned += Convert.ToDouble(FR.CreditHour);
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
            return CreditEarned;
        }

        public List<FinalResult> getAllTakenCoursesInfo(int s)
        {

            List<FinalResult> finalResults = new List<FinalResult>();
            try
            {
                connection.Open();
                string queryString = "SELECT  * FROM finalResultTable WHERE studentID = '" + s + "' ORDER BY course_code  ";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                FinalResult FR = null;
                while (dataReader.Read())
                {
                    FR = new FinalResult();
                    FR.CourseNo = dataReader["course_code"].ToString();
                    FR.CourseTitle = dataReader["course_title"].ToString();
                    FR.CreditHour = dataReader["credit_hour"].ToString();

                    finalResults.Add(FR);
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
            return finalResults;
        }
    }
}
