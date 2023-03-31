using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {
    
    }




    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Breed = "Cat", Name = "Muffin", Age = 3, FunFact = "Naps a lot. Loves staring at birds. Speaks English" },
          
          new Animal { AnimalId = 2, Breed = "Cat", Name = "Stinky", Age = 1, FunFact = "Smells like Drakar Noir. Cuddly, Hairless." },
          
          new Animal { AnimalId = 3, Breed = "Cat", Name = "Steve", Age = 40, FunFact = "Actually human, but pretends to be a cat. Could use a nice home, psychiatrist, and medication." },
          
          new Animal { AnimalId = 4, Breed = "Dog", Name = "Zorthrax", Age = 6, FunFact = "Poops chocolate. Know how to code in C#. Allergic to water" },
          
          new Animal { AnimalId = 5, Breed = "Dog", Name = "The Dog Formerly Known as Prince", Age = 2, FunFact = "Sings beautifully. Crows like a rooster. Is a delivery driver for Amazon" },

          new Animal { AnimalId = 6, Breed = "Tiger", Name = "Lion", Age = 1, FunFact = "Previous owner was terrible at animal identification. Gluten-free. Flys" }
        );
    }
  }
}