using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a fun Mad Lib game that takes user input to create a story!
      Author: Sylvia Castro
      */

      // Let the user know that the program is starting:
      string startGame = "Your game is starting!";
      Console.WriteLine(startGame);
      
      // Give the Mad Lib a title:
      string title = "Mad Libs Crazy";
      Console.WriteLine(title);
      
      // Define user input and variables:
      Console.Write("What is your name?? ");
      string name = Console.ReadLine();
        
      Console.Write("Enter your first adjective: ");
      string firstAdjective = Console.ReadLine();
      
      Console.Write("Enter a second adjective: ");
      string secondAdjective = Console.ReadLine();
      
      Console.Write("Enter a third adjective: ");
      string thirdAdjective = Console.ReadLine();
      
      Console.Write("Enter a verb: ");
      string verb = Console.ReadLine();

      Console.Write("Enter your first noun: ");
      string firstNoun = Console.ReadLine();
      
      Console.Write("Enter your second noun: ");
      string secondNoun = Console.ReadLine();
      
      Console.Write("Here is where the story gets fun and weird. \n");
      
      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine();
      
      Console.Write("Enter a food: ");
      string food = Console.ReadLine();
      
      Console.Write("Enter a fruit: ");
      string fruit = Console.ReadLine();
      
      Console.Write("Enter a superhero: ");
      string superhero = Console.ReadLine();
      
      Console.Write("Enter a country: ");
      string country = Console.ReadLine();
      
      Console.Write("Enter a deseert: ");
      string dessert = Console.ReadLine();
      
      Console.Write("Enter a year: ");
      string year = Console.ReadLine();
         
      // The template for the story:

      string story = $"This morning {name} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdjective}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}
