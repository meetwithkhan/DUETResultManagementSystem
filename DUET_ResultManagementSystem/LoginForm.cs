using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUET_ResultManagementSystem
{
    public partial class loginForm : Form
    {
        UsersGateway uGateway = new UsersGateway();
        Users validUser = null;
        Users u = new Users();
        private static Users passToAnother = null;

        public void MessageShow(string Message, string text)// to display customize message Box
        {
            messageForm.MessageString = Message;
            messageForm mf = new messageForm();
            mf.Text = text;
            mf.ShowDialog();
        }

        internal static Users PassToAnother { get => passToAnother; set => passToAnother = value; }

        enum UsersType
        {
            Admin,
            Student
        } 

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            loginFailStatusLabel.Visible = false;
            loginFormPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        //*******************User Interface Related****************************
        private void userNameTextBox_Enter(object sender, EventArgs e)
        {
            if(userNameTextBox.Text == "Username")
            {
                userNameTextBox.Text = "";
            }
        }

        private void userNameTextBox_Leave(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                userNameTextBox.Text = "Username";
            }
        }
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "password")
            {
                passwordTextBox.Text = "";
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "password";
            }
        }
        private void userTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            userNameTextBox.Focus();
        }
        private void userNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                userNameTextBox.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    passwordTextBox.Focus();
                }
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Focus();
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                    loginButton.PerformClick();
            }
        }
        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
        //**********************************End of UI Design*********************************


        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userTypeComboBox.Text == "Admin" || userTypeComboBox.Text == "Student")
            {
                if (checkLoginInfo())
                {
                    if (u.UserType == UsersType.Admin.ToString())
                    {
                        this.Hide();
                        AdminForm newAdminForm = new AdminForm();
                        newAdminForm.Show();
                    }
                    else
                    {
                        this.Hide();
                        StudentForm newStudentForm = new StudentForm();
                        newStudentForm.Show();
                    }
                }
                else
                {
                    loginFailStatusLabel.Visible = true;
                    MessageShow("Check your Username & password again.", "Wrong passwoord!");
                }
            }
            else
                MessageShow("Select Valid User type.","Login Error!");
        }

        public bool checkLoginInfo()
        {     
            u.UserType = userTypeComboBox.Text;
            u.UserName = userNameTextBox.Text;
            
            validUser = uGateway.getLogInInfo(u);
            PassToAnother = uGateway.GetUserInfo(validUser);
            return (userNameTextBox.Text == validUser.UserName && passwordTextBox.Text == validUser.Password) ? true : false;
        }

        
    }
}
