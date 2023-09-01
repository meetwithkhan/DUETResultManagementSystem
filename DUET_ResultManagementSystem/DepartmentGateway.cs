using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DUET_ResultManagementSystem
{
    


    class DepartmentGateway
    {
        DBConnector connector = null;
        SqlConnection connection = null;
        DataSet dataset = null;

        public DepartmentGateway()
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

        public DataSet getDepartmentinfo()
        {
            try
            {
                connection.Open();
                string queryString = "SELECT department_name FROM departmentTable";
                SqlCommand command = new SqlCommand(queryString, connection);
                dataset = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(queryString, connection);
                
                da.Fill(dataset);
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageShow("Data read Error!","Error!");
            }
            finally
            {
                connection.Close();
            }
            return dataset; 
        }
        public string getDeoartmentNameByDepartmentCode(Department d)
        {
            string deptName = null;
            try
            {
                connection.Open();
                string queryString = "SELECT department_name FROM departmentTable WHERE department_ID = '"+ d.Department_ID +"'";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                deptName = dataReader["department_name"].ToString();
            }
            catch
            {
                MessageShow("Department not found.","Error!");
            }
            finally
            {
                connection.Close();
            }
            return deptName;
        }
        public string getDeoartmentIDByDepartmentName(string s)
        {
            string deptId = null;
            try
            {
                connection.Open();
                string queryString = "SELECT department_ID FROM departmentTable WHERE department_name = '" + s + "'";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                deptId = dataReader["department_ID"].ToString();
            }
            catch
            {
                MessageShow("Department not found.","Error!");
            }
            finally
            {
                connection.Close();
            }
            return deptId;
        }
    }
}
