using Microsoft.AspNetCore.Mvc;

namespace DevHabits.Api.Controllers;

[ApiController]
[Route("[controller]")]
internal sealed class TestController : ControllerBase
{
    [HttpGet]
    public User Get()
    {
        return new User()
        {
            Name = "John Doe",
            Id = 1
        };
    }
}

internal sealed class User
{
    public string Name { get; init; } = string.Empty;
    public int Id { get; init; }
}
