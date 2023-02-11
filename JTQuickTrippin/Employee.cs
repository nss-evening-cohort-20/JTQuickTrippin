using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTQuickTrippin
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Wage { get; set; }

        public string JobRole { get; set; }

        public Employee( int id, string name , int age, int wage , string jobRole) {
            Id = id;
            Name = name;
            Age = age;
            Wage = wage;
            JobRole = jobRole;
        
        }

        public override string ToString()
        {
            return $"id:{Id} name:{Name} wage:{Wage} ";
        }
    }
}
