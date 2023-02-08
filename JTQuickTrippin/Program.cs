using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace JTQuickTrippin
{
    internal class Program
    {
        static void Main(string[] args)
        {
             void enterDistrictSales()
            {

            }

            void printOptions()
            {
                Console.WriteLine("QuikTrip Management Systems");
                Console.WriteLine("1. Enter District Sales");
                Console.WriteLine("2. Generate District Report");
                Console.WriteLine("3. Add New Employee");
                Console.WriteLine("4. Add a Store/District");
                Console.WriteLine("5. Exit");
            }

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
                else if(option == 2) { GenerateReport(); }
                else if (option == 3) { AddEmployee(); }
                else if (option == 4) { AddStore(); }
                else if (option == 5) { break; }
                else { option = 0; }
            }
            while (option!= 5);
            Console.WriteLine("Thank you, have a nice day!");




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
        }

        static void AddStore()
        {
            Console.WriteLine("Add store/district");
        }


    }
}