using System;

namespace Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle firstCar = new Vehicle(5, "blue");

            Console.WriteLine(firstCar.MaxNumPassengers);
        }
        class Vehicle
        {
            private int maxNumPassengers;
            private string color;
            public int MaxNumPassengers
            {
                get { return maxNumPassengers; }
            }
            public string Color
            {
                get { return color; }
            }
            public Vehicle(int maxPass, string col)
            {
                maxNumPassengers = maxPass;
                color = col;
            }
        }
    }
}
