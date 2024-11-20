using BlogApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TagsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Tag> Get()
        {
            var tags = new List<Tag>
            {
                new Tag(1, "C#"),
                new Tag(2, "Programming"),
                new Tag(3, "ASP.NET Core"),
                new Tag(4, "Entity Framework"),
                new Tag(5, "LINQ"),
                new Tag(6, "Web Development"),
                new Tag(7, "SignalR"),
                new Tag(8, "Dependency Injection"),
                new Tag(9, "Microservices"),
                new Tag(10, "Blazor"),
                new Tag(11, "JSON"),
                new Tag(12, "Real-Time"),
                new Tag(13, "Basics"),
                new Tag(14, "Introduction"),
                new Tag(15, "API Gateway")
            };

            return tags;
        }
    }
}
