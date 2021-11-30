using System;
using System.Collections.Generic;
using System.Text;

namespace Human.Models
{
    class Ninja : Person
    {
        public Ninja(string name) : base(name)
        {
            dexterity = 25;
        }

        public override int Attack(Person target)
            {
                //Add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
                Random rnd = new Random();
                bool critical = rnd.Next(100) <= 20 ? true : false;
                Console.WriteLine($"{this.Name} is attacking {target.Name}");
                if (critical == true)
                {
                    target.health = target.health - ((this.dexterity * 5) + 10);
            }
            else
            {
                target.health = target.health - (this.dexterity * 5);
            }
            if (target.health <= 0)
            {
                Console.WriteLine($"{target.Name} has been defeated!");
                target.health = 0;
            }
            return target.health;
        }

        public int steal(Person target)
        {
            int healing = 5;
            Console.WriteLine($"{ this.Name} has stole {healing} from {target.Name}");
            target.health -= healing;
            this.health += healing;
            if (target.health <= 0)
            {
                Console.WriteLine($"{target.Name} has been defeated!");
                target.health = 0;
            }
            return target.health;
        }
    }
}
