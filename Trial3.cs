using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Trial3
    {
        public static bool IsOldEmployee(Employee2 employee) { return employee.Age > 25; }
        public static bool BySalary(Employee2 employee) { return employee.Salary > 5000; }

        public static void PrintEmployee(Employee2 employee) { Console.WriteLine(employee); }

        public static int Add(int left, int right) { return left + right; }
        public static int Sub(int left, int right) { return left + right; }
        public static int Mul(int left, int right) { return left + right; }
        public static int Div(int left, int right) { return left + right; }


    }
}
