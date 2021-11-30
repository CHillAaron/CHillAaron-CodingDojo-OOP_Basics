using IronNinja.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace IronNinja.Models
{
    //class Ninja
    //{
    //    private int calorieIntake;
    //    private bool isFull;
    //    public List<Food> FoodHistory;

    //    public bool IsFull { get; set; }
    //    // add a constructor
    //    public Ninja()
    //    {
    //        calorieIntake = 0;
    //        isFull = false;
    //    }
    //    // add a public "getter" property called "IsFull"
    //    public string Health { get; }
    //    // build out the Eat method 
    //    public void Eat(Food item)
    //    {
    //        if (this.calorieIntake > 1200)
    //        {
    //            isFull = true;
    //            Console.WriteLine($"The Ninja is full and cannot eat anymore.");
    //        }
    //        else
    //        {
    //            this.calorieIntake = this.calorieIntake + item.Calories;
    //            string spicy = item.IsSpicy ? "spicy and " : "not spicy and ";
    //            string sweet = item.IsSweet ? "sweet " : "not sweet";
    //            Console.WriteLine($"The Ninja ate {item.Name}, is {spicy}{sweet}");
    //        }
    //    }
    //}

    abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;
        public Ninja()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        public abstract bool IsFull { get;  }
        public abstract void Consume(IConsumable item);
    }
}
