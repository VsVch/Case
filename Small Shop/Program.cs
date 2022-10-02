using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string stock = Console.ReadLine();
            string town = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());

            if (stock == "coffee")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(price*0.50);
                }

                else if (town == "Plovdiv")
                {
                    Console.WriteLine(price * 0.40);
                }

                else if (town == "Varna")
                {
                    Console.WriteLine(price * 0.45);
                }


            }
            else if (stock == "water")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(price * 0.80);
                }

                else if (town == "Plovdiv")
                {
                    Console.WriteLine(price * 0.70);
                }

                else if (town == "Varna")
                {
                    Console.WriteLine(price * 0.70);
                }



            }
            else if (stock == "beer")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(price * 1.20);
                }

                else if (town == "Plovdiv")
                {
                    Console.WriteLine(price * 1.15);
                }

                else if (town == "Varna")
                {
                    Console.WriteLine(price * 1.10);
                }
            }
            else if (stock == "sweets")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(price * 1.45);
                }

                else if (town == "Plovdiv")
                {
                    Console.WriteLine(price * 1.30);
                }

                else if (town == "Varna")
                {
                    Console.WriteLine(price * 1.35);
                }


            }
            else if (stock == "peanuts")
            {
                if (town == "Sofia")
                {
                    Console.WriteLine(price * 1.60);
                }

                else if (town == "Plovdiv")
                {
                    Console.WriteLine(price * 1.50);
                }

                else if (town == "Varna")
                {
                    Console.WriteLine(price * 1.55);
                }

            }




        }
    }
}
