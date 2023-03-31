// using System.Linq;
// using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    //pagination goes here

    [HttpGet]
    public async Task<List<Animal>> Get(string breed, string name, int age, int minimumAge, string funFact)
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();

      if(breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      if(name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if(age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if (minimumAge > 0)
      {
        query = query.Where(entry => entry.Age >= minimumAge);
      }

      if(funFact != null)
      {
        query = query.Where(entry => entry.FunFact == funFact);
      }

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return animal;
    }

    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }


  }
}