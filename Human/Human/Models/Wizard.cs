using System;
using System.Collections.Generic;
using System.Text;

namespace Human.Models
{
    class Wizard : Person
    {
        public Wizard(string name) : base(name)
        {
            health = 50;
            intelligence = 5;  
        }

        //Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
        public override int Attack(Person target)
        {
            //Add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
            Console.WriteLine($"{this.Name} is attacking {target.Name}");
            target.health = target.health - (this.intelligence * 5);
            this.health = this.health +  (this.intelligence * 5);
            if (target.health <= 0)
            {
                Console.WriteLine($"{target.Name} has been defeated!");
                target.health = 0;
            }
            return target.health;
        }
        public int Heal(Person target)
        {
            int healing = this.intelligence * 10;
            Console.WriteLine($"{ this.Name} has healed {target.Name} for {healing}");
            target.health = healing;
            return target.health;
        }
    }
}
