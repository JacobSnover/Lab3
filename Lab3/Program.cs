using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                int value;
                Console.Write("please give me a number: ");
                string input = Console.ReadLine();

                while (!int.TryParse(input, out value) || value < 0)
                {
                    Console.WriteLine("Sorry but that is not a proper response. ");
                    Console.Write($"Please give me a number: ");
                    input = Console.ReadLine();

                }
                Console.WriteLine("Number\t\tSquared\t\tCubed");
                Console.WriteLine("=======\t\t=======\t\t======");
                for (int r = 1; r <= value; r++)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", value, Math.Pow(value, 2), Math.Pow(value, 3));
                }

                while (true)
                {

                    Console.Write("Do you want to continue Yes or No? ");
                    string test = Console.ReadLine().ToLower();

                    if (test == "y" || test == "yes")
                    {
                        break;
                    }
                    else if (test == "n" || test == "no")
                    {

                        Environment.Exit(1);
                    }

                }

            }
        }
    }
}
