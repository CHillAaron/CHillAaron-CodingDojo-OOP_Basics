using System;
using HungryNinja.Model;
using HungryNinja.Models;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffett buffett1 = new Buffett();
            Ninja Ninja1 = new Ninja();
            Ninja1.Eat(buffett1.Serve());
            Ninja1.Eat(buffett1.Serve());
            Ninja1.Eat(buffett1.Serve());
            Ninja1.Eat(buffett1.Serve());
        }
    }
}
