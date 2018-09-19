using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace InterfacesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();

            Worker workerOne = new Worker();

            Worker workerTwo = new Worker();

            Worker workerThree = new Worker();

            Worker workerFour = new Worker();

            TeamLeader leader = new TeamLeader();

            House house = new House();

            Basement basement = new Basement();

            Walls wallOne = new Walls();

            Walls wallTwo = new Walls();

            Walls wallThree = new Walls();

            Walls wallFour = new Walls();

            Door door = new Door();

            Window windowOne = new Window();

            Window windowTwo = new Window();

            Window windowThree = new Window();

            Window windowFour = new Window();

            Roof roof = new Roof();

            team.Workers[0] = workerOne;

            team.Workers[1] = workerTwo;

            team.Workers[2] = workerThree;

            team.Workers[3] = workerFour;

            team.TeamLeader = leader;

            WriteLine("Первый строитель добавляет фундамент");
            team.Workers[0].AddBasement(house,basement);
            WriteLine();

            WriteLine("Второй строитель добавляет фундамент");
            team.Workers[1].AddBasement(house,basement);
            WriteLine();

            WriteLine("Второй строитель добавляет первую стену");
            team.Workers[1].AddWalls(house, wallOne);
            WriteLine();

            WriteLine("Второй строитель добавляет вторую стену");
            team.Workers[1].AddWalls(house, wallTwo);
            WriteLine();

            WriteLine("Второй строитель добавляет третью стену");
            team.Workers[1].AddWalls(house, wallThree);
            WriteLine();

            WriteLine("Второй строитель добавляет четвертую стену");
            team.Workers[1].AddWalls(house, wallFour);
            WriteLine();

            WriteLine("Второй строитель добавляет пятую стену");
            team.Workers[1].AddWalls(house, wallOne);
            WriteLine();

            WriteLine("Третий строитель добавляет дверь");
            team.Workers[2].AddDoor(house, door);
            WriteLine();

            WriteLine("Приходит бригадир и делат отчет");
            team.TeamLeader.Report(house);
            WriteLine();

            WriteLine("Четвертый строитель добавляет окна");
            team.Workers[3].AddWindows(house,windowOne);
            team.Workers[3].AddWindows(house,windowTwo);
            team.Workers[3].AddWindows(house,windowThree);
            team.Workers[3].AddWindows(house,windowFour);

            WriteLine("Четвертый строитель добавляет пятое окно");
            team.Workers[3].AddWindows(house, windowFour);
            WriteLine();

            WriteLine("Четвертый строитель добавляет крышу");
            team.Workers[3].AddRoof(house, roof);
            WriteLine();

            WriteLine("Приходит бригадир и делат отчет");
            team.TeamLeader.Report(house);
            WriteLine();

            ReadLine();
        }
    }
}
