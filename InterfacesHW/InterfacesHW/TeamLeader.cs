using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace InterfacesHW
{
    public class TeamLeader : IWorker
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public int Age { get; set; }

        public void Report(House house)
        {
            WriteLine("Фундамент - " + house.BasementAmount);
            WriteLine("Стены - " + house.WallsAmount);
            WriteLine("Двери - " + house.DoorAmount);
            WriteLine("Окна - " + house.WindowAmount);
            WriteLine("Крыша - " + house.RoofAmount);
            if (house.BasementAmount == 1 &&
                house.DoorAmount == 1 &&
                house.WindowAmount == 4 &&
                house.WallsAmount == 4 &&
                house.RoofAmount == 1)
                WriteLine("Дом достроен!");
        }
    }
}
