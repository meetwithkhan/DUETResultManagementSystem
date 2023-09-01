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
    public partial class StudentForm : Form
    {
        Users user = loginForm.PassToAnother;// copy user information from Login page
        string[] Years = { "--Select--", "1st", "2nd", "3rd", "4th" };
        string[] Semesters = { "--Select--", "1st", "2nd" };
        string[] Sessions = { "--Select--", "2017-18", "2018-19" };

        public StudentForm()
        {
            InitializeComponent();
            menuBarNavpanel.Top = homeButton.Top;
            locationStatusForUserLabel.Text = "Welcome! to your Dashboard.";
            HideAllPanels();
            studentDashboardPanel.Visible = true;
            displayNameLabel.Text = user.FullName;
            studentDashboardPanel.Width = 1152;
        }
       
        //****************Extra function**************************
        public void HideAllPanels()
        {
            studentDashboardPanel.Visible = false;
            userSettingPanel.Visible = false;
            userPersonalInfoUpdatePanel.Visible = false;
            userPasswordSettingPanel.Visible = false;
            viewResultPanel.Visible = false;
            coursePanel.Visible = false;
        }
        public void MessageShow(string Message, string text)// to display customize message Box
        {
            messageForm.MessageString = Message;
            messageForm mf = new messageForm();
            mf.Text = text;
            mf.ShowDialog();
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageShow("You must Log Out first.");
        }
        //****************  End of Extra function**************************//

        ////**************** StudentForm Menu Buttons *********************//
        private void homeButton_Click(object sender, EventArgs e)
        {
            menuBarNavpanel.Top = homeButton.Top;
            locationStatusForUserLabel.Text = "Welcome!! to your Dashboard.";
            HideAllPanels();
            studentDashboardPanel.Visible = true;
        }
        private void coursesButton_Click(object sender, EventArgs e)
        {
            menuBarNavpanel.Top = coursesButton.Top;
            locationStatusForUserLabel.Text = "Manage your courses in this Semester";
            HideAllPanels();
            coursePanel_Load();
            coursePanel.Visible = true;
            coursePanel.Width = 1152;
        }
        private void settingButton_Click(object sender, EventArgs e)
        {
            menuBarNavpanel.Top = settingButton.Top;
            locationStatusForUserLabel.Text = "Set up your account.";
            HideAllPanels();
            userSettingPanel.Width = 1152;
            userSettingPanel.Visible = true;
            userPersonalInfoUpdatePanel.Visible = false;
            userPasswordSettingPanel.Visible = false;
        }
        private void viewResultButton_Click(object sender, EventArgs e)
        {
            menuBarNavpanel.Top = viewResultButton.Top;
            locationStatusForUserLabel.Text = "Result form ";
            HideAllPanels();
            viewResultPanel.Visible = true;
            viewResultPanel.Width = 1152;
            viewResultPanelLoad();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                loginForm lf = new loginForm();
                this.Close();
                lf.Show();
            }
        }

        ////**************** End of StudentForm Menu Buttons *********************//
        ///***************** Course Panel*****************************************//
        private void coursePanel_Load()
        {
            departmentNameComboBox.Text = user.Department;
            departmentNameComboBox.Enabled = false;
            YearComboBox.DataSource = Years;
            addCoursePanel.Visible = false;
            viewCoursesPanel.Visible = false;
            
        }
        private void addNewCourseButton_Click(object sender, EventArgs e)
        {
            addCoursePanel.Visible = true;
            addCoursePanel.Width = 1152;
        }

        private void courseAddButton_Click(object sender, EventArgs e)
        {
            if (YearComboBox.Text != "--Select--" && semesterComboBox.Text != "" && sessionComboBox.Text != "" && courseNoComboBox.Text != "")
            {
                CoursesTakenByStudentsGateway coursesTakenByStudentsGateway = new CoursesTakenByStudentsGateway();
                Students s = new Students();
                s.ID = Convert.ToInt32(user.UserName);
                s.Name = courseNoComboBox.Text;
                //here s.Name hold course code for passing course code to 'coursesTakenByStudentsGateway'
                coursesTakenByStudentsGateway.addCourseToTable(s);
            }
            else
                MessageShow("Fill all field correctly.","Fill Error!");
        }
        private void viewCoursesPanelBackButton_Click(object sender, EventArgs e)
        {
            viewCoursesPanel.Visible = false;
        }
        private void viewCoursesButton_Click(object sender, EventArgs e)
        {
            viewCoursesPanel.Visible = true;
            viewCoursesPanel.Width = 1152;
            locationStatusForUserLabel.Text = "You select these courses in this semester.";
            FinalResultsGateway finalResultsGateway = new FinalResultsGateway();
            List<FinalResult> courses = new List<FinalResult>();

            courses = finalResultsGateway.getAllTakenCoursesInfo(Convert.ToInt32(user.UserName)); // Get Students Information
            coursesDataGridView.DataSource = courses;

            /// code to deesiign DataGridView
            coursesDataGridView.BorderStyle = BorderStyle.FixedSingle;
            coursesDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            coursesDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            coursesDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            coursesDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            coursesDataGridView.BackgroundColor = Color.White;

            coursesDataGridView.EnableHeadersVisualStyles = false;
            coursesDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            coursesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            coursesDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ///End of code to desiign DataGridView
        }
        //Code for Auto fill Combo box
        private void departmentNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearComboBox.Text = "";
            semesterComboBox.Text = "";
            sessionComboBox.Text = "";
            courseNoComboBox.Text = "";
            courseTitleComboBox.Text = "";
            if (departmentNameComboBox.Text == "Civil Engineering" || departmentNameComboBox.Text == "Electrical & Electronic Engineering" || departmentNameComboBox.Text == "Mechanical Engineering" || departmentNameComboBox.Text == "Computer Science and Engineering" || departmentNameComboBox.Text == "Textile Engineering" || departmentNameComboBox.Text == "Architecture" || departmentNameComboBox.Text == "Industrial & Production Engineering" || departmentNameComboBox.Text == "Chemical & Food Engineering")
                YearComboBox.DataSource = Years;
        }
        private void addNewCourseBackButton_Click(object sender, EventArgs e)
        {
            addCoursePanel.Visible = false;
        }
        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            semesterComboBox.Text = "";
            sessionComboBox.Text = "";
            courseNoComboBox.Text = "";
            courseTitleComboBox.Text = "";
            if (YearComboBox.Text == "1st" || YearComboBox.Text == "2nd" || YearComboBox.Text == "3rd" || YearComboBox.Text == "4th")
                semesterComboBox.DataSource = Semesters;
        }
        private void semesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sessionComboBox.Text = "";
            courseNoComboBox.Text = "";
            courseTitleComboBox.Text = "";
            if (semesterComboBox.Text == "1st" || semesterComboBox.Text == "2nd")
                sessionComboBox.DataSource = Sessions;
        }
        private void sessionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepartmentGateway departmentGateway = new DepartmentGateway();
            CoursesGateway coursesGateway = new CoursesGateway();
            courseNoComboBox.Text = "";
            courseTitleComboBox.Text = "";
            if (sessionComboBox.Text == "2017-18" || sessionComboBox.Text == "2018-19")
            {
                Courses course = new Courses();
                course.Year = YearComboBox.Text;
                course.Semester = semesterComboBox.Text;
                course.DepartmentId = Convert.ToInt32(departmentGateway.getDeoartmentIDByDepartmentName(departmentNameComboBox.Text));
                DataSet dataSet = coursesGateway.getCoursesCode(course);
                courseNoComboBox.DisplayMember = "course_code";
                courseNoComboBox.ValueMember = "course_code";
                courseNoComboBox.DataSource = dataSet.Tables[0];
            }
        }
        private void courseNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoursesGateway coursesGateway = new CoursesGateway();
            string C_Title = coursesGateway.getOneCourseTitleByCoursesCode(courseNoComboBox.Text);
            courseTitleComboBox.Text = C_Title;
        }
        ///*****************End of Course Panel*****************************************//
        ///********************** ViewResult Panel*************************/
        private void viewResultPanelLoad()
        {
            DepartmentGateway departmentGateway = new DepartmentGateway();
            StudentsGateway studentsGateway = new StudentsGateway();
            Students s = new Students();
            s.ID =Convert.ToInt32(user.UserName);
            s = studentsGateway.getOneStudentInformation(s);
            viewResultStudentIdTextBox.Text = s.ID.ToString();
            viewResultStudentDepartmentComboBox.Text = s.Department;
            viewResultStudentYearComboBox.Text = s.Year;
            viewResultStudentSemesterComboBox.Text = s.Semester;
            viewResultStudentSessionComboBox.Text = s.Session;


            viewResultStudentIdTextBox.Enabled = false;
            viewResultStudentDepartmentComboBox.Enabled = false;
            viewResultStudentYearComboBox.Enabled = false;
            viewResultStudentSemesterComboBox.Enabled = false;
            viewResultStudentSessionComboBox.Enabled = false;
        }
        private void viewStudentResultButton_Click(object sender, EventArgs e)
        {
            StudentsGateway studentsGateway = new StudentsGateway();
            Students student = new Students();
            Students passStudent = new Students();
            if (viewResultStudentIdTextBox.Text != "")
            {
                student.ID = Convert.ToInt32(viewResultStudentIdTextBox.Text);
                //now set FinalResultForm Attribute 
                passStudent = studentsGateway.getOneStudentInformation(student);
                FinalResultForm.Student = passStudent;

                if (passStudent.Department == viewResultStudentDepartmentComboBox.Text)
                {
                    FinalResultForm NewFinalResultForm = new FinalResultForm();
                    NewFinalResultForm.Show();
                }
            }
            else
                viewResultStudentIdTextBox.Focus();
        }

        private void backButtonStudentRecord_Click_1(object sender, EventArgs e)
        {
            addCoursePanel.Visible = false;
        }
        ///********************** End of ViewResult Panel*************************/

        /////********************* User Setting panel****************************

        private void userInfoSetting_Click(object sender, EventArgs e)
        {
            userPersonalInfoUpdatePanel.Width = 1152;
            userPersonalInfoUpdatePanel.Visible = true;
            userFullNameTextBox.Text = user.FullName;
            userDepartmentComboBox.Text = user.Department;
            userAddressTextBox.Text = user.Address;
            userEmailTextBox.Text = user.Email;
            userphoneTextBox.Text = user.Phone;

        }
        private void userInfoSubmitButton_Click(object sender, EventArgs e)
        {
            UsersGateway userGateway = new UsersGateway();
            Users newUser = new Users();
            newUser.UserName = user.UserName;
            newUser.Phone = userphoneTextBox.Text;
            newUser.Email = userEmailTextBox.Text;
            newUser.Address = userAddressTextBox.Text;
            userGateway.UpDateUserInformation(newUser);
            MessageShow("Information Updated Successfully.","Successful.");
        }
        private void backButton_1_Click(object sender, EventArgs e)
        {
            userPersonalInfoUpdatePanel.Visible = false;
        }

        private void userPasswordSettingButton_Click(object sender, EventArgs e)
        {

            userPasswordSettingPanel.Width = 1152;
            userPersonalInfoUpdatePanel.Visible = true;
            userPasswordSettingPanel.Visible = true;
            oldPasswordWrongLabel.Visible = false;
            passwordNotMatchedLabel.Visible = false;
        }
        private void userPasswordSubmitButton_Click(object sender, EventArgs e)
        {
            if (userOldPassTextBox.Text == user.Password)
            {
                if (userNewPassTextBox.Text == userNewPassConfirmTextBox.Text)
                {
                    if (userNewPassTextBox.Text.Length > 5)
                    {
                        UsersGateway usersGateway = new UsersGateway();
                        user.Password = userNewPassTextBox.Text;

                        usersGateway.UpDatePassword(user);

                        MessageShow("Password Changed Successfully.","Successful.");

                        passwordNotMatchedLabel.Visible = false;
                        userOldPassTextBox.Clear();
                        userNewPassConfirmTextBox.Clear();
                        userNewPassTextBox.Clear();
                    }
                    else
                    {
                        MessageShow("Password should be more than 5 character.","Password Error!");
                    }
                }
                else
                {
                    passwordNotMatchedLabel.Visible = true;
                    oldPasswordWrongLabel.Visible = false;
                }
            }
            else
            {
                oldPasswordWrongLabel.Visible = true;
            }

        }
        private void backButton_Click(object sender, EventArgs e)///for PasswordSetting Panel 
        {
            userPasswordSettingPanel.Visible = false;
            userPersonalInfoUpdatePanel.Visible = false;
        }

        private void StudentForm_FormClosed(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("You must Log out First!");
        }

        ///****************** End of User setting Panel*************************/


    }
}
