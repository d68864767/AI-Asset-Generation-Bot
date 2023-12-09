using System;
using System.Collections.Generic;

public class AssetGenerator
{
    public static Asset GenerateAssets(string assetType, Dictionary<string, string> attributes)
    {
        switch (assetType)
        {
            case "Character":
                return new Character(attributes);
            case "Environment":
                return new Environment(attributes);
            case "Object":
                return new Object(attributes);
            default:
                throw new ArgumentException($"Invalid asset type: {assetType}");
        }
    }
}
