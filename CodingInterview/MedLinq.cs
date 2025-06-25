using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
     class MedLinq
    {
        public void GetValues()
        {
            //Group employess by department and count them 
            var employees = new List<Employee1>
{
    new Employee1 { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },
    new Employee1 { Id = 2, Name = "Bob", Department = "IT", Salary = 60000 },
    new Employee1 { Id = 3, Name = "Charlie", Department = "HR", Salary = 52000 },
    new Employee1 { Id = 4, Name = "David", Department = "Finance", Salary = 58000 },
    new Employee1 { Id = 5, Name = "Eve", Department = "IT", Salary = 61000 }
};
            var MSgrpEmp=employees.GroupBy(e => e.Department).Select(g => new
            {
Department = g.Key,
Count = g.Count()
            }).ToList();
            Console.WriteLine("\nMethod Syntax result:");
            foreach (var group in MSgrpEmp)
            {
                Console.WriteLine($"{group.Department}: {group.Count}");
            }
            var QSgrpEmp = from emp in employees
                           group emp by emp.Department into deptgroup
                           select new
                           {
                               Department = deptgroup.Key,
                               Count = deptgroup.Count()
                           };

            Console.WriteLine("\nQuery Syntax result:");
            foreach (var group in QSgrpEmp)
            {
                Console.WriteLine($"{group.Department}: {group.Count}");
            }

            //Group disticnt department names from employees
            var MSDemp=employees.DistinctBy(e => e.Department).ToList();
            var QSDemp=(from emp in employees select emp.Department).Distinct().ToList();
            Console.WriteLine("\nMethod Syntax result:");
            foreach (var group in MSDemp)
            {
                Console.WriteLine($"{group.Department}");
            }
            Console.WriteLine("\nQuery Syntax result:");
            foreach (var group in QSDemp)
            {
                Console.WriteLine($"{group}");
            }
            //Get max salary among employees
            var MSmaxSalary = employees.Max(e => e.Salary);
            var QSmaxSalary = (from emp in employees select emp.Salary).Max();
            Console.WriteLine("\nMethod Syntax result:");

            
                Console.WriteLine($"{MSmaxSalary}");
           
            Console.WriteLine("\nQuery Syntax result:");
            Console.WriteLine($"{QSmaxSalary}");
        //Get Average salary 
        var MSAvgSal=employees.Average(e => e.Salary);
            var QSAvgSal=(from emp in employees select emp.Salary ).Average();
            Console.WriteLine("\nMethod Syntax result:");


            Console.WriteLine($"{MSAvgSal}");

            Console.WriteLine("\nQuery Syntax result:");
            Console.WriteLine($"{QSAvgSal}");
            //-------------------------------------------------------------------------------------
            var employees1 = new List<Employee2>
{
    new Employee2 { Id = 1, Name = "Alice", DepartmentId = 1, Salary = 50000 },
    new Employee2 { Id = 2, Name = "Bob", DepartmentId = 2, Salary = 60000 },
    new Employee2 { Id = 3, Name = "Charlie", DepartmentId = 1, Salary = 52000 },
    new Employee2 { Id = 4, Name = "David", DepartmentId = 3, Salary = 58000 },
    new Employee2 { Id = 5, Name = "Eve", DepartmentId = 2, Salary = 61000 }
};

            var departments = new List<Department>
{
    new Department { Id = 1, DeptName = "HR" },
    new Department { Id = 2, DeptName = "IT" },
    new Department { Id = 3, DeptName = "Finance" }
};
            var QSjoinEmpDept=(from emp in employees1 join dept in departments on  emp.DepartmentId equals dept.Id  
                               select new {emp.Name,
                               emp.Salary,
                               dept.DeptName});

            Console.WriteLine("\nQuery Syntax result:");
            foreach (var item in QSjoinEmpDept)
            {
                Console.WriteLine($"{item.Name} - {item.DeptName} - {item.Salary}");
            }


            //Get employees whose name startys with "A"
            var MSStartswithA=employees1.Where(employees => employees.Name.StartsWith("A")).ToList();
            var QSStartswithA = (from emp in employees1 where emp.Name.StartsWith("A") select emp).ToList();
            Console.WriteLine("\nMethod Syntax result:");
            foreach (var item in MSStartswithA)
            {
                Console.WriteLine($"{item.Name} ");
            }
            Console.WriteLine("\nQuery Syntax result:");
            foreach (var item in QSStartswithA)
            {
                Console.WriteLine($"{item.Name} ");
            }

            //Skip top 2 salaries and take next 2
            var MSTop2Sal=employees1.Select(emp => emp.Salary)
                .Distinct()
                .OrderByDescending(s=>s)
                .Skip(2)
                .Take(2)
                .ToList();
            foreach (var item in MSTop2Sal)
            {
                Console.WriteLine(item);
            }

            //Get Employees count per department
            var MSEmpwiseDept = employees.GroupBy(e => e.Department)
                .Select(g=>new
                {
                    Department=g.Key,
                    EmpCount=g.Count()
                }).ToList();
            foreach(var item in MSEmpwiseDept)
            {
                Console.WriteLine($"Department : {item.Department} ,Employee Count : {item.EmpCount}");
            }
            Console.ReadKey();
            
        }
    }
    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
    public class Employee2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }  // foreign key
        public decimal Salary { get; set; }
    }
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
    }



}
