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
  }
}