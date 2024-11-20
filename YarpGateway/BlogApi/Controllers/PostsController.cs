using BlogApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PostsController : ControllerBase
    {
        private readonly ILogger<PostsController> _logger;

        public PostsController(ILogger<PostsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Post> Get()
        {
            var posts = new List<Post>();
            posts.AddRange(new Post[]
            {
                new Post(1, "Introduction to C#", "C# is a modern, object-oriented programming language developed by Microsoft.", new[] { "C#", "Programming", "Introduction" }),
                new Post(2, "Understanding LINQ", "LINQ is a powerful query language in .NET for working with data collections.", new[] { "LINQ", "Data", "C#" }),
                new Post(3, "ASP.NET Core Basics", "Learn the fundamentals of building web applications using ASP.NET Core.", new[] { "ASP.NET Core", "Web Development", "Basics" }),
                new Post(4, "Working with Entity Framework", "Entity Framework is a popular ORM for .NET applications.", new[] { "Entity Framework", "ORM", "Databases" }),
                new Post(5, "Exploring SignalR", "SignalR is a library for adding real-time web functionality to apps.", new[] { "SignalR", "Real-Time", "Web" }),
                new Post(6, "Dependency Injection in C#", "Dependency Injection is a key feature of ASP.NET Core for managing dependencies.", new[] { "Dependency Injection", "C#", "ASP.NET Core" }),
                new Post(7, "Understanding async/await", "Async programming in C# helps improve application responsiveness.", new[] { "Async", "Await", "C#" }),
                new Post(8, "Working with JSON in .NET", "Learn how to serialize and deserialize JSON in .NET applications.", new[] { "JSON", "Serialization", "C#" }),
                new Post(9, "Building Microservices with Ocelot", "Ocelot is a .NET API Gateway that helps build microservices architectures.", new[] { "Ocelot", "Microservices", "API Gateway" }),
                new Post(10, "Getting Started with Blazor", "Blazor allows building interactive web UIs using C#.", new[] { "Blazor", "Web", "UI" })
            });

            return posts;
        }
    }
}
