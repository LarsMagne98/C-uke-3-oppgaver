public class ArtifactCatalog
{
    private List<Artifact> artifacts = new List<Artifact>();

    public void Add(Artifact artifact)
    {
        artifacts.Add(artifact);
    }

    public void PrintAll()
    {
        foreach (var artifact in artifacts)
        {
            Console.WriteLine($"{artifact.Name}, {artifact.Origin}");
        }
    }

    public Artifact? FindByName(string name)
    {
        foreach (var item in artifacts)
        {
            if (item.Name == name)
            {
                return item;
            }
        }
        return null;
    }
}
