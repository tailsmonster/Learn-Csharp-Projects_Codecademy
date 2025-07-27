using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a little terminal MadLib game
      Author: nico
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Program is now starting...");

      // Give the Mad Lib a title:
      string title = "MadLib Game!";

      Console.WriteLine(title);
      // Define user input and variables:

      Console.Write("Give me a name...");
      string name = Console.ReadLine();
      Console.Write("Give me an adjective...");
      string adjective1 = Console.ReadLine();
      Console.Write("Give me an adjective...");
      string adjective2 = Console.ReadLine();
      Console.Write("Give me an adjective...");
      string adjective3 = Console.ReadLine();
      Console.Write("Give me a verb...");
      string verb = Console.ReadLine();
      Console.Write("Give me a noun...");
      string noun1 = Console.ReadLine();
      Console.Write("Give me a noun...");
      string noun2 = Console.ReadLine();

      Console.Write("Give me an animal...");
      string animal = Console.ReadLine();
      Console.Write("Give me a food...");
      string food = Console.ReadLine();
      Console.Write("Give me a fruit...");
      string fruit = Console.ReadLine();
      Console.Write("Give me a superhero...");
      string superhero = Console.ReadLine();
      Console.Write("Give me a country...");
      string country = Console.ReadLine();
      Console.Write("Give me a dessert...");
      string dessert = Console.ReadLine();
      Console.Write("Give me a year...");
      string year = Console.ReadLine();


      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
