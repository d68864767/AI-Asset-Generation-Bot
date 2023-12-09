using System;
using System.Collections.Generic;

public class Environment : Asset
{
    public Environment(Dictionary<string, string> attributes) : base("Environment", attributes)
    {
        ValidateAttributes();
    }

    private void ValidateAttributes()
    {
        string[] validKeys = { "biome", "weather", "day_or_night", "terrain", "size" };
        foreach (string key in Attributes.Keys)
        {
            if (Array.IndexOf(validKeys, key) == -1)
            {
                throw new ArgumentException($"Invalid attribute: {key}");
            }
        }
    }
}
