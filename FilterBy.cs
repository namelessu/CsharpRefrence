using Adv_c__revision;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    public class FilterBy
    {
        public static bool BySalary(Employee2 employee)
        {
            return employee.Salary > 5000;
        }

        public static bool ByDeptId(Employee2 employee)
        {
            return employee.DeptId == 20;
        }
        public static bool ByName(Employee2 employee)
        {
            return employee.Name.ToLower().Contains("ahmed");
        }
    }
}
