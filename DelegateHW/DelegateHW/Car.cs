using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    public delegate void OnFinish(string message);

    public class Car
    {
        public double Speed { get; set; }

        public string Name { get; set; }

        private double TrackLength { get; set; }

        public event OnFinish Finished;

        public Car(double speed, string name)
        {
            Speed = speed;
            Name = name;
        }

        public Car(double speed)
        {
            Speed = speed;
        }

        public Car()
        {

        }

        public void SetTrackLength(double trackLength)
        {
            TrackLength = trackLength;
        }

        public double GetTrackLength()
        {
            return TrackLength;
        }

        public void ToDrive()
        {
            if (TrackLength > 0)
                TrackLength -= Speed;
            else 
                Finished($"Машина '{Name}' доехала до финиша!");
        }

        public void PrintCarStats()
        {
            Console.WriteLine("Название - " + Name);
            Console.WriteLine($"Скорость - {Speed} единиц/проход" );
        }

    }
}
