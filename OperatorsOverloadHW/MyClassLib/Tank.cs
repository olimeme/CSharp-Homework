using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class Tank
    {
        public string Name { get; set; }

        public int Ammunition { get; set; }

        public int Armor { get; set; }

        public int Mobility { get; set; }

        public Tank()
        {
        }

        public Tank(string name,int ammo,int armor,int mobility)
        {
            Name = name;
            Ammunition = ammo;
            Armor = armor;
            Mobility = mobility;
        }

        public static Tank operator *(Tank firstTank, Tank secondTank)
        {
            int firstTankPoints = 0;
            int secondTankPoints = 0;

            if (firstTank.Ammunition > secondTank.Ammunition)
                firstTankPoints++;
            else
                secondTankPoints++;

            if (firstTank.Armor > secondTank.Armor)
                firstTankPoints++;
            else
                secondTankPoints++;

            if (firstTank.Mobility > secondTank.Mobility)
                firstTankPoints++;
            else
                secondTankPoints++;

            if (firstTankPoints > secondTankPoints)
                return firstTank;
            return secondTank;
        }

    }
}
