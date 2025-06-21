using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
    //Get All Employees Names in Upper case
     class AllEmpUpper
    {
        public void UpperEmpName()

        {
            List<Employee> employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Alice", Salary = 60000 },
    new Employee { Id = 2, Name = "Bob", Salary = 45000 },
    new Employee { Id = 3, Name = "Charlie", Salary = 75000 }
};
var MSEmpUppernames=employees.Select(emp => emp.Name.ToUpper()).ToList();
            var QSEmpUppernames=(from emp in employees select emp.Name.ToUpper()).ToList();
            Console.WriteLine("Get All Employees Names in Upper case");
            Console.WriteLine("\n Method Syntax");
            foreach (var emp in MSEmpUppernames)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("\n Query Syntax");
            foreach (var emp in MSEmpUppernames)
            {
                Console.WriteLine(emp);
            }
            //-----------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("Count Employees in the list");
            var MSCountEmp = employees.Count();
            var  QSCountEmp=(from emp in employees select emp).Count();
           
            Console.WriteLine("\n Method Syntax");
            foreach (var emp in MSCountEmp.ToString())
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("\n Query Syntax");
            foreach (var emp in QSCountEmp.ToString())
            {
                Console.WriteLine(emp);
            }
            //-----------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("String reverse of the names");
            var MSStrRev = employees.Select(e=>new String(e.Name.Reverse().ToArray())).ToList();
            var QSStrRev = (from emp in employees select new String( emp.Name.Reverse().ToArray())).ToList();

            Console.WriteLine("\n Method Syntax");
            foreach (var emp in MSStrRev)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("\n Query Syntax");
            foreach (var emp in QSStrRev)
            {
                Console.WriteLine(emp);
            }
            //-----------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("2nd max salary");
            var MSSecMaxv = employees.Select
                (e=>e.Salary)
                .Distinct()
                .OrderByDescending(s=>s)
                .Skip(1)
                .FirstOrDefault();
            var QSSecMax = (from emp in employees select emp.Salary)
                .Distinct()
                .OrderByDescending(s => s)
                .Skip(1)
                .FirstOrDefault();

            Console.WriteLine("\n Method Syntax");
           
                Console.WriteLine(MSSecMaxv.ToString());
            
            Console.WriteLine("\n Query Syntax");
            
                Console.WriteLine(QSSecMax.ToString());
            //-----------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("2nd max salary with respective name");
            var MSSecMaxvName = employees.Where(e=>e.Salary==employees.Select(e => e.Salary)
                .Distinct()
                .OrderByDescending(s => s)
                .Skip(1)
                .FirstOrDefault()).ToList();
            var QSSecMax1 = (from emp in employees select emp.Salary)
                .Distinct()
                .OrderByDescending(s => s)
                .Skip(1)
                .FirstOrDefault();

            var secondSalaryEmployees = (from e in employees
                                         where e.Salary == QSSecMax1
                                         select e).ToList();

            Console.WriteLine("\n Method Syntax");

            foreach (var emp in MSSecMaxvName)
            {

                Console.WriteLine($"Name : {emp.Name},Salary :{emp.Salary}");
            }

            Console.WriteLine("\n Query Syntax");
            foreach(var emp in secondSalaryEmployees)
            {

                Console.WriteLine($"Name : {emp.Name},Salary :{emp.Salary}");
            }
            //-----------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("Check if any employee earn more than 1Lakh");
            
            bool MSCheckSalLakh = employees.Any( e => e.Salary > 100000);
            bool QSCheckSalLakh=(from emp in employees where emp.Salary>100000 select emp).Any();
            Console.WriteLine("\n Method Syntax");
            if (MSCheckSalLakh) { Console.WriteLine("yes"); }
            else { Console.WriteLine("no"); }
            Console.WriteLine("\n Query Syntax");
            if (QSCheckSalLakh) { Console.WriteLine("yes"); }
            else { Console.WriteLine("no"); }
            //-----------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("Get the first employee with salary >50000");
            var MSFirstSal=employees.Where(e=>e.Salary>50000).FirstOrDefault();
            var QSFirstSal=(from emp in employees where emp.Salary>50000 select emp).FirstOrDefault();
            Console.WriteLine("\n Method Syntax");
            Console.WriteLine(MSFirstSal.Name.ToString());
            Console.WriteLine("\n Query Syntax");
            Console.WriteLine(QSFirstSal.Name.ToString());
            //-----------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("sort employee by salary ascending ");
            var MSSortAsc = employees.OrderBy(e => e.Salary).ToList();
            var QSSortAsc=(from emp in employees orderby emp.Salary select emp).ToList();
            Console.WriteLine("\n Method Syntax");
            foreach (var emp in MSSortAsc)
            {
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Salary);
            }
            Console.WriteLine("\n Query Syntax");
            foreach (var emp in QSSortAsc)
            {
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Salary);
            }
            //-----------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("get only employee name sorted albhapetically");
            var MSOrderAlbha =employees.
                OrderBy(e => e.Name).Select(e => e.Name).ToList();
            var QSSOrderAlbha=(from emp in employees orderby emp.Name select emp.Name).ToList();
            Console.WriteLine("\n Method Syntax");
            foreach (var emp in MSOrderAlbha)
            {
                Console.WriteLine(emp);
                ;
            }
            Console.WriteLine("\n Query Syntax");
            foreach (var emp in QSSOrderAlbha)
            {
                Console.WriteLine(emp);
               
            }


            Console.ReadKey();
        }
    }
  

}
