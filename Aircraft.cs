using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Quest2
{
    // Shani Maroz
    // 211579263

    // The base class
    internal class Aircraft
    {
        public int altitude;
        public string flightNumber;


        // Initialize flight altitude and number
        public Aircraft(int altitude, string flightNumber)
        {
            this.altitude = altitude;
            this.flightNumber = flightNumber;
        }


        // Virtual method to print flight status
        // allowing for overriding
        public virtual void PrintStatus()
        {
            Console.WriteLine($" The flight altitude is {altitude}, The flight number is {flightNumber}");
        }
    }
}
