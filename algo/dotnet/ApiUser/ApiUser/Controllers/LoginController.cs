using ApiUser.Databases;
using ApiUser.Extensions;
using ApiUser.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public User? Auth(User userToLogin)
        {
            //userToLogin.Password = userToLogin.Password.ToPassword();

            User? userFind =  context.Users.FirstOrDefault(utilisateur => utilisateur.Username == userToLogin.Username);
            
            return userFind.Password.CheckPassword(userToLogin.Password) ? userFind : default;
        }

    }
}
