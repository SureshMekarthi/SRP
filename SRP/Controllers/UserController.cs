using Microsoft.AspNetCore.Mvc;
using SRP.Business;
using SRP.Models;

namespace SRP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService userService;
        public UserController(IUserService userService)
        { 
            this.userService = userService;
        }

        [HttpGet(Name = "GetName/{id}")]
        public string GetUserDetails(string id)
        {
            return userService.UserDetails(id);
        }


    }
}
