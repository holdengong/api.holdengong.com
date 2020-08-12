using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;

namespace api.holdengong.com.Controllers
{
    [ApiController]
    public class GitSubscriberController : ControllerBase
    {
        [Route("api/blog/gitsubscriber")]
        [HttpPost]
        public IActionResult GitSubscriber([FromBody]object request)
        {
            Process.Start("/scripts/blog.sh");
            return Ok();
        }

        [HttpPost("api/callback")]
        public IActionResult CallbackAsync([FromBody]object request)
        {
            string json = JsonConvert.SerializeObject(request);
            string path = Path.Combine(Environment.CurrentDirectory, "callback.json");
            System.IO.File.WriteAllText(path, json);

            return Ok();
        }
    }
}
