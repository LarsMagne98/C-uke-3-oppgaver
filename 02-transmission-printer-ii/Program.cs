class Program
{
    static void Main(string[] args)
    {
        PrintTransmission("Dock", "Gate unlocked", "1");
        PrintTransmission("Dock", "Gate unlocked");
        PrintTransmission("System ready");
    }


    // TODO: Kall også din tredje overload.

    static void PrintTransmission(string message)
    {
        Console.WriteLine($"[UNKNOWN] {message}");
    }

    static void PrintTransmission(string sender, string message)
    {
        Console.WriteLine($"[{sender}] {message}");
    }

    // TODO: Lag tredje overload.
    static void PrintTransmission(string sender, string message, string priority)
    {
        Console.WriteLine($"{priority}: [{sender}] {message}");
    }

}

// Ferdig.
