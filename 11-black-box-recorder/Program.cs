
using System.Text;

string path = "blackbox.txt";

// Den opprettes bare hvis den ikke eksisterer.
// Så den vil alltid eksistere etter første dotnet run,
// med mindre noen sletter den selvfølgelig.
if (!File.Exists(path))
{
    string[] createText = { "Hello", "And", "Welcome" };
    File.WriteAllLines(path, createText, Encoding.UTF8);
}

string[] readText = File.ReadAllLines(path, Encoding.UTF8);

foreach (var line in readText)
{
    Console.WriteLine(line);
}

// Ferdig