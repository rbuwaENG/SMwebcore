using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class WelcomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        // Example data fetched from SQL Server
        var data = new
        {
            message = "Hello from .NET API!",
            steps = new[]
            {
                "Step 1: Try it",
                "Step 2: Explore",
                "Step 3: Get a fresh start"
            }
        };

        return Ok(data);
    }
}
