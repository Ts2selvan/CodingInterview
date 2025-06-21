using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    //Filter all the employees whose salary is greater than 50000 in linq
    class FilterSalary
    {
        public void FilterSalaryGreater()
        {
            List<Employee> employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Alice", Salary = 60000 },
    new Employee { Id = 2, Name = "Bob", Salary = 45000 },
    new Employee { Id = 3, Name = "Charlie", Salary = 75000 }
};
            var MShighSalary=employees.Where(e=>e.Salary>50000).ToList();
            var QShighSalary= (from emp in employees where emp.Salary >50000 select emp).ToList();
            Console.WriteLine("Filter all the employees whose salary is greater than 50000 in linq");
            Console.WriteLine("\nMethod Syntax result:");
            foreach (var emp in MShighSalary)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }

            Console.WriteLine("\nQuery Syntax result:");
            foreach (var emp in QShighSalary)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
            ;
            Console.ReadKey();  

        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
}


    }
