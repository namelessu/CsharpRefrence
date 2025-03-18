using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Filteration
    {
        // class contain all possible functions to filter
        public static List<Employee2> FilterByDeptId(List<Employee2> employees)
        {
            var retVal = new List<Employee2>() ;
            foreach (var employee in employees)
            {
                if (employee.DeptId == 10)
                {
                    retVal.Add(employee);
                }
            }
            return retVal;
        }

        public static List<Employee2> FilterBySalary(List<Employee2> employees)
        {
            var retVal = new List<Employee2>();
            foreach (var employee in employees)
            {
                if (employee.Salary > 5000)
                {
                    retVal.Add(employee);
                }
            }
            return retVal;
        }

        public static List<Employee2> FilterByName(List<Employee2> employees)
        {
            var retVal = new List<Employee2>();
            foreach (var employee in employees)
            {
                if (employee.Name.ToLower().Contains('s'))
                {
                    retVal.Add(employee);
                }
            }
            return retVal;
        }

        public static List<Employee2> FilterByAny(List<Employee2> employees)
        {
            var retVal = new List<Employee2>();
            foreach (var employee in employees)
            {
                //if (FilterBy.BySalary(employee))
                //if (FilterBy.ByDeptId(employee))
                if (FilterBy.ByName(employee))
                {
                    retVal.Add(employee);
                }
            }
            return retVal;
        }

        public static List<Employee2> FilterByAnyV02(List<Employee2> employees, MyDelegate del)
        {
            List<Employee2> retVal = new List<Employee2>();
            foreach (var employee in employees)
            {
                if (del(employee))
                {
                    retVal.Add(employee);
                }
            }
            return retVal;
        }
    }
}
