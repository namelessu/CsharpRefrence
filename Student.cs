using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal class Student
    {
        #region Automatic Property 
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public int Age { get; set; }
        //public decimal Salary { get; set; }

        #endregion

        #region Traditinol way to implement Properties
        /// How compiler interpret the properties
        // int id;
        // public int Id {
        // set {id = value ; }
        // get {return id ;}
        // }
        #region Data Fields
        private int id;
        private string? name;
        private int age;
        private decimal salary;
        public static int counter;
        #endregion
        #region manual properties
        // first letter in property must be upper case
        // Remeber : Inside Property private field always in left side 
        public int Id
        {
            set // Compiler    void SetId(int value)
            {
                id = value;
            }
            get  // Compiler     int Get()
            {
                return id;
            }
        }
        public string? Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        #endregion
        public int Age
        {
            set
            {
                if (value < 18)
                {
                    age = 18;
                }
                else
                {
                    age = value;
                }
            }
            get
            {
                return age;
            }
        }
        public decimal Salary
        {
            set { salary = value; }
            get { return salary; }
        }

        #endregion
        #region Setters & Getters
        //public void SetId(int _id) { id = _id; }
        //public void SetName(string _name) {  name = _name; }
        //public void SetAge(int _age) { age = _age; }
        //public void SetSalary(int _salary) {  salary = _salary; }   
        //public int GetId() { return id; }
        //public string GetName() { return name; }
        //public int GetAge() { return age; }
        //public decimal GetSalary() {  return salary; }
        #endregion
        #region static constructor
        static Student()
        {
            counter = 0;
        }
        #endregion
        #region ctor
        public Student()
        {
            Id = 0;
            Name = "Ahmed";
            Salary = 100000;
            Age = 10;
        }
        public Student(int _id, string _name, int _age, decimal _salary)
        {
            Id = _id;
            Name = _name;
            Age = _age;
            Salary = _salary;
        }
        #endregion

        #region Print 
        public string Print()
        {
            return $"{Id},{Name},{Age},{Salary}";
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $" =========== > {Id},{Name},{Age},{Salary}";
        }
        #endregion
    }
}
