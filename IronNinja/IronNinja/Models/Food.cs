using IronNinja.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace IronNinja.Models
{
    //class Food
    //{
    //    public string Name;
    //    public int Calories;
    //    // Foods can be Spicy and/or Sweet
    //    public bool IsSpicy;
    //    public bool IsSweet;
    //    // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
    //    public Food(string name, int cal, bool isSpicy, bool isSweet)
    //    {
    //        Name = name;
    //        Calories = cal;
    //        IsSpicy = isSpicy;
    //        IsSweet = isSweet;
    //    }
    //}
    class Food : IConsumable
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }
        public string GetInfo()
        {
            return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        public Food(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}
