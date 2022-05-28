using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimeritaAPI.BL.Contracts;
using MiPrimeritaAPI.CORE.DTO;

namespace MiPrimeritaAPI.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserBL userBL {get; set; }

        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }


        [HttpPost("Login")]
        public ActionResult Login(LoginDTO a)
        {
            var lista = userBL.GetUsers();

                foreach (var user in lista)
            {
                if ( a.User == user.Username && a.Password == user.Password)
                return Ok();
            
            }
            return BadRequest();
        }

        [HttpPost("Register")]
        public ActionResult Register(UserDTO a)
        {
            if (userBL.Insert(a))
                return Ok();
            return BadRequest();
        }

    }
}
