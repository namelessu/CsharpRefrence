using System;

namespace Adv_c__revision
{
    public enum Gender
    {
        Male,
        Female,
        Unknown
    }

    public struct HireDate : ICloneable
    {
        public DateTime Date { get; set; }

        public HireDate()
        {
            Date = DateTime.Now;
        }

        public HireDate(int year, int month, int day)
        {
            Date = new DateTime(year, month, day);
        }

        public object Clone()
        {
            return new HireDate(this.Date.Year, this.Date.Month, this.Date.Day);
        }
    }

    [Flags]
    public enum SecurityPrivileges : byte
    {
        Guest = 1,
        Developer = 2,
        Secretary = 3,
        DBA = 4
    }

    public enum DepartmentName
    {
        IT,
        Engineering,
        CustomerService,
        Management,
        HR,
        Unknown
    }

    public class Department : ICloneable
    {
        private int deptId;
        public int DeptId
        {
            get { return deptId; }
            set { deptId = value < 0 ? 0 : value; }
        }
        public decimal Salary { get; set; }
        public DepartmentName DeptName { get; set; }
        public string? DeptDesc { get; set; }

        public Department()
        {
            this.DeptId = 0;
            this.DeptName = DepartmentName.Unknown;
            this.DeptDesc = "Unidentified";
        }

        public Department(int deptId, DepartmentName deptName, string? deptDesc)
        {
            this.DeptId = deptId;
            this.DeptName = deptName;
            this.DeptDesc = deptDesc;
        }

        public override string ToString()
        {
            return $"{DeptName}::{DeptDesc}";
        }
        public object Clone()
        {
            return new Department
            {
                DeptId = this.DeptId,
                DeptName = this.DeptName,
                DeptDesc = this.DeptDesc
            };
        }
    }

    public class Employee : IComparable<Employee> ,ICloneable
    {
        public int CompareTo(Employee? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            if (HireDate.Equals(default(HireDate)) && other.HireDate.Equals(default(HireDate)))
            {
                return 0; // both dates are default, consider them equal
            }
            else if (HireDate.Equals(default(HireDate)))
            {
                return -1; // this date is default, consider it less than the other date
            }
            else if (other.HireDate.Equals(default(HireDate)))
            {
                return 1; // the other date is default, consider it less than this date
            }
            else
            {
                return HireDate.Date.CompareTo(other.HireDate.Date);
            }
        }
        public object Clone()
        {
            return new Employee
            {
                Id = this.Id,
                Name = this.Name,
                Age = this.Age,
                Gender = this.Gender,
                Department = (Department)this.Department.Clone(),
                HireDate = (HireDate)this.HireDate.Clone()
            };
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
        public SecurityPrivileges Sp { get; set; }
        public HireDate HireDate { get; set; }
        public Department Department { get; set; }

        public Employee()
        {
            this.Name = string.Empty;
            this.Age = null;
            this.Sp = SecurityPrivileges.Guest;
            this.HireDate = new HireDate(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            this.Gender = Gender.Unknown;
            this.Salary = 0;
            this.Department = new Department();
        }
        public Employee(string? name, int? age, decimal salary, SecurityPrivileges sp, HireDate hireDate, Gender gender, Department department)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
            this.Sp = sp;
            this.HireDate = hireDate;
            this.Gender = gender;
            this.Department = department;
        }
        public override string ToString()
        {
            return $"{Name}::{Age}::{Gender}::{Sp}::{HireDate.Date.ToString("yyyy-MM-dd")}::{string.Format("EGP {0:N2}", Salary)}::{Department.ToString()}";
        }

    }
}