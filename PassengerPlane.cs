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
    internal class PassengerPlane : Aircraft
    {
        // Unique property for the PassengerPlane class
        int passengersCount;


        // Initializes passenger plane properties and base class
        // Calls the base class constructor
        public PassengerPlane(int altitude, string flightNumber, int passengersCount) : base (altitude, flightNumber)
        {
            this.passengersCount = passengersCount;
        }


        // Overrides PrintStatus to add unique details
        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($" There are {passengersCount} passengers on the plane");
            Console.WriteLine("");
        }

    }
}
