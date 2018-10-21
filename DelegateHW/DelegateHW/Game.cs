using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    public class Game
    {
        public List<Car> Cars = new List<Car>();

        public Game(List<Car> cars,double trackLength)
        {
            Cars = cars;

            foreach (var car in Cars)
                car.SetTrackLength(trackLength);
        }

        public void BeginGame()
        {
            if (Cars.Capacity != 0)
            {
                while (true)
                {
                    foreach (var car in Cars)
                    {
                        if (car.GetTrackLength() > 0)
                        {
                            Console.WriteLine($"Машине '{car.Name}' осталось {car.GetTrackLength()} до финиша");
                            car.ToDrive();
                        }
                        else
                        {
                            Console.WriteLine($"Машине '{car.Name}' осталось {car.GetTrackLength()} до финиша");
                            car.ToDrive();
                            return;
                        }
                    }
                    Console.ReadLine();
                }
            }
            else
                Console.WriteLine("Нет машин для участия в гонке!");
        }

    }
}
