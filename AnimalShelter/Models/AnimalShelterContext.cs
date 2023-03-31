// using System;
// using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    // in tutorial: public DbSet<Planet>? Planets { get; set; }

    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {
    
    }




    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Breed = "Cat", Name = "Muffin", Age = 3, FunFact = "Naps a lot. Loves staring at birds. Speaks English"},
          
        //   new Planet { PlanetId = 2, Name = "Venus", FunFact = "Venus has no moons. A block of lead on Venus will melt like a block of ice would on Earth.", Climate = "Is around 900F. Even spacecraft cannot withstand the atmosphere for long.", LifeFormDetails = "Zorthraxians, gelatinous cubes, 4 legs, 6 feet in size, 12 hearts, very angry all the time", Population = 12},
          
        //   new Planet { PlanetId = 3, Name = "Mars", FunFact = "Mars has two moons. Mars has frozen water and is seismically active. It has the hightest mountain in our solar system.", Climate = "Mars's atmosphere is primarily formed of carbon dioxide. Temperatures range from -220F to 70F, with an average temperature of -81F. Mars has seasons that cause its frozen water and carbon dioxide caps to shrink and grow.", LifeFormDetails = "Blarbs, Candy bars with delicious nougat centers, on one 20 foot wheel with spinner rims", Population = 10000},
          
        //   new Planet { PlanetId = 4, Name = "Saturn", FunFact = "Saturn could float in water due to it's gaseous nature. It has 82 moons.", Climate = "Extremely windy with averages temperatures hovering around -285F.", LifeFormDetails = "Recklins, flying recliner-chair like creatures, roughly the size of blue-whales", Population = 5000000},
          
        //   new Planet { PlanetId = 5, Name = "Pluto", FunFact = "It is a dwarf planet, it's half the size of the US.", Climate = "Average temperature is -387F, thin atmosphere made of nitrogen, methane and carbone monoxide", LifeFormDetails = "Plutonians, holograms, exact replicas of Pluto from Disney, loves holograms of earth pizza", Population = 9999999}
        // );
    }
  }
}