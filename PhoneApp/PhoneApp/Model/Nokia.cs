using PhoneApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneApp.Model
{
    public class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone)
            : base(versionNumber, batteryPercentage, carrier, ringTone) { }
        public string Ring()
        {
            // your code here
            return "Your Nokia is ringing";
        }
        public string Unlock()
        {
            // your code here
            return "You Nokia has been unlocked with a passcode.";
        }
        public override void DisplayInfo()
        {
            // your code here
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Nokia "+this.VersionNumber);
            Console.WriteLine("Battery Percentage: "+this.BatteryPercentage);
            Console.WriteLine("Carrier: " + this.Carrier);
            Console.WriteLine("Ring Tone: " + this.RingTone);
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$");

        }
    }
}
