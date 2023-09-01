using DGVPrinterHelper;
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
    public partial class AdminForm : Form
    {
        Users user = loginForm.PassToAnother;// copy user information from Login page
        string[] Years = { "--Select--", "1st", "2nd", "3rd", "4th" };
        string[] Semesters = { "--Select--", "1st", "2nd" };
        string[] Sessions = { "--Select--", "2017-18", "2018-19" };

        public AdminForm()
        {
            InitializeComponent();
            menuBarNavpanel.Top = homeButton.Top;
            locationStatusForUserLabel.Text = "Welcome! to your Dashboard.";
            HideAllPanels();
            adminDashboardPanel.Visible = true;
            displayNameLabel.Text = user.FullName;
            adminDashboardPanel.Width = 1152;
        }
        //****************Extra function**************************
        public void HideAllPanels()
        {
            adminDashboardPanel.Visible = false;
            marksPanel.Visible = false;
            userSettingPanel.Visible = false;
            userControlsPanel.Visible = false;
            studentPanel.Visible = false;
            viewResultPanel.Visible = false;
        }
        public void MessageShow(string Message, string text)// to display customize message Box
        {
            messageForm.MessageString = Message;
            messageForm mf = new messageForm();
            mf.Text = text;
            mf.ShowDialog();
        }


        
        //****************  End of Extra function**************************//

        ////**************** AdminForm Menu Buttons *********************//

        private void homeButton_Click(object sender, EventArgs e)
        {
            menuBarNavpanel.Top = homeButton.Top;
            locationStatusForUserLabel.Text = "Welcome! to your Dashboard.";
            HideAllPanels();
            adminDashboardPanel.Visible = true;
        }
        private void userControlsButton_Click(object sender, EventArgs e)
        {
            menuBarNavpanel.Top = userControlsButton.Top;
            locationStatusForUserLabel.Text = "Manage users";
            HideAllPanels();
            userControlsPanel.Visible = true;
            addNewUserPanel.Visible = false;
            userControlsPanel.Width = 1152;
        }
        private void studentButton_Click(object sender, EventArgs e)
        {
            menuBarNavpanel.Top = studentButton.Top;
            locationStatusForUserLabel.Text = "Manage Students";
            HideAllPanels();
            studentPanel.Visible = true;
            studentPanel.Width = 1152;
            addNewStudentPanel.Visible = false;
            viewStudentInfoPanel.Visible = false;
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
        private void marksButton_Click(object sender, EventArgs e)
        {
            menuBarNavpanel.Top = marksButton.Top;
            locationStatusForUserLabel.Text = "Mark management ";
            HideAllPanels();
            marksPanel.Visible = true;
            markDistributionPanel.Visible = false;
            marksPanel.Width = 1152;
            adminMarks_Load();

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
        ////**************** End of AdminForm Menu Buttons *********************//


        ///**********************  Marks Panel*****************************//
        private void adminMarks_Load()
        {
            DepartmentGateway departmentGateway = new DepartmentGateway();
            DataSet dataset = departmentGateway.getDepartmentinfo();
            departmentNameComboBox.DisplayMember = "department_name";
            departmentNameComboBox.ValueMember = "department_name";
            departmentNameComboBox.DataSource = dataset.Tables[0];
            departmentNameComboBox.Text = "--Select--";
        }

        private void adminMarksFormSubmitButton_Click(object sender, EventArgs e)
        {
            if (departmentNameComboBox.Text != "--Select--" && YearComboBox.Text != "" && semesterComboBox.Text != "" && sessionComboBox.Text != "" && courseNoComboBox.Text != "")
            {
                marksPanel.Visible = true;
                markDistributionPanel.Visible = true;
                markDistributionPanel.Width = 1152;
                StudentRecord_Load();
            }
            else
                MessageShow("Fill all field correctly.","Error!");
        }
        private void StudentRecord_Load()
        {
            CoursesGateway coursesGateway = new CoursesGateway();
            CoursesTakenByStudents cs = new CoursesTakenByStudents();
            cs.LetterGrade = courseNoComboBox.Text;//here LetterGrade = CourseCode for Gateway class

            // Get course type to view different Marks distribution Panel
            string CourseType = coursesGateway.getCourseTypeByCoursesCode(courseNoComboBox.Text);

            CoursesTakenByStudentsGateway coursesTakenByStudentsGateway = new CoursesTakenByStudentsGateway();
            List<CoursesTakenByStudents> students = new List<CoursesTakenByStudents>();
            //Change Column Header with the type of Course
            if (CourseType == "Sessional")
            {
                studentsRecordTheoryDataGridView.Columns["finalExamMark"].HeaderText = "Lab Final";
                studentsRecordTheoryDataGridView.Columns["CTMarks"].HeaderText = "Quiz";
                studentsRecordTheoryDataGridView.Columns["attendenceMarks"].HeaderText = "Class Assessment";
            }
            else
            {
                studentsRecordTheoryDataGridView.Columns["finalExamMark"].HeaderText = "Final Exam";
                studentsRecordTheoryDataGridView.Columns["CTMarks"].HeaderText = "Class Test";
                studentsRecordTheoryDataGridView.Columns["attendenceMarks"].HeaderText = "Attendance";

            }
            //end of Change Column Header with the type of Course

            students = coursesTakenByStudentsGateway.getAllStudentsInformation(cs); // Get Students Information
            studentsRecordTheoryDataGridView.DataSource = students;// set DatagridView's data

            /// code to deesiign DataGridView
            studentsRecordTheoryDataGridView.BorderStyle = BorderStyle.FixedSingle;
            studentsRecordTheoryDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            studentsRecordTheoryDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            studentsRecordTheoryDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            studentsRecordTheoryDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            studentsRecordTheoryDataGridView.BackgroundColor = Color.White;

            studentsRecordTheoryDataGridView.EnableHeadersVisualStyles = false;
            studentsRecordTheoryDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            studentsRecordTheoryDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            studentsRecordTheoryDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ///End of code to deesiign DataGridView
        }
        //private void studentRecordSearchButton_Click(object sender, EventArgs e)
        //{
        //    CoursesTakenByStudents CTS = new CoursesTakenByStudents();
        //    if (studentRecordSearchTextBox.Text != "")
        //    {
        //        CTS.StudentId = Convert.ToInt32(studentRecordSearchTextBox.Text);

        //        CTS.LetterGrade = courseNoComboBox.Text;
        //        //here LetterGrade = CourseCode for Gateway class
        //        CoursesTakenByStudentsGateway coursesTakenByStudentsGateway = new CoursesTakenByStudentsGateway();
        //        List<CoursesTakenByStudents> CSTList = coursesTakenByStudentsGateway.getOneStudentInfoById(CTS);
        //        studentsRecordTheoryDataGridView.DataSource = CSTList;

        //    }
        //}

        private void marksDistributionPreviewButton_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Mark distribution for " + courseNoComboBox.Text;
            printer.SubTitle = "";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Designed and Developed by AMR_CSEian.";
            printer.FooterSpacing = 15;
            printer.PageSettings.Landscape = true;
            printer.PrintDataGridView(studentsRecordTheoryDataGridView);
        }
        private void studentsRecordTheoryDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CoursesTakenByStudentsGateway CST = new CoursesTakenByStudentsGateway();
            studentsRecordTheoryDataGridView.CurrentRow.Cells[4].Value = Convert.ToDouble(studentsRecordTheoryDataGridView.CurrentRow.Cells[3].Value) + Convert.ToDouble(studentsRecordTheoryDataGridView.CurrentRow.Cells[2].Value) + Convert.ToDouble(studentsRecordTheoryDataGridView.CurrentRow.Cells[1].Value);
            studentsRecordTheoryDataGridView.CurrentRow.Cells[5].Value = CST.getLetterGrade(Convert.ToDouble(studentsRecordTheoryDataGridView.CurrentRow.Cells[4].Value));
            studentsRecordTheoryDataGridView.CurrentRow.Cells[6].Value = CST.getGradePoint(studentsRecordTheoryDataGridView.CurrentRow.Cells[5].Value.ToString());
        }
        private void studentRecordSaveButton_Click(object sender, EventArgs e)
        {
            CoursesTakenByStudentsGateway CTS = new CoursesTakenByStudentsGateway();
            CoursesTakenByStudents CT = null;
            for (int i = 0; i <= studentsRecordTheoryDataGridView.Rows.Count - 1; i++)
            {
                CT = new CoursesTakenByStudents();
                string CourseNo = courseNoComboBox.Text;
                CT.StudentId = Convert.ToInt32(studentsRecordTheoryDataGridView.Rows[i].Cells[0].Value);
                CT.FinalMarks = Convert.ToDouble(studentsRecordTheoryDataGridView.Rows[i].Cells[1].Value);
                CT.ClasstestsMarks = Convert.ToDouble(studentsRecordTheoryDataGridView.Rows[i].Cells[2].Value);
                CT.AttendenceMarks = Convert.ToDouble(studentsRecordTheoryDataGridView.Rows[i].Cells[3].Value);
                CT.TotalMarks = Convert.ToDouble(studentsRecordTheoryDataGridView.Rows[i].Cells[4].Value);
                CT.LetterGrade = studentsRecordTheoryDataGridView.Rows[i].Cells[5].Value.ToString();
                CT.GradePoint = studentsRecordTheoryDataGridView.Rows[i].Cells[6].Value.ToString();

                CTS.updateStudentRecord(CT, CourseNo);
            }
            MessageShow("Information updated successfully.","Successful");
        }
        private void studentRecordRefreshButton_Click(object sender, EventArgs e)
        {

            CoursesGateway coursesGateway = new CoursesGateway();
            CoursesTakenByStudents cs = new CoursesTakenByStudents();
            cs.LetterGrade = courseNoComboBox.Text;//here LetterGrade = CourseCode for Gateway class

            // Get course type to view different Marks distribution Panel
            string CourseType = coursesGateway.getCourseTypeByCoursesCode(courseNoComboBox.Text);

            CoursesTakenByStudentsGateway coursesTakenByStudentsGateway = new CoursesTakenByStudentsGateway();
            List<CoursesTakenByStudents> students = new List<CoursesTakenByStudents>();
            //Change Column Header with the type of Course
            if (CourseType == "Sessional")
            {
                studentsRecordTheoryDataGridView.Columns["finalExamMark"].HeaderText = "Lab Final";
                studentsRecordTheoryDataGridView.Columns["CTMarks"].HeaderText = "Quiz";
                studentsRecordTheoryDataGridView.Columns["attendenceMarks"].HeaderText = "Class Assessment";
            }
            else
            {
                studentsRecordTheoryDataGridView.Columns["finalExamMark"].HeaderText = "Final Exam";
                studentsRecordTheoryDataGridView.Columns["CTMarks"].HeaderText = "Class Test";
                studentsRecordTheoryDataGridView.Columns["attendenceMarks"].HeaderText = "Attendance";

            }
            //end of Change Column Header with the type of Course

            students = coursesTakenByStudentsGateway.getAllStudentsInformation(cs); // Get Students Information
            studentsRecordTheoryDataGridView.DataSource = students;
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
        //end of code for Auto fill Combo box
        private void backButtonStudentRecord_Click(object sender, EventArgs e)
        {
            markDistributionPanel.Visible = false;
            departmentNameComboBox.Text = "--Select--";
            YearComboBox.Text = "";
            semesterComboBox.Text = "";
            sessionComboBox.Text = "";
            courseNoComboBox.Text = "";
            courseTitleComboBox.Text = "";
        }
        ///********************** End of Marks Panel*****************************//
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
            MessageShow("Information Updated Successfully.", "Successful");
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

                        MessageShow("Password Changed Successfully.","Successful");

                        passwordNotMatchedLabel.Visible = false;
                        userOldPassTextBox.Clear();
                        userNewPassConfirmTextBox.Clear();
                        userNewPassTextBox.Clear();
                    }
                    else
                    {
                        MessageShow("Password should be more than 5 character.","Password erroro!");
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
        ///****************** End of User setting Panel*************************/

        ///********************** User Managment Panel*************************/
        private void addUserButton_Click(object sender, EventArgs e)
        {
            addNewUserPanel.Visible = true;
            addNewUserPanel.Width = 1152;
        }
        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            UsersGateway usersGateway = new UsersGateway();
            Users newUser = new Users();
            user.UserName = AddUser_usernameTextBox.Text;
            user.Password = AddUser_passwordTextBox.Text;
            user.UserType = AddUser_UserTypeComboBox.Text;
            user.Department = AddUser_departmentComboBox.Text;
            user.FullName = AddUser_fullnameTextBox.Text;
            usersGateway.addUser(user);
            // Reset all fields
            AddUser_usernameTextBox.ResetText();
            AddUser_passwordTextBox.ResetText();
            AddUser_UserTypeComboBox.ResetText();
            AddUser_departmentComboBox.ResetText();
            AddUser_fullnameTextBox.ResetText();
        }
        private void backButtonAddNewUser_Click(object sender, EventArgs e)
        {
            addNewUserPanel.Width = 0;
        }
        //////****************** End of User setting Panel*************************/

        ///********************** Students Panel*************************/
        private void addNewStudentButton_Click(object sender, EventArgs e)
        {
            addNewStudentPanel.Visible = true;
            addNewStudentPanel.Width = 1152;
            viewStudentPanel.Visible = false;
            DepartmentGateway departmentGateway = new DepartmentGateway();
            DataSet dataset = departmentGateway.getDepartmentinfo();
            //Set Department comboBox from DataBase
            newStudentDepartmentComboBox.DisplayMember = "department_name";
            newStudentDepartmentComboBox.ValueMember = "department_name";
            newStudentDepartmentComboBox.DataSource = dataset.Tables[0];
            //Set all fields empty
            newStudentDepartmentComboBox.Text = "--Select--";
            newStudentIdTextBox.ResetText();
            newStudentNameTextBox.ResetText();
            newStudentYearComboBox.ResetText();
            newStudentSemesterComboBox.ResetText();
            newStudentSessionComboBox.ResetText();
        }
        private void studentAddButton_Click(object sender, EventArgs e)
        {
            if (newStudentIdTextBox.Text != "" && newStudentNameTextBox.Text != "" && newStudentDepartmentComboBox.Text != "" && newStudentYearComboBox.Text != "" && newStudentSemesterComboBox.Text != "" && newStudentSessionComboBox.Text != "")
            {
                StudentsGateway studentsGateway = new StudentsGateway();
                Students student = new Students();

                student.ID = Convert.ToInt32(newStudentIdTextBox.Text);
                student.Name = newStudentNameTextBox.Text;
                student.Department = newStudentDepartmentComboBox.Text;
                student.Year = newStudentYearComboBox.Text;
                student.Semester = newStudentSemesterComboBox.Text;
                student.Session = newStudentSessionComboBox.Text;

                studentsGateway.addNewStudent(student);  // add new student
                /// add student as user with default password
                UsersGateway usersGateway = new UsersGateway();
                Users userStudent = new Users();
                userStudent.UserName = newStudentIdTextBox.Text;
                userStudent.Password = "123456";
                userStudent.UserType = "Student";
                userStudent.FullName = student.Name;
                userStudent.Phone = "";
                userStudent.Department = student.Department;
                userStudent.Address = "";
                userStudent.Email = "";

                usersGateway.addUser(userStudent);  // Add Student Type User

                MessageShow("Student Added Successfully.","Successful");
            }
            else
                MessageShow("Fill all fields correctly.","Error!");

            newStudentDepartmentComboBox.Text = "--Select--";
            newStudentIdTextBox.ResetText();
            newStudentNameTextBox.ResetText();
            newStudentYearComboBox.ResetText();
            newStudentSemesterComboBox.ResetText();
            newStudentSessionComboBox.ResetText();
        }
        private void newStudentAddBackButton_Click(object sender, EventArgs e)
        {
            addNewStudentPanel.Visible = false;
        }

        ///Auto fill combobox
        private void newStudentDepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newStudentYearComboBox.Text = "--Select--";
            newStudentSemesterComboBox.Text = "";
            newStudentSessionComboBox.Text = "";
            if (newStudentDepartmentComboBox.Text == "Civil Engineering" || newStudentDepartmentComboBox.Text == "Electrical & Electronic Engineering" || newStudentDepartmentComboBox.Text == "Mechanical Engineering" || newStudentDepartmentComboBox.Text == "Computer Science and Engineering" || newStudentDepartmentComboBox.Text == "Textile Engineering" || newStudentDepartmentComboBox.Text == "Architecture" || newStudentDepartmentComboBox.Text == "Industrial & Production Engineering" || newStudentDepartmentComboBox.Text == "Chemical & Food Engineering")
                newStudentYearComboBox.DataSource = Years;
        }
        private void newStudentYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newStudentSemesterComboBox.Text = "";
            newStudentSessionComboBox.Text = "";
            if (newStudentYearComboBox.Text == "1st" || newStudentYearComboBox.Text == "2nd" || newStudentYearComboBox.Text == "3rd" || newStudentYearComboBox.Text == "4th")
                newStudentSemesterComboBox.DataSource = Semesters;
        }
        private void newStudentSemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newStudentSessionComboBox.Text = "";
            if (newStudentSemesterComboBox.Text == "1st" || newStudentSemesterComboBox.Text == "2nd")
                newStudentSessionComboBox.DataSource = Sessions;
        }
        private void viewStudentButton_Click(object sender, EventArgs e)
        {
            viewStudentPanel.Visible = true;
            viewStudentPanel.Width = 1152;
            DepartmentGateway departmentGateway = new DepartmentGateway();
            DataSet dataset = departmentGateway.getDepartmentinfo();
            viewStudentDepartmentComboBox.DisplayMember = "department_name";
            viewStudentDepartmentComboBox.ValueMember = "department_name";
            viewStudentDepartmentComboBox.DataSource = dataset.Tables[0];
            viewStudentDepartmentComboBox.Text = "--Select--";
            viewStudentYearComboBox.Text = "";
            viewStudentSemesterComboBox.Text = "";
            viewStudentSessionComboBox.Text = "";
        }
        private void viewStudentDepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewStudentYearComboBox.Text = "--Select";
            viewStudentSemesterComboBox.Text = "";
            viewStudentSessionComboBox.Text = "";
            if (viewStudentDepartmentComboBox.Text == "Civil Engineering" || viewStudentDepartmentComboBox.Text == "Electrical & Electronic Engineering" || viewStudentDepartmentComboBox.Text == "Mechanical Engineering" || viewStudentDepartmentComboBox.Text == "Computer Science and Engineering" || viewStudentDepartmentComboBox.Text == "Textile Engineering" || viewStudentDepartmentComboBox.Text == "Architecture" || viewStudentDepartmentComboBox.Text == "Industrial & Production Engineering" || viewStudentDepartmentComboBox.Text == "Chemical & Food Engineering")
                viewStudentYearComboBox.DataSource = Years;
        }
        private void viewStudentYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewStudentSessionComboBox.Text = "";
            if (viewStudentYearComboBox.Text == "1st" || viewStudentYearComboBox.Text == "2nd" || viewStudentYearComboBox.Text == "3rd" || viewStudentYearComboBox.Text == "4th")
                viewStudentSemesterComboBox.DataSource = Semesters;
        }
        private void viewStudentSemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewStudentSemesterComboBox.Text == "1st" || viewStudentSemesterComboBox.Text == "2nd")
                viewStudentSessionComboBox.DataSource = Sessions;

        }
        private void viewStudentsPanelBackButton_Click(object sender, EventArgs e)
        {
            viewStudentPanel.Visible = false;
        }
        private void viewStudentsInfoBackButton_Click(object sender, EventArgs e)
        {
            viewStudentInfoPanel.Visible = false;
        }
        private void viewStudentsButton_Click(object sender, EventArgs e)
        {
            viewStudentInfoPanel.Visible = true;
            viewStudentInfoPanel.Width = 1152;
            Students student = new Students();
            student.Department = viewStudentDepartmentComboBox.Text;
            student.Year = viewStudentYearComboBox.Text;
            student.Semester = viewStudentSemesterComboBox.Text;

            StudentsGateway studentsGateway = new StudentsGateway();

            List<Students> students = new List<Students>();

            students = studentsGateway.getAllStudentsInformation(student); // Get Students Information
            viewStudentsInfoDataGridView.DataSource = students;

            // for Designing DatagridView
            viewStudentsInfoDataGridView.BorderStyle = BorderStyle.FixedSingle;
            viewStudentsInfoDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            viewStudentsInfoDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            viewStudentsInfoDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            viewStudentsInfoDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            viewStudentsInfoDataGridView.BackgroundColor = Color.White;

            viewStudentsInfoDataGridView.EnableHeadersVisualStyles = false;
            viewStudentsInfoDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            viewStudentsInfoDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            viewStudentsInfoDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            viewStudentDepartmentComboBox.ResetText();
            viewStudentYearComboBox.ResetText();
            viewStudentSemesterComboBox.ResetText();
            viewStudentSessionComboBox.ResetText();

        }
        ///********************** End of Student Panel*************************/
        ///********************** ViewResult Panel*************************/
        private void viewResultPanelLoad()
        {
            DepartmentGateway departmentGateway = new DepartmentGateway();
            DataSet dataset = departmentGateway.getDepartmentinfo();
            viewResultStudentDepartmentComboBox.DisplayMember = "department_name";
            viewResultStudentDepartmentComboBox.ValueMember = "department_name";
            viewResultStudentDepartmentComboBox.DataSource = dataset.Tables[0];
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

        private void viewResultStudentsDepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewResultStudentYearComboBox.Text = "--Select--";
            viewResultStudentSemesterComboBox.Text = "";
            viewResultStudentSessionComboBox.Text = "";
            if (viewResultStudentDepartmentComboBox.Text == "Civil Engineering" || viewResultStudentDepartmentComboBox.Text == "Electrical & Electronic Engineering" || viewResultStudentDepartmentComboBox.Text == "Mechanical Engineering" || viewResultStudentDepartmentComboBox.Text == "Computer Science and Engineering" || viewResultStudentDepartmentComboBox.Text == "Textile Engineering" || viewResultStudentDepartmentComboBox.Text == "Architecture" || viewResultStudentDepartmentComboBox.Text == "Industrial & Production Engineering" || viewResultStudentDepartmentComboBox.Text == "Chemical & Food Engineering")
                viewResultStudentYearComboBox.DataSource = Years;
        }
        private void viewResultStudentYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewResultStudentSessionComboBox.Text = "";
            if (viewResultStudentYearComboBox.Text == "1st" || viewResultStudentYearComboBox.Text == "2nd" || viewResultStudentYearComboBox.Text == "3rd" || viewResultStudentYearComboBox.Text == "4th")
                viewResultStudentSemesterComboBox.DataSource = Semesters;
        }
        private void viewResultStudentSemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewResultStudentSemesterComboBox.Text == "1st" || viewResultStudentSemesterComboBox.Text == "2nd")
                viewResultStudentSessionComboBox.DataSource = Sessions;
        }
    }
}
