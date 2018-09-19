using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InterfacesHW
{
    public class Worker : IWorker
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public int Age { get; set; }

        public void AddBasement(House house,Basement basement)
        {
            if (house.BasementAmount == 0)
                house.BasementAmount++;
            else
                WriteLine("Нельзя добавлять больше одного фундамента!");
        }

        public void AddWalls(House house,Walls walls)
        {
            if (house.BasementAmount == 1 && house.WallsAmount < 4)
                house.WallsAmount++;
            else
                WriteLine("Нет фундамента или слишком много стен!");
        }

        public void AddDoor(House house,Door door)
        {
            if (house.BasementAmount == 1 && 
                house.WallsAmount == 4)
                house.DoorAmount++;
            else
                WriteLine("Недостаточно стен!");
        }

        public void AddWindows(House house, Window window)
        {
            if (house.BasementAmount == 1 && 
                house.WallsAmount == 4 && 
                house.DoorAmount == 1 &&
                house.WindowAmount < 4)
                house.WindowAmount++;
            else
                WriteLine("Нет двери или слишком много окон!");
        }

        public void AddRoof(House house,Roof roof)
        {
            if (house.BasementAmount == 1 &&
               house.WallsAmount == 4 &&
               house.DoorAmount == 1 &&
               house.WindowAmount == 4)
                house.RoofAmount++;
            else
                WriteLine("Недостаточно окон!");
        }

        public void Check(House house)
        {
            if (house.BasementAmount == 1 &&
              house.WallsAmount == 4 &&
              house.DoorAmount == 1 &&
              house.WindowAmount == 4 &&
                house.RoofAmount == 1)
                WriteLine("Дом Успешно построен!");
            else
            {
                WriteLine("Недостаточно частей для постройки дома!");
                WriteLine("Для строительства дома нужно:");
                WriteLine("1 - Фундамент");
                WriteLine("4 - Стены");
                WriteLine("1 - Дверь");
                WriteLine("4 - Окна");
                WriteLine("1 - Крыша");
            }
        }
    }
}
