using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace TestApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        //controller
        private PeopleContext db = new PeopleContext();

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Object>> Get()
        {
            return db.Animals
                .Include(x=>x.Person)
                .Include(y=>y.AnimalColors).ThenInclude(v=>v.Color)
                .ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Object> Get(int id)
        {
            try
            {
                return db.Animals.First(x=>x.AnimalId == id);
            }
            catch
            {
                return new { message = "no animals match your query" };
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
