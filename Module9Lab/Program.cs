using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Reflection.Emit;

class PokemonLINQLab {

    //Main method - called wwhen the program executes
    static void Main() {
        //Sample data: List of Pokemon 
        var pokemons = new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass", Level = 15},
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire", Level = 36},
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 10},
            new Pokemon { Id = 4, Name = "Pikachu", Type = "Electric", Level = 22},
            new Pokemon { Id = 5, Name = "Eevee", Type = "Normal", Level = 25},
        };

        //LINQ Query to find Pokemon ready to evolve (where level 16 is the level for the first evolution)
        var readyToEvolveQuery = from p in pokemons 
                                 where p.Level >= 16
                                 orderby p.Level
                                 select p;
        //Execute the query and display the results
        Console.WriteLine("Pokemon Ready to Evolve: ");
        foreach (var pokemon in readyToEvolveQuery) {
            Console.WriteLine($"Name: {pokemon.Name}, Type: {pokemon.Type}, Level: {pokemon.Level} ");
        }//end loop
    }//end main method
}//end class


class Pokemon {
    //Attributes for the class
    //Attributes describe the object
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Level { get; set; }
}//end class

