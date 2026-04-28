using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Quest2
{
    // Shani Maroz
    // 211579263

    // Derived class
    internal class FlighterJet : Aircraft
    {
        // Unique property for the FlighterJet class
        bool missilesLoaded;

        // Initializes FlighterJet properties and base class
        // Calls the base class constructor
        public FlighterJet(int altitude, string flightNumber, bool missilesLoaded) : base(altitude, flightNumber)
        {
            this.missilesLoaded = missilesLoaded;
        }

        // Overrides PrintStatus to add unique details
        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($" Missiles Loaded: {missilesLoaded}");
        }


        // Unique method for FighterJet, in case the aircraft is a FighterJet
        public void FireMissile()
        {
            Console.WriteLine(" Missile Fired!");
            Console.WriteLine("");
            missilesLoaded = false;
        }
    }
}
