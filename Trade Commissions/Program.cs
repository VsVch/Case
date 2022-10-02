using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0.00;

            switch (town)
            {
                case "Sofia":
                    if (0<=sales && sales<=500 )
                    {
                        comission = 0.05;
                        Console.WriteLine($"{sales*comission:f2}");
                    }
                    else if (500<sales && sales <= 1000)
                    {
                        comission = 0.07;
                        Console.WriteLine($"{sales * comission:f2}");
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        comission = 0.08;
                        Console.WriteLine($"{sales * comission:f2}");
                    }
                    else if (10000 < sales)
                    {
                        comission = 0.12;
                        Console.WriteLine($"{sales * comission:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                case "Varna":
                    if (0 <= sales && sales <= 500)
                    {
                        comission = 0.045;
                        Console.WriteLine($"{sales * comission:f2}");
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        comission = 0.075;
                        Console.WriteLine($"{sales * comission:f2}");
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        comission = 0.1;
                        Console.WriteLine($"{sales * comission:f2}");
                    }
                    else if (10000 < sales)
                    {
                        comission = 0.13;
                        Console.WriteLine($"{sales * comission:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (0 <= sales && sales <= 500)
                    {
                        comission = 0.055;
                        Console.WriteLine($"{sales * comission:f2}");
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        comission = 0.08;
                        Console.WriteLine($"{sales * comission:f2}");
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        comission = 0.12;
                        Console.WriteLine($"{sales * comission:f2}");
                    }
                    else if (10000 < sales)
                    {
                        comission = 0.145;
                        Console.WriteLine($"{sales * comission:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;


                default:
                    Console.WriteLine("error");
                    break;
            }


        }
    }
}
