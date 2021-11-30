using System;
using System.Collections.Generic;
using System.Text;

namespace Human.Models
{
    class Person
    {
        // Fields for Human
        public string Name;
        public int health { get; set; }
        public int  max_health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Person(string name)
        {
            Name = name;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
            max_health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Person(string name, int str, int intel, int dex, int health, int max_health)
        {
            Name = name;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = health;
            max_health = max_health;
        }
        //Build Attack method
        public virtual int Attack(Person target)
        {
            //Add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
            Console.WriteLine($"{this.Name} is attacking {target.Name}");
            target.health = target.health - (this.strength * 5);
            if (target.health <= 0)
            {
                Console.WriteLine($"{target.Name} has been defeated!");
                target.health = 0;
            }
            return target.health;
        }
    }
}
