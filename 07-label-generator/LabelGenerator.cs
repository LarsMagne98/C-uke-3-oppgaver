public class LabelGenerator
{
    public string CreateLabel(string rawText)
    {
        return Normalize(rawText);
    }

    private string Normalize(string rawText)
    {
        return $"LABEL: {rawText.Trim().ToUpper()}";
    }
}
