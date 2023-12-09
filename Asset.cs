using System.Collections.Generic;

public abstract class Asset
{
    public string AssetType { get; protected set; }
    public Dictionary<string, string> Attributes { get; protected set; }

    protected Asset(string assetType, Dictionary<string, string> attributes)
    {
        AssetType = assetType;
        Attributes = attributes;
    }

    public override string ToString()
    {
        string result = $"Generated {AssetType} Asset:\n";
        foreach (KeyValuePair<string, string> attribute in Attributes)
        {
            result += $"{attribute.Key}: {attribute.Value}\n";
        }
        return result;
    }
}
