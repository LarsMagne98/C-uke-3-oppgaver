public class Beacon
{
    // Frequency kan ikke være static da den oppretter en ny verdi i memory hver gang
    // et nytt objekt blir laget, og holder på de alle.
    // Static holder bare på én verdi.
    public int Frequency { get; set; }
    public static int CreatedCount { get; private set; }

    public Beacon(int frequency)
    {
        Frequency = frequency;
        CreatedCount++;
    }
}
