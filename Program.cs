namespace Task3Quest2
{
    internal class Program
    {
        // Shani Maroz
        // 211579263

        static void Main(string[] args)
        {
            // Array of the base class
            Aircraft[] aircrafts = new Aircraft[4];

            // Initialize the array (PassengerPlane and FlighterJet objects)
            aircrafts[0] = new PassengerPlane(1111, "3232556", 300);
            aircrafts[1] = new PassengerPlane(1122, "2154254", 600);
            aircrafts[2] = new FlighterJet(50000, "656599", true);
            aircrafts[3] = new FlighterJet(20000, "545585", true);

            // Print the status of each aircraft
            for (int i = 0; i < aircrafts.Length; i++)
            {
                aircrafts[i].PrintStatus();

                // Only if the aircraft is of type FlighterJet
                if (aircrafts[i] is FlighterJet)
                {
                    // Cast the object to FlighterJet
                    ((FlighterJet)aircrafts[i]).FireMissile();
                }
            }
        }
    }
}
