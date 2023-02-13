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
            void printOptions()
            {
                Console.WriteLine("QuikTrip Management Systems");
                Console.WriteLine("1. Enter District Sales");
                Console.WriteLine("2. Generate District Report");
                Console.WriteLine("3. Add New Employee");
                Console.WriteLine("4. Add a Store/District");
                Console.WriteLine("5. Exit");
                Console.WriteLine("6. Print all stores");
            }

            {
                int option = 0;
                do
                {
                    printOptions();
                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    catch { }
                    if (option == 1) { EnterSales(); }
                    else if (option == 2) { GenerateReport(); }
                    else if (option == 3) { AddEmployee(); }
                    else if (option == 4) { AddStore(); }
                    else if (option == 5) { break; }
                    else if (option == 6) { ViewStores(); }
                    else { option = 0; }
                }
                while (option != 5);
                Console.WriteLine("Thank you, have a nice day!");
            }



        }


        static void EnterSales()
        {
            Console.WriteLine("Enter district sales");

        }

        static void GenerateReport()
        {
            Console.WriteLine("Generating report");
            {
                StoreRepository repository = new StoreRepository();
                var stores = repository.GetStores();
                for (int i = 0; i < stores.Count; i++)
                {
                    Console.WriteLine(stores[i].StoreId);
                    Console.WriteLine("Gas Quarterly: " + stores[i].GasQuarterly);
                    Console.WriteLine("Gas Yearly: " + stores[i].GasYearly);
                    Console.WriteLine("Retail Quarterly: " + stores[i].RetailQuarterly);
                    Console.WriteLine("Retail Yearly: " + stores[i].RetailYearly);
                    Console.ReadLine();
                }
            }
        }
        static void AddEmployee()
        {
            Console.WriteLine("Add new employee");

            Console.WriteLine("Enter Employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee store ID:");
            int storeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee wage:");
            int wage = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee job role:");
            string jobRole = Console.ReadLine();

            Employee employee = new Employee(storeId:storeId,name:name,age:age,wage:wage,jobRole:jobRole);
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.AddEmployee(employee);

            Console.WriteLine($"Employee Added: {employee}");

        }

        static void AddStore()
        {

            Console.WriteLine("Please enter a store ID:");
            int StoreId = int.Parse(Console.ReadLine());
            Console.WriteLine("Gas yearly:");
            double GasYearly = double.Parse(Console.ReadLine());
            Console.WriteLine("Gas Quarterly:");
            double GasQuarterly = double.Parse(Console.ReadLine());
            Console.WriteLine("Retail yearly");
            double RetailYearly = double.Parse(Console.ReadLine());
            Console.WriteLine("Retail quarterly");
            double RetailQuarterly = double.Parse(Console.ReadLine());

            Store newStore = new Store(StoreId, GasYearly, GasQuarterly, RetailYearly, RetailQuarterly);
            StoreRepository.AddStoreList(newStore);

        }

        static void ViewStores()
        {
            StoreRepository repository = new StoreRepository();
            var stores = repository.GetStores();
            for (int i = 0; i < stores.Count; i++)
            {
                Console.WriteLine(stores[i].StoreId);
            }
        }
        //Console.WriteLine("Quick Trippin App");

        //EmployeeRepository employeeRepository = new EmployeeRepository();

        //Employee employeeOne= new Employee(id:1, name: "sam", age: 20, wage :25, jobRole: "assistant"  );

        //Employee employeeTwo = new Employee(id: 2, name: "mike", age: 22, wage: 23, jobRole: "manager");

        //Employee employeeThree = new Employee(id: 3, name: "shaan", age: 28, wage: 27, jobRole: "assistant manager");



        //employeeRepository.AddEmployee(employeeOne);
        //employeeRepository.AddEmployee(employeeTwo);
        //employeeRepository.AddEmployee(employeeThree);


        //Console.WriteLine(employeeRepository.GetEmployee(2));

        //Console.WriteLine(employeeRepository.GetEmployee(5));

        //EmployeeRepository employeeRepository1 = new EmployeeRepository();

        //Employee employee4 = new Employee(id: 4, name: "ram", age: 30, wage: 30, jobRole: "associate2");

        //employeeRepository1.AddEmployee(employee4);

        //Console.WriteLine(employeeRepository.GetEmployee(4));


    }
}

