using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Example usage of the AssetGenerator
            Dictionary<string, string> characterAttributes = new Dictionary<string, string>
            {
                { "name", "John" },
                { "age", "30" },
                { "race", "Human" },
                { "class", "Warrior" },
                { "strength", "10" },
                { "intelligence", "8" },
                { "charisma", "7" }
            };

            Asset character = AssetGenerator.GenerateAssets("Character", characterAttributes);
            Console.WriteLine(character.ToString());

            // Add more examples as needed
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
