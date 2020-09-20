using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DotnetCoreController : ControllerBase
    {
        [HttpGet]
        public string Test()
        {
            return ("Hi");
        }

        [HttpGet,Route("helloworld")]
        public string Get()
        {
            return ("Hello World from Dotnet Core ");
        }
    }
}
