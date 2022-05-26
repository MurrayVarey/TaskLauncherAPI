using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TaskLauncherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaunchController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"hardcoded"};
        }

        [HttpPost]
        public ActionResult<string> PostTaskRequest()
        {

            return "posted";
        }
    }
}