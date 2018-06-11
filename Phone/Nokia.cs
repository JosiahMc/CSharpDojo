using System;

namespace Phone
{
    public class Nokia : Phone, IRingable 
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
            public string Ring() 
            {
                return "***Nokia Ring*** Brrrriiingggg-brrriiinngggg!!!";
            }
            public string Unlock() 
            {
                return "****Nokia Ring*** Wompwompwompwompwoooommmmmmp...*";
            }
            public override void DisplayInfo() 
            {
                // your code here            
            }
    }
}