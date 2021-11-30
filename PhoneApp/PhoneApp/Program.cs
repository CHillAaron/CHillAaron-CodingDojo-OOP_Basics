using PhoneApp.Model;
using System;

namespace PhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy S8 = new Galaxy("s8", 100, "AT&T", "Dooo do doo dooo");
            Nokia elevenHundred = new Nokia("1100", 60, "Metro PCS", "Ringggg ring rinnngggggg");

            S8.DisplayInfo();
            Console.WriteLine(S8.Ring());
            Console.WriteLine(S8.Unlock());
            Console.WriteLine("");

            elevenHundred.DisplayInfo();
            Console.WriteLine(elevenHundred.Ring());
            Console.WriteLine(elevenHundred.Unlock());
            Console.WriteLine("");
        }
    }
}
