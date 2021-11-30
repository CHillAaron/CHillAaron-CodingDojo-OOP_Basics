using System;

namespace Class_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Vehicle
    {
        public int MaxNumPassengers;
        public string Color;
        public double MaxSpeed;
        // vehicleObject.MakeNoise("HOOONK!") will invoke this one
        public void MakeNoise(string noise)
        {
            Console.WriteLine(noise);
        }

        // vehicleObject.MakeNoise() will invoke this one
        public void MakeNoise()
        {
            Console.WriteLine("BEEP!");
        }
        public string ColorProp
        {
            get
            {
                // Simply referencing the property will invoke the "getter", such as:
                // Console.WriteLine(vehicleObject.ColorProp);
                // and will return the following:

                return $"This thing is {Color}";
            }
            set
            {
                // Assigning a value to a property, such as:
                // vehicleObject.ColorProp = "Blue";
                // will invoke the "setter", and the "value" keyword will become the assigned value
                // ("Blue" in this example)

                Color = value;
            }
        }
        //his will create a so-called "backing field" for your class, which is known to the compiler but hidden from your source code. Auto-implemented properties are used throughout the ASP web-framework
        public string Name { get; set; }
    }
}
