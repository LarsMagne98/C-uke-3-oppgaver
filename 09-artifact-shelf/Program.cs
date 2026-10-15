List<Artifact> artifacts = new List<Artifact>()
{
    new Artifact("Hope Diamond", "India", 10),
    new Artifact("Ark of the Covenant", "Ancient Israel", 9),
    new Artifact("Tutankhamun's Tomb Artifacts", "Ancient Egypt", 6),
    new Artifact("Koh-i-Noor Diamond", "India", 8)
};

Console.WriteLine($"There are {artifacts.Count} artifacts in the list");

Console.WriteLine($"| {"ARTIFACT'S NAME:",-30} | {"ORIGIN:",-20} | {"RISK:",5} |");

foreach (var artifact in artifacts)
{
    Console.WriteLine($"| {artifact.Name,-30} | {artifact.Origin,-20} | {artifact.Risk,5} |");
}


// Skjønte ikke om dere vil ha denne linjen her nede eller før linje 9.
// Her nede blir den ikke med i listen før etter at listen og .Count 
// er skrevet ut i konsollen.
artifacts.Add(new Artifact("Dybbuk Box", "Spain", 3));

Console.WriteLine($"There are {artifacts.Count} artifacts in the list");

// Ferdig.