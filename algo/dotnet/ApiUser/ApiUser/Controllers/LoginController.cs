using ApiUser.Databases;
using ApiUser.Extensions;
using ApiUser.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserContext context;

        public LoginController()
        {
            this.context = new UserContext();

        }

        [HttpPost]
        public async Task<ActionResult<UserReadViewModel?>> Auth(User userToLogin)
        {
            //userToLogin.Password = userToLogin.Password.ToPassword();

            User? userFind = await context.Users.FirstOrDefaultAsync(utilisateur => utilisateur.Username == userToLogin.Username);



            return userFind != null && userFind.Password.CheckPassword(userToLogin.Password) ? new UserReadViewModel() { Id = userFind.Id, Username = userFind.Username } : NotFound();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ChangePassword(int? id, UserUpdatePasswordViewModel user)
        {
            /*if (id != user.Id)
            {
                return BadRequest();
            }*/
            User u = new User() { Id = user.Id, Username = user.Username, Password = user.Password };

            //ActionResult<UserReadViewModel?> re = Auth(u).Result.Value;

            User? userFind = await context.Users.FirstOrDefaultAsync(u => user.Username == u.Username);


            if (userFind == null ||
                user.Password == user.NewPassword ||
                !userFind.Password.CheckPassword(user.Password))
            {
                return NoContent();
            }
            userFind.Password = user.NewPassword.ToPassword();

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                return NotFound();

            }
            return Ok();
        }

        private bool UserExists(int? id)
        {
            return (context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }

    }
}
