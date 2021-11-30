using System;
using System.Collections.Generic;
using System.Text;
using HungryNinja.Model;

namespace HungryNinja.Models
{
    class Ninja
    {
        private int calorieIntake;
        private bool isFull;
        public List<Food> FoodHistory;

        public bool IsFull { get; set; }
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            isFull = false;
        }
        // add a public "getter" property called "IsFull"
        public string Health { get; }
        // build out the Eat method
        public void Eat(Food item)
        { 
            if(this.calorieIntake > 1200)
            {
                isFull = true;
                Console.WriteLine($"The Ninja is full and cannot eat anymore.");
            }
            else
            {
                this.calorieIntake = this.calorieIntake + item.Calories;
                string spicy = item.IsSpicy ? "spicy and " : "not spicy and ";
                string sweet = item.IsSweet ? "sweet " : "not sweet";
                Console.WriteLine($"The Ninja ate {item.Name}, is {spicy}{sweet}");
            }
        }
    }
}
