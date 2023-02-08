using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTQuickTrippin
{
    public class Employee
    {
        string name { get; set; }
        int age { get; set; }
        int storeId { get; set; }



        public Employee(string name, int age, int storeId)
        {
            this.name = name;
            this.age = age;
            this.storeId = storeId;
        }

        public void GetEmployee()
        {
            Console.WriteLine("Employee name: " + name);
            Console.WriteLine("Age " + age);
            Console.WriteLine("Store ID " + storeId);
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
