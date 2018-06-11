using System;

namespace Phone
{
    public class Galaxy : Phone, IRingable 
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            return "*Generic Elevator Music Plays....*";
        }
        
        public string Unlock() 
        {
            return "*Clic-clack!*";
        }
        public override void DisplayInfo() 
        {
            // your code here            
        }
    }
}