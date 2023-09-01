using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUET_ResultManagementSystem
{
    class Students
    {
        private int Id;
        private string name;
        private string department;
        private string year;
        private string semester;
        private string session;

        
        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public string Year { get => year; set => year = value; }
        public string Semester { get => semester; set => semester = value; }
        public string Session { get => session; set => session = value; }
        public int ID { get => Id; set => Id = value; }
    }
}
