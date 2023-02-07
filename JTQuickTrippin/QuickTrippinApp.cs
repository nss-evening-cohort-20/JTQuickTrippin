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
            
            Employee employee = new Employee(id:1, name: "sam", age: 20, wage :25, jobRole: "assistant"  );

            employee.ToString();
            Console.WriteLine(employee.ToString());

           
        } 
    }
}
