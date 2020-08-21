using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StarterApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtilityController : ControllerBase
    {
        public UtilityController()
        {
        }

        [HttpGet]
        [Route("/test")]
        public string GetTest()
        {
            return "Success";
        }
    }
}
