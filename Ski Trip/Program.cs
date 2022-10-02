using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            int daysOfrest = int.Parse(Console.ReadLine());
            daysOfrest = daysOfrest - 1;
            string typeOfRooms = Console.ReadLine();
            string kindOfPoint = Console.ReadLine();

            double discond = 0.00;
            double moneyForHolyday = 0.00;

            if (daysOfrest < 10)
            {
                switch (typeOfRooms)
                {
                    case "room for one person":
                        discond = 0.00;
                        moneyForHolyday = moneyForHolyday - discond * moneyForHolyday;
                        if (kindOfPoint == "positive")
                        {
                            moneyForHolyday = moneyForHolyday - 0.25 * moneyForHolyday;
                            //discond = discond + 0.25;
                            Console.WriteLine($"{discond*18*daysOfrest:f2}");
                        }
                        else
                        {
                            discond = discond + 0.1;
                            Console.WriteLine($"{discond*18*daysOfrest:f2}");
                        }
                        break;
                    case "apartment":
                        discond = 0.3;
                        moneyForHolyday = moneyForHolyday - discond * moneyForHolyday;
                        if (kindOfPoint == "positive")
                        {
                            discond = discond + 0.25;
                            Console.WriteLine($"{discond * 25*daysOfrest:f2}");
                        }
                        else
                        {
                            discond = discond + 0.1;
                            Console.WriteLine($"{discond * 25*daysOfrest:f2}");
                        }
                        break;
                    case "president apartment":
                        discond = 0.1;
                        moneyForHolyday = moneyForHolyday - discond * moneyForHolyday;
                        if (kindOfPoint == "positive")
                        {
                            discond = discond + 0.25;
                            Console.WriteLine($"{discond * 35*daysOfrest:f2}");
                        }
                        else
                        {
                            discond = discond + 0.1;
                            Console.WriteLine($"{discond * 35*daysOfrest:f2}");
                        }
                        break;

                    default:
                        break;
                }
            }
            else if (10 <= daysOfrest && daysOfrest <= 15)
            {
                switch (typeOfRooms)
                {
                    case "room for one person":
                        discond = 0.00;
                        moneyForHolyday = moneyForHolyday - discond * moneyForHolyday;
                        if (kindOfPoint == "positive")
                        {
                            discond = discond + 0.25;
                            Console.WriteLine($"{discond * 18*daysOfrest:f2}");
                        }
                        else
                        {
                            discond = discond + 0.1;
                            Console.WriteLine($"{discond * 18*daysOfrest:f2}");
                        }
                        break;
                    case "apartment":
                        discond = 0.35;
                        moneyForHolyday = moneyForHolyday - discond * moneyForHolyday;
                        if (kindOfPoint == "positive")
                        {
                            discond = discond + 0.25;
                            Console.WriteLine($"{discond * 25*daysOfrest:f2}");
                            Console.WriteLine(discond);
                        }
                        else
                        {
                            discond = discond + 0.1;
                            Console.WriteLine($"{discond * 25*daysOfrest:f2}");
                        }
                        break;
                    case "president apartment":
                        discond = 0.15;
                        moneyForHolyday = moneyForHolyday - discond * moneyForHolyday;
                        if (kindOfPoint == "positive")
                        {
                            discond = discond + 0.25;
                            Console.WriteLine($"{discond * 35*daysOfrest:f2}");
                        }
                        else
                        {
                            discond = discond + 0.1;
                            Console.WriteLine($"{discond * 35*daysOfrest:f2}");
                        }
                        break;

                    default:
                        break;
                }
            }
            else
            {
                switch (typeOfRooms)
                {
                    case "room for one person":
                        discond = 0.00;
                        moneyForHolyday = moneyForHolyday - discond * moneyForHolyday;
                        if (kindOfPoint == "positive")
                        {
                            discond = discond + 0.25;

                            Console.WriteLine($"{discond * 18*daysOfrest:f2}");
                        }
                        else
                        {
                            discond = discond + 0.1;
                            Console.WriteLine($"{discond * 18*daysOfrest:f2}");
                        }
                        break;
                    case "apartment":
                        discond = 0.5;
                        moneyForHolyday = moneyForHolyday - discond * moneyForHolyday;
                        if (kindOfPoint == "positive")
                        {
                            discond = discond + 0.25;
                            Console.WriteLine($"{discond * 25*daysOfrest:f2}");
                        }
                        else
                        {
                            discond = discond + 0.1;
                            Console.WriteLine($"{discond * 25*daysOfrest:f2}");
                        }
                        break;
                    case "president apartment":
                        discond = 0.2;
                        moneyForHolyday = moneyForHolyday - discond * moneyForHolyday;
                        if (kindOfPoint == "positive")
                        {
                            discond = discond + 0.25;
                            Console.WriteLine($"{discond * 35*daysOfrest:f2}");
                        }
                        else
                        {
                            discond = discond + 0.1;
                            Console.WriteLine($"{discond * 35*daysOfrest:f2}");
                        }
                        break;

                    default:
                        break;
                }
            }





        }
    }
}
