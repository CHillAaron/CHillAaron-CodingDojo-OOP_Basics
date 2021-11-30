using System;
using Human.Models;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Wizard1 = new Wizard("Gandalf");
            Ninja Ninja1 = new Ninja("Denede");
            Samurai Samurai1 = new Samurai("Axor");
            Console.WriteLine($"{Wizard1.Name} attacked {Ninja1.Name} and {Ninja1.Name} has {Wizard1.Attack(Ninja1)} left");
            Console.WriteLine($"{Ninja1.Name} attacked {Samurai1.Name} and {Samurai1.Name} has {Ninja1.Attack(Samurai1)} left");
            Console.WriteLine(Samurai1.Meditate());
            Console.WriteLine($"{Samurai1.Name} has {Samurai1.health} remaining");
        }
    }

}
