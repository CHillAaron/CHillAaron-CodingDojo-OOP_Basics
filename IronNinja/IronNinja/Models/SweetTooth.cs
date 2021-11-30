using IronNinja.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace IronNinja.Models
{
    class SweetTooth : Ninja
    {


        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull
        {
            get
            {

                if (calorieIntake >= 1500)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // provide override for Consume
        public override void Consume(IConsumable item)

            {
                if (IsFull == true)
                {
                    Console.WriteLine($"The sweetTooth is is satisfied.");
                }
                else
                {
                //adds calorie value to SweetTooth's total calorieIntake (+10 additional calories if the consumable item is "Sweet")
                if (item.IsSweet == true)
                {
                    this.calorieIntake = item.Calories + 10;
                }
                else
                {
                    this.calorieIntake = this.calorieIntake + item.Calories;
                }
                //adds the randomly selected IConsumable object to SweetTooth's ConsumptionHistory list
                this.ConsumptionHistory.Add(item);
                //calls the IConsumable object's GetInfo() method
                Console.WriteLine(item.GetInfo());
                }
            }
        
    }
}
