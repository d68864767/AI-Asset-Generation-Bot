using System.Collections.Generic;

public class Character : Asset
{
    public Character(Dictionary<string, string> attributes) : base("Character", attributes)
    {
        if (!attributes.ContainsKey("name") || !attributes.ContainsKey("age") || !attributes.ContainsKey("race") || !attributes.ContainsKey("class") || !attributes.ContainsKey("strength") || !attributes.ContainsKey("intelligence") || !attributes.ContainsKey("charisma"))
        {
            throw new ArgumentException("Invalid attributes for Character asset");
        }
    }
}
