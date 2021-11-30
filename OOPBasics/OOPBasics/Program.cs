using System;

namespace OOPBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding a value to the object; then passes it to the constructor
            Vehicle myVehicle = new Vehicle(4);
            Console.WriteLine($"My vehicle is holding {myVehicle.NumPassengers} people");
        }
    }
        //Make sure to include the Vehicle class separate from the Program class
    public class Vehicle
    {
        public int NumPassengers;
        //Accessibility of class members is defaulted to private
        //so we must add the public keyword to anything we
        //want to allow outside access to.

        // this unassigned integer will default to 0
        //Notice the Constructor function doesn't need
        //a return type or the static keyword
        public Vehicle(int val)
        {
            NumPassengers = val;
        }
    }
}

