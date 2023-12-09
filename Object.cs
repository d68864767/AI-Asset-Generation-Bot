using System;
using System.Collections.Generic;

public class Object : Asset
{
    private static readonly List<string> validAttributes = new List<string> { "type", "material", "weight", "value" };

    public Object(Dictionary<string, string> attributes) : base("Object", attributes)
    {
        ValidateAttributes();
    }

    private void ValidateAttributes()
    {
        foreach (string key in Attributes.Keys)
        {
            if (!validAttributes.Contains(key))
            {
                throw new ArgumentException($"Invalid attribute for Object: {key}");
            }
        }
    }
}
