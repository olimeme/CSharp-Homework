using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    class Program
    {
        static void Display(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            Car sportCar = new Car(110, "gopnik");

            Car lightCar = new Car(80, "tesla model x");

            Car van = new Car(200, "жоский грузовик");

            Car bus = new Car(50, "№12 маршрутка");

            sportCar.Finished += Display;

            lightCar.Finished += Display;

            van.Finished += Display;

            bus.Finished += Display;

            cars.Add(sportCar);

            cars.Add(lightCar);

            cars.Add(van);

            cars.Add(bus);

            Console.WriteLine("НАЧИНАЕТСЯ ГОНКА!");

            Console.WriteLine();

            Console.WriteLine("ПЕРВЫЙ ,КТО ДОЕЗЖАЕТ ДО ФИНЕШНОЙ ЧЕРТЫ, ПОЛУЧАЕТ АНИМЕ ДЕВОЧКУ!");

            Console.WriteLine();

            Console.WriteLine("УЧАСТНИКИ: ");

            foreach(var car in cars)
            {
                car.PrintCarStats();
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("ДА НАЧНЕТСЯ ГОНКА");

            Game game = new Game(cars,1000);

            game.BeginGame();
  
            Console.ReadLine();
        }
    }
}
