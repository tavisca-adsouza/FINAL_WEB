using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hello : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "Hi";
        }


    }
}
