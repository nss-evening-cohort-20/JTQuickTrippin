using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTQuickTrippin
{
    internal class QuickTrippinApp
    {
        public void Run()
        {
            Console.WriteLine("Quick Trippin App");

            EmployeeRepository employeeRepository = new EmployeeRepository();
            
            Employee employeeOne= new Employee(id:1, name: "sam", age: 20, wage :25, jobRole: "assistant"  );

            Employee employeeTwo = new Employee(id: 2, name: "mike", age: 22, wage: 23, jobRole: "manager");

            Employee employeeThree = new Employee(id: 3, name: "shaan", age: 28, wage: 27, jobRole: "assistant manager");



            employeeRepository.AddEmployee(employeeOne);
            employeeRepository.AddEmployee(employeeTwo);
            employeeRepository.AddEmployee(employeeThree);

            
            Console.WriteLine(employeeRepository.GetEmployee(2));

            Console.WriteLine(employeeRepository.GetEmployee(5));

            EmployeeRepository employeeRepository1 = new EmployeeRepository();

            Employee employee4 = new Employee(id: 4, name: "ram", age: 30, wage: 30, jobRole: "associate2");

            employeeRepository1.AddEmployee(employee4);

            Console.WriteLine(employeeRepository.GetEmployee(4));


        } 
    }
}
