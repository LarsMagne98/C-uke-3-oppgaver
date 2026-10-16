using System.Runtime.InteropServices;
using System.Text;

string path = "creatures.txt";

List<Creature> creatures = new List<Creature>
{
    new Creature("Mora", "Lumen Fox", 72),
    new Creature("Kip", "Dust Eel", 18),
    new Creature("Senn", "Cloud Moth", 41),
    new Creature("Gaya", "Bat", 15),
};

// Her går det ikke ann å legge til flere i listen og få de inn i .txt
// med mindre man sletter .txt og så kjører programmet på nytt.
// Men det var ikke det oppgaven spurte om heller :D
if (!File.Exists(path))
{
    foreach (var creature in creatures)
    {
        File.AppendAllText(path, creature.ToFileLine() + Environment.NewLine, Encoding.UTF8);
    }
}

List<Creature> creaturesReturned = new List<Creature> { };

string[] lines = File.ReadAllLines(path);

foreach (var line in lines)
{
    Creature? newCreature = Creature.FromFileLine(line);

    if (newCreature != null)
    {
        creaturesReturned.Add(newCreature);
    }
}

foreach (var item in creaturesReturned)
{
    Console.WriteLine($"{item.Name} | {item.Species} | {item.Energy}");
}

// Ferdig.