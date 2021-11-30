using IronNinja.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace IronNinja.Models
{
    class Drink : IConsumable
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }

        // Implement a GetInfo Method
        public string GetInfo()
        {
            return $"{Name} (Drink).  Calories: {Calories}.  This is a Sweet Drink";
        }
        // Add a constructor method
        public Drink(string name, int calories, bool spicy)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = true;
        }
    }
}
