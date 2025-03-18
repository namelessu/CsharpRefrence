using Adv_c__revision;

namespace Adv_c__revision
{
    public class Repo
    {
        public static List<Employee2> GetEmployees()
        {
            return new List<Employee2>()
            {
                new Employee2() {Id = 1 , Name = "Ahmed" , Age = 20 , Salary = 3000 , DeptId = 10},
                new Employee2() {Id = 2 , Name = "Fares" , Age = 22 , Salary = 4000 , DeptId = 10},
                new Employee2() {Id = 4 , Name = "Mona" , Age = 21 , Salary = 4000 , DeptId = 10},
                new Employee2() {Id = 5 , Name = "Ziad" , Age = 23 , Salary = 4000 , DeptId = 20},
                new Employee2() {Id = 3 , Name = "Ramy" , Age = 24 , Salary = 5000 , DeptId = 20},
                new Employee2() {Id = 6 , Name = "Mario" , Age = 25 , Salary = 6000 , DeptId = 20},
                new Employee2() {Id = 7 , Name = "Sara" , Age = 26 , Salary = 7000 , DeptId = 30},
                new Employee2() {Id = 8 , Name = "Esraa" , Age = 27 , Salary = 8000 , DeptId = 30},
                new Employee2() {Id = 9 , Name = "Habiba" , Age = 28 , Salary = 9000 , DeptId = 30},
                new Employee2() {Id = 10 , Name = "Gana" , Age = 29 , Salary = 2000 , DeptId = 10},
            };
        }

        public static List<Employee2> Employees { get; set; } = new List<Employee2>()
        {
             new Employee2() {Id = 1 , Name = "Ahmed" , Age = 20 , Salary = 3000 , DeptId = 10},
                new Employee2() {Id = 2 , Name = "Fares" , Age = 22 , Salary = 4000 , DeptId = 10},
                new Employee2() {Id = 4 , Name = "Mona" , Age = 21 , Salary = 4000 , DeptId = 10},
                new Employee2() {Id = 5 , Name = "Ziad" , Age = 23 , Salary = 4000 , DeptId = 20},
                new Employee2() {Id = 3 , Name = "Ramy" , Age = 24 , Salary = 5000 , DeptId = 20},
                new Employee2() {Id = 6 , Name = "Mario" , Age = 25 , Salary = 6000 , DeptId = 20},
                new Employee2() {Id = 7 , Name = "Sara" , Age = 26 , Salary = 7000 , DeptId = 30},
                new Employee2() {Id = 8 , Name = "Esraa" , Age = 27 , Salary = 8000 , DeptId = 30},
                new Employee2() {Id = 9 , Name = "Habiba" , Age = 28 , Salary = 9000 , DeptId = 30},
                new Employee2() {Id = 10 , Name = "Gana" , Age = 29 , Salary = 2000 , DeptId = 10},

        };


    }
}
