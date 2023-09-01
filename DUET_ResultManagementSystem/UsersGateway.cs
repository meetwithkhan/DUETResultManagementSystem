using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUET_ResultManagementSystem
{
    class UsersGateway
    {
        

        DBConnector connector = null;
        SqlConnection connection = null;

        public void MessageShow(string Message, string text)// to display customize message Box
        {
            messageForm.MessageString = Message;
            messageForm mf = new messageForm();
            mf.Text = text;
            mf.ShowDialog();
        }
        public UsersGateway()
        {
            connector = new DBConnector();
            connection = connector.Connect;
        }

        public Users getLogInInfo(Users user)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM usersTable WHERE usertype = '" + user.UserType+"' AND username = '"+user.UserName+"'", connection);
                SqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                user.UserName = dataReader["username"].ToString();
                user.Password = dataReader["password"].ToString();
                
            }
            catch
            {
                //messageForm mf = new messageForm();
                //messageForm.MessageString = "Data read Error!";
                //mf.Show();
                //MessageShow("Data read Error!");
            }
            finally
            {
                connection.Close();
            }
            return user;
        }
        public Users GetUserInfo(Users user)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM usersTable WHERE usertype = '" + user.UserType + "' AND username = '" + user.UserName + "' ";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                user.UserName = dataReader["username"].ToString();
                user.Password = dataReader["password"].ToString();
                user.FullName = dataReader["fullname"].ToString();
                user.Phone = dataReader["phone"].ToString();
                user.Email = dataReader["email"].ToString();
                user.Department = dataReader["department"].ToString();
                user.Address = dataReader["address"].ToString();
                
            }
            catch
            {
                MessageShow("User Not found.","Error!");
            }
            finally
            {
                connection.Close();
            }
            return user;
        }

        public void addUser(Users u)
        {
            try
            {
                connection.Open();
                string insertString = "INSERT INTO usersTable VALUES ('" +u.UserName+ "', '" + u.Password + "', '" + u.UserType + "', '"+ u.FullName +"', '"+ u.Phone +"', '"+ u.Department +"', '"+ u.Address +"', '"+ u.Email +"')";
                SqlCommand command = new SqlCommand(insertString, connection);
                command.ExecuteNonQuery();
                MessageShow("User added Successfully.","Successful.");
            }
            catch
            {
                MessageShow("User didn't added", "Error!");
            }
            finally
            {
                connection.Close();
            }
            
        }

        public void UpDateUserInformation(Users user)
        {
            
            try
            {
                connection.Open();
                string updateString = "UPDATE usersTable SET phone = '" + user.Phone + "', address = '" + user.Address + "', email = '" + user.Email + "' WHERE username = '"+user.UserName+"'";
                SqlCommand command = new SqlCommand(updateString, connection);
                command.ExecuteNonQuery();
                
            }
            catch
            {
                //messageForm mf = new messageForm();
                //messageForm.MessageString = "Data write Error!";
                //mf.Show();
                MessageShow("Error occur while updating user info.","Error!");
            }
            finally
            {
                connection.Close();
            }
        }
        public void UpDatePassword(Users user)
        {
            try
            {
                connection.Open();
                string updateString = "UPDATE usersTable SET password = '" + user.Password + "' WHERE username = '" + user.UserName + "'";
                SqlCommand command = new SqlCommand(updateString, connection);
                command.ExecuteNonQuery();

            }
            catch
            {
                //messageForm mf = new messageForm();
                //messageForm.MessageString = "Data write Error!";
                //mf.Show();
                MessageShow("Error occur while updating user password.", "Error!");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
