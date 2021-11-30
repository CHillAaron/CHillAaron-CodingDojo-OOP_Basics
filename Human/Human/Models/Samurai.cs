using System;
using System.Collections.Generic;
using System.Text;

namespace Human.Models
{
    class Samurai : Person
    {
        public Samurai(string name) : base(name)
        {
            max_health = 200;
            health = 200;
            
        }
        public override int Attack(Person target)
        {
            //Add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
            Console.WriteLine($"{this.Name} is attacking {target.Name}");
            target.health = target.health - (this.strength * 5);
            if(target.health < 50)
            {
                target.health = 0;
            }
            if(target.health <= 0)
            {
                Console.WriteLine($"{target.Name} has been defeated!");
                target.health = 0;
            }
            return target.health;
        }
        public int Meditate()
        {
            Console.WriteLine($"{this.Name} is at full health now");
            this.health = this.max_health;
            return this.health;
        }
    }
}
