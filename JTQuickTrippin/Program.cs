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
                if (option == 1) { Console.WriteLine("Enter district sales"); }
                else if(option == 2) { Console.WriteLine("Generating report"); }
                else if (option == 3) { Console.WriteLine("Add new employee"); }
                else if (option == 4) { Console.WriteLine("Add store/district"); }
                else if (option == 5) { break; }
                else { option = 0; }
            }
            while (option!= 5);
            Console.WriteLine("Thank you, have a nice day!");




        }
    }
}