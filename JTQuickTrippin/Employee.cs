using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTQuickTrippin
{
    public class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public int storeId { get; set; }



        //public Employee(string name, int age, int storeId)
        //{
        //    this.name = name;
        //    this.age = age;
        //    this.storeId = storeId;
        //}

        public void EnteredEmployee()
        {
            Console.WriteLine("Employee entered:");
            Console.WriteLine("=================");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Store ID: " + storeId);
            Console.Read();
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
