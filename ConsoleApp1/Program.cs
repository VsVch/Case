using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quolity = double.Parse(Console.ReadLine());

            switch (fruit)
            {

                case "banana":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        Console.WriteLine($"{quolity*2.5:F2}");
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        Console.WriteLine($"{quolity * 2.7:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "apple":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        Console.WriteLine($"{quolity * 1.2:F2}");
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        Console.WriteLine($"{quolity * 1.25:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "orange":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        Console.WriteLine($"{quolity * 0.85:F2}");
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        Console.WriteLine($"{quolity * 0.9:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "grapefruit":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        Console.WriteLine($"{quolity * 1.45:F2}");
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        Console.WriteLine($"{quolity * 1.6:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "kiwi":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        Console.WriteLine($"{quolity * 2.7:F2}");
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        Console.WriteLine($"{quolity * 3:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "pineapple":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        Console.WriteLine($"{quolity * 5.5:F2}");
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        Console.WriteLine($"{quolity * 5.6:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "grapes":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
                    {
                        Console.WriteLine($"{quolity * 3.85:F2}");
                    }
                    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                    {
                        Console.WriteLine($"{quolity * 4.2:F2}");
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
