using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;
using static System.Console;

namespace OperatorsOverloadHW
{
    class Program
    {
        public static void PrintTankInfo(Tank tank)
        {
            WriteLine("Название танка - " + tank.Name);
            WriteLine("Уровень боекомплекта - " + tank.Ammunition);
            WriteLine("Уровень брони - " + tank.Armor);
            WriteLine("Уровень маневренности - " + tank.Mobility);
            WriteLine();
        }

        public static void Duel(Tank firstTank,Tank secondTank)
        {
            Tank winner = firstTank * secondTank;
            WriteLine("Победитель:");
            PrintTankInfo(winner);
        }

        static void Main(string[] args)
        {
            Random rand = new Random();

            int numberOfTanks = 5;

            int randAmmo;

            int randArmor;

            int randMobility;

            Tank[] TThirtyFour = new Tank[numberOfTanks];

            for (int i = 0; i < TThirtyFour.Length; i++)
            {
                randAmmo = rand.Next(0, 100);

                randArmor = rand.Next(0, 100);

                randMobility = rand.Next(0, 100);

                TThirtyFour[i] = new Tank("T-34",randAmmo,randArmor,randMobility);
            }

            Tank[] Pantera = new Tank[numberOfTanks];

            for (int i = 0; i < Pantera.Length; i++)
            {
                randAmmo = rand.Next(0, 100);

                randArmor = rand.Next(0, 100);

                randMobility = rand.Next(0, 100);

                Pantera[i] = new Tank("Pantera",randAmmo,randArmor,randMobility);
            }

            WriteLine("\t\t\tINTERNATIONAL WOT TOURNAMENT");

            Tank[] Winners = new Tank[numberOfTanks];

            for(int i=0;i<numberOfTanks;i++)
            {
                WriteLine("\t\t\tБОЙ №"+(i+1));
                PrintTankInfo(TThirtyFour[i]);
                PrintTankInfo(Pantera[i]);
                Duel(TThirtyFour[i],Pantera[i]);
                ReadKey();
                ReadLine();
                Clear();
            }

            WriteLine("\t\t\tГосподи какой жестокий бой пипец просто Турнир окончен бб");
            ReadLine();
        }
    }
}
