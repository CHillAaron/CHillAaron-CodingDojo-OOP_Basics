using System;
using System.Collections.Generic;
using System.Text;
using IronNinja.Interface;

namespace IronNinja.Models
{
    class Buffett
    {
        public List<IConsumable> Menu;


        //constructor
        public Buffett()
        {
            //Menu = new List<Food>()
            Menu = new List<IConsumable>
            {
                
                new Food("Chicken", 1000, true, true),
                new Food("Ramen", 500, true,false),
                new Food("Burger", 1500, false, false),
                new Food("Pizza", 1200, false,false),
                new Food("Chocolate", 500, false,true),
                new Food("Ice Cream", 250, false,true),
                new Drink("Wine", 200, false),
                new Drink("Water", 10, false),
                new Drink("Fireball", 150, true)
            };
        
        }

        public IConsumable Serve()
        {
            Random rnd = new Random();
            int menuIndex = rnd.Next(1, Menu.Count);
            return Menu[menuIndex];
        }
    }
}
