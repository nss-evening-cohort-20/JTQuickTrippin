using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTQuickTrippin
{
    internal class Employee
    {
        static int _id = 1;
        public int Id { get; }

        public int StoreId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Wage { get; set; }

        public string JobRole { get; set; }

        public Employee(int storeId ,string name , int age, int wage , string jobRole) {
            Id = _id++;
            StoreId = storeId;
            Name = name;
            Age = age;
            Wage = wage;
            JobRole = jobRole;
        }

        public override string ToString()
        {
            return $"Id:{Id} - Name:{Name} - Age: {Age} - Wage:{Wage} - Job Role: {JobRole} - Store Id: {StoreId}";
        }

    }




}
