using System;
using System.Collections.Generic;
using System.Text;

namespace HungryNinja.Model
{
    class Buffett
    {
        public List<Food> Menu;
        

        //constructor
        public Buffett()
        {
            Menu = new List<Food>()
        {
            new Food("Chicken", 1000, true, true),
            new Food("Ramen", 500, true,false),
            new Food("Burger", 1500, false, false),
            new Food("Pizza", 1200, false,false),
            new Food("Chocolate", 500, false,true),
            new Food("Ice Cream", 250, false,true),
        };
        }

        public Food Serve()
        {
            Random rnd = new Random();
            int menuIndex = rnd.Next(1, Menu.Count);
            return Menu[menuIndex];
        }
    }
}
