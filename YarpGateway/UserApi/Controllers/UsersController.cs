using Microsoft.AspNetCore.Mvc;
using UserApi.Models;

namespace UserApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            var users = new List<User>();

            users.AddRange(new User[]
            {
                new User(1, "john_doe", "john.doe@example.com", true),
                new User(2, "jane_smith", "jane.smith@example.com", false),
                new User(3, "alice_wonderland", "alice.wonderland@example.com", true),
                new User(4, "bob_builder", "bob.builder@example.com", false),
                new User(5, "charlie_brown", "charlie.brown@example.com", true),
                new User(6, "dave_miller", "dave.miller@example.com", true),
                new User(7, "emily_davis", "emily.davis@example.com", false),
                new User(8, "frank_castle", "frank.castle@example.com", true),
                new User(9, "george_clark", "george.clark@example.com", false),
                new User(10, "hannah_moore", "hannah.moore@example.com", true)
            });

            return users;
        }
    }
}
