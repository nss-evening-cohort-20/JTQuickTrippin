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

        //public string getName()
        //{
        //    return name;
        //}

        //public int getAge()
        //{
        //    return age;
        //}

        //public int getStoreId()
        //{
        //    return storeId;
        //}

        //public void setName(string newName)
        //{
        //    this.name = newName;
        //}

        //public void setAge(int newAge)
        //{
        //    this.age = newAge;
        //}

        //public void setStoreId(int newStoreId)
        //{
        //    this.storeId = newStoreId;
        //}


    }




}
