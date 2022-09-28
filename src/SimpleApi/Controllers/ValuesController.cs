using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    



    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return "Max Power";
    }
    
}
