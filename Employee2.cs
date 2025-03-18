using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    public class Employee2
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int DeptId { get; set; }

        public override string ToString()
        {
            return $"{Id},{Name},{Age},{Salary},{DeptId}";
        }
    }
}
