using System;
using IronNinja.Models;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffett buffett1 = new Buffett();
            SweetTooth sweet1 = new SweetTooth();
            SpiceHound spice1 = new SpiceHound();
            int sweet = 0;
            int spice = 0;
            while(sweet < 1)
            {
                sweet1.Consume(buffett1.Serve());
                if(sweet1.IsFull == true)
                {
                    sweet1.Consume(buffett1.Serve());
                    sweet++;
                }
            };
            while (spice < 1)
            {
                spice1.Consume(buffett1.Serve());
                if (spice1.IsFull == true)
                {
                    spice1.Consume(buffett1.Serve());
                    spice++;
                }
            };
            //Console.WriteLine("this is the count for spice: " + spice1.ConsumptionHistory.Count);
            if (sweet1.ConsumptionHistory.Count > spice1.ConsumptionHistory.Count)
            {
                Console.WriteLine("Sweet1 has consumed more items than spice 1! The count was: " + sweet1.ConsumptionHistory.Count);
            }
            else if (sweet1.ConsumptionHistory.Count < spice1.ConsumptionHistory.Count)
            {
                Console.WriteLine("Spice1 has consumed more items than sweet 1! The count was: " + spice1.ConsumptionHistory.Count);
            }
            else
            {
                Console.Write("Both Spice1 and Sweet1 are tied at: " + spice1.ConsumptionHistory.Count);
            }
        }
    }
}
