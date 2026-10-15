// Overloading metoder. c# velger riktig metode ut fra hvor mange argumenter som blir tildelt.
class Program
{
    static void Main(string[] args)
    {
        PrintTransmission("Calibration complete");
        PrintTransmission("Relay-7", "Signal acquired");
    }


    static void PrintTransmission(string message)
    {
        // TODO
        Console.WriteLine($"[UNKNOWN] {message}");
    }

    static void PrintTransmission(string sender, string message)
    {
        // TODO
        Console.WriteLine($"[{sender}] {message}");
    }
}

// Funket ikke uten å ha class Program og static void Main.
// Ferdig.