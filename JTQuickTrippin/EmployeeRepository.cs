using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTQuickTrippin
{
    internal class EmployeeRepository
    {
       static List<Employee> _employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);

        }

        public Employee GetEmployee(int id)
        {
            return _employees.Where(a => a.Id == id).FirstOrDefault();


        }

    }
}
