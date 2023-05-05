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
        private Repository<Cereal> repository;

        public CerealsController() : base()
        {
            repository = new Repository<Cereal>(new CerealDbContext());

        }

        // GET: api/<CerealsController>
        [HttpGet]
        public IEnumerable<Cereal> Get() => repository.Get();


        // GET api/<CerealsController>/5
        [HttpGet("{id}")]
        public Cereal? Get(int id) => repository.Get(id);

        // POST api/<CerealsController>
        [HttpPost]
        public void Post([FromBody] Cereal value) => repository.Post(value);

        // PUT api/<CerealsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cereal value) => repository.Put(id, value);

        // DELETE api/<CerealsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) => repository.Delete(id);

        
    }
}
