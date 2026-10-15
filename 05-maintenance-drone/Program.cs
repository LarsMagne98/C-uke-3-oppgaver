// opretter objekter og "bekriver" verdiene.
Drone alpha = new Drone("Alpha", 40);
Drone beta = new Drone("Beta", 115);
Drone gamma = new Drone("Gamma", 100);

// Legger objektene i en array
Drone[] drones = { alpha, beta, gamma };

// Skriver ut i konsollen hver drone i arrayet av objektene.
// bruker instance metodene .Describe() og .NeedService()
foreach (Drone drone in drones)
{
    Console.WriteLine(drone.Describe());
    Console.WriteLine($"Needs service: {drone.NeedsService()}");
    Console.WriteLine("-------------------");
}

// Ferdig