// Program.cs
using System;
using System.Runtime.ConstrainedExecution;
using NazarovaUlyana.Library;

namespace NazarovaUlyana.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            garage.Name = "Ulyana Garage";
            garage.Address = "Tikhonravova 14";

            Car car1 = new Car { Owner = "Vitali Ivanov", Number = "AA345H" };
            Car car2 = new Car { Owner = "Irina Romanova", Number = "DJ567B" };
            Car car3 = new Car { Owner = "Elena Smirnova", Number = "GR746K" };

            garage.Cars.Add(car1);
            garage.Cars.Add(car2);
            garage.Cars.Add(car3);

            garage.ShowAll();

            Console.WriteLine("\nSorting cars by owner...");
            garage.Cars.Sort();
            garage.ShowAll();

            Console.ReadLine();
        }
    }
}