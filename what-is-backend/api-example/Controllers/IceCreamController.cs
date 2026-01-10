using Microsoft.AspNetCore.Mvc;

namespace api_example.Controllers;

[ApiController]
[Route("[controller]")]
public class IceCreamController : ControllerBase
{
    [HttpGet(Name = "GetIceCream/{user}")]
    public IceCream Get(string user)
    {
        return new IceCream() { User = user };
    }
}
