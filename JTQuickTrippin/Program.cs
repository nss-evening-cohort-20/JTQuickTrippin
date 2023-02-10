using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace JTQuickTrippin
{
    internal class Program
    {
        static void Main(string[] args)
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
        }
        static void AddEmployee()
        {
            Console.WriteLine("Add new employee");
            Employee newEmployee = new Employee();
            Console.WriteLine("Enter Employee name:");
            newEmployee.name = Console.ReadLine();
            Console.WriteLine("Enter employee age:");
            newEmployee.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee store ID:");
            newEmployee.storeId = int.Parse(Console.ReadLine());
            newEmployee.EnteredEmployee();
            
        }

        static void AddStore()
        {
            
            Console.WriteLine("Please enter a store ID:");
            int StoreId = int.Parse(Console.ReadLine());
            Console.WriteLine("Gas yearly:");
            double GasYearly= double.Parse(Console.ReadLine());
            Console.WriteLine("Gas Quarterly:");
            double GasQuarterly= double.Parse(Console.ReadLine());
            Console.WriteLine("Retail yearly");
            double RetailYearly= double.Parse(Console.ReadLine());
            Console.WriteLine("Retail quarterly");
            double RetailQuarterly= double.Parse(Console.ReadLine());

            Store newStore = new Store(StoreId, GasYearly, GasQuarterly, RetailYearly, RetailQuarterly);
            StoreRepository.AddStoreList(newStore);

        }

        static void ViewStores() 
        {
            StoreRepository repository= new StoreRepository();
            var stores = repository.GetStores();
            for (int i = 0; i< stores.Count; i++)
            {
                Console.WriteLine(stores[i].StoreId);
            }
        }



    }
}