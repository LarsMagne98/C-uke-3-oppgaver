public class Drone
{
    // Holder verdiene
    public string Name { get; set; }
    public int FlightHours { get; set; }

    // Tar inn og tildeler verdiene.
    public Drone(string name, int flightHours)
    {
        Name = name;
        FlightHours = flightHours;
    }

    // Returnerer verdiene.
    public string Describe()
    {
        return $"Name: {Name}\nFlight hours: {FlightHours}";
    }

    // Returnerer true/false basert på om flighthours er mer eller lik 100.
    public bool NeedsService()
    {
        // TODO
        if (FlightHours >= 100)
        {
            return true;
        }
        return false;
    }
}
