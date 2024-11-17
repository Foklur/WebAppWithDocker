
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppWithDocker.models;

namespace WebAppWithDocker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return new List<User>
            {
                new User { Id = 1, Name = "John Doe" },
                new User { Id = 2, Name = "Jane Smith" }
            };
        }
    }
}
