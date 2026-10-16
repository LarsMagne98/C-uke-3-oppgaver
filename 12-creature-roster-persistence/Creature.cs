using System.Text;

public class Creature
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Energy { get; set; }

    public Creature(string name, string species, int energy)
    {
        Name = name;
        Species = species;
        Energy = energy;
    }

    public string ToFileLine()
    {
        return $"{Name}|{Species}|{Energy}";
    }

    public static Creature? FromFileLine(string fileLine)
    {
        if (string.IsNullOrWhiteSpace(fileLine))
        {
            return null;
        }

        string[] parts = fileLine.Split('|');

        if (parts.Length < 3)
        {
            return null;
        }

        if (!int.TryParse(parts[2], out int parsedEnergy))
        {
            return null;
        }

        return new Creature(parts[0], parts[1], parsedEnergy);

    }
}
