using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUET_ResultManagementSystem
{
    class Department
    {
        private int department_ID;
        private string departmentName;

        public int Department_ID { get => department_ID; set => department_ID = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
    }
}
