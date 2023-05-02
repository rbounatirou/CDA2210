using CerealApi.Db;
using CerealApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CerealApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CerealsController : ControllerBase
    {
        CerealDbContext context;

        public CerealsController() : base()
        {
            context = new CerealDbContext();
            
        }

        // GET: api/<CerealsController>
        [HttpGet]
        public IEnumerable<Cereal> Get() => context.Cereals.ToList();


        // GET api/<CerealsController>/5
        [HttpGet("{id}")]
        public Cereal Get(int id) => context.Cereals.Find(id);

        // POST api/<CerealsController>
        [HttpPost]
        public void Post([FromBody] Cereal value)
        {
            context.Cereals.Add(value);
            context.SaveChanges();
        }

        // PUT api/<CerealsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cereal value)
        {
            Cereal get = Get(id);
            
            if (get != null)
            {
                get.Name = value.Name;
                get.Protein = value.Protein;
                get.Calories = value.Calories;
                context.Cereals.Update(get);
                context.SaveChanges();
            }
        }

        // DELETE api/<CerealsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Cereal get = Get(id);
            if (get != null)
            {
                context.Cereals.Remove(get);
                context.SaveChanges();
            }
        }
    }
}
