using System;
using System.Collections.Generic;
using System.Linq;

public class Animal
{
    public Species Species { get; set; }

    public Animal(Species species)
    {
        Species = species;
    }
}

public class Species
{

    public string Name { get; set; }


    public Species(string name)
    {
        Name = name;
    }
}

public class Program
{
    public static void Main()
    {
  
        Species whiteCougar = new Species("Cougars blancs");
        Species whiteTiger = new Species("Tigres blancs");
        Species albinoTurtle = new Species("Tortues albinos");

  
        List<Animal> animals = new List<Animal>
        {
           
          
            new Animal(whiteCougar), new Animal(whiteCougar), new Animal(whiteCougar),
            new Animal(whiteTiger), new Animal(whiteTiger), new Animal(whiteTiger), new Animal(whiteTiger), new Animal(whiteTiger),
            new Animal(whiteTiger), new Animal(whiteTiger), new Animal(whiteTiger), new Animal(whiteTiger), new Animal(whiteTiger),

            new Animal(albinoTurtle), new Animal(albinoTurtle), new Animal(albinoTurtle), new Animal(albinoTurtle), new Animal(albinoTurtle),
            new Animal(albinoTurtle), new Animal(albinoTurtle), new Animal(albinoTurtle), new Animal(albinoTurtle), new Animal(albinoTurtle),
            new Animal(albinoTurtle), new Animal(albinoTurtle), new Animal(albinoTurtle), new Animal(albinoTurtle), new Animal(albinoTurtle)
            
            };


        var speciesCounts = animals.GroupBy(a => a.Species)
                                   .Select(g => new { Species = g.Key.Name, Count = g.Count() });


        foreach (var speciesCount in speciesCounts)
        {
            Console.WriteLine($"Espèce: {speciesCount.Species}, Nombre d'animaux recensés: {speciesCount.Count}");
        }
    }
}
