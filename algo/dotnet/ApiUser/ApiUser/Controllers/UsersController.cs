using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiUser.Databases;
using ApiUser.Models;
using ApiUser.Extensions;

namespace ApiUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext _context;

        public UsersController()
        {
            _context = new UserContext();
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserReadViewModel>>> GetUser()
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            List<UserReadViewModel> list = new();
            await _context.Users.ForEachAsync(u =>
            {
                UserReadViewModel r = new UserReadViewModel() {  Id = u.Id, Username= u.Username};
                list.Add(r);
            });
            return list;
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserReadViewModel>> GetUser(int? id)
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            var user = await _context.Users.FindAsync(id);
            if (user is User userConcrete)
            {
                return new UserReadViewModel() {  Id = userConcrete.Id, Username = userConcrete.Username };
            } else
            {
                return NotFound();
            }           
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int? id, UserUpdateViewModel user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }
            if (_context.Users.FirstOrDefault(u => user.Id == u.Id) is User userInDb)
            {
                userInDb.Username = user.Username;
                _context.Entry(userInDb).State = EntityState.Modified;
            } else
            {
                return NotFound();
            }
            

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
          if (_context.Users == null)
          {
              return Problem("Entity set 'UserContext.User'  is null.");
          }
            user.Password = user.Password.ToPassword();
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int? id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int? id)
        {
            return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
