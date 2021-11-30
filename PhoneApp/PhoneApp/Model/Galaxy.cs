using PhoneApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneApp.Model
{
    public class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone)
            : base(versionNumber, batteryPercentage, carrier, ringTone) { }
        public string Ring()
        {
            // your code here
            return "Your Galaxy is ringing";
        }
        public string Unlock()
        {
            // your code here
            return "You Galaxy has been unlocked with fingerprint scanner";
        }
        public override void DisplayInfo()
        {
            // your code here            
            Console.WriteLine("####################");
            Console.WriteLine("Galaxy "+this.VersionNumber);
            Console.WriteLine($"Battery Percentage: {this.BatteryPercentage}");
            Console.WriteLine("Carrier: "+this.Carrier);
            Console.WriteLine("Ring Tone: "+this.RingTone);
            Console.WriteLine("####################");
        }
    }
}
