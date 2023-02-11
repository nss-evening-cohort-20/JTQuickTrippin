using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JTQuickTrippin
{
    public class Sales
    {
        public int Retail { get; set; }
        public int Gas { get; set; }

        public string dName { get; set; }

        public int GasAndRetail { get { return Gas + Retail; } }

        string input;

        public Sales()
        {
            Retail = 0;
            Gas = 0;
            dName = string.Empty;
        }

        public Sales(int retail, int gas)
        {
            Retail = retail;
            Gas = gas;
            dName = string.Empty;
        }




        public void GenerateResponse()
        {
            // welcomes the user 
            Console.WriteLine("begin generating sales report");

            // this piece of code is intended to determine if the report will be retail or gass or both



            int parsedInput;

            Console.WriteLine("enter district name");
            dName = Console.ReadLine();


            do
            {
                Console.WriteLine("Enter 1, 2 or 3");
                input = Console.ReadLine();
                parsedInput = Int32.Parse(input);

            } while (parsedInput <= 0 || parsedInput > 3);

            switch (parsedInput)
            {
                case 1:
                    Console.WriteLine("enter your amount for your yearly retail sales");
                    Retail = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("enter your amount for your yearly Gas sales");
                    Gas = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("enter your amount for your yearly retail sales");
                    Retail = int.Parse(Console.ReadLine());

                    Console.WriteLine("enter your amount for your yearly Gas sales");
                    Gas = int.Parse(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine($"error parsedinput = " + $"{parsedInput}");
                    break;
            }


        }

        public override string ToString()
        {
            return dName;
        }
    }
}


