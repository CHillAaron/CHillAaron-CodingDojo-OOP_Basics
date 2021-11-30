using System;
using IronNinja.Interface;
using System.Collections.Generic;
using System.Text;

namespace IronNinja.Models
{
    class SpiceHound : Ninja
    {
        public override bool IsFull
        {
            //Provide override for isFull (Full at 1200 Calories
            get
            {

                if (calorieIntake >= 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override void Consume(IConsumable item)
        {
            if (IsFull == true)
            {
                Console.WriteLine($"The SpiceHound is is satisfied.");
            }
            else
            {
                //adds calorie value to SweetTooth's total calorieIntake (+10 additional calories if the consumable item is "Sweet")
                if (item.IsSpicy == true)
                {
                    this.calorieIntake = this.calorieIntake + item.Calories - 5;
                }
                else
                {
                    this.calorieIntake = this.calorieIntake + item.Calories;
                }
                //adds the randomly selected IConsumable object to SpiceHound's Consumption History list
                this.ConsumptionHistory.Add(item);
                //calls the IConsumable object's GetInfo() method
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}
