using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUET_ResultManagementSystem
{
    class Courses
    {
        private string code;
        private string title;
        private string type;
        private double creditHour;
        private string year;
        private string semester;
        private string departmentName;
        private int departmentId;

        public string Code { get => code; set => code = value; }
        public string Title { get => title; set => title = value; }
        public string Type { get => type; set => type = value; }
        public double CreditHour { get => creditHour; set => creditHour = value; }
        public string Year { get => year; set => year = value; }
        public string Semester { get => semester; set => semester = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public int DepartmentId { get => departmentId; set => departmentId = value; }
    }
}
