using Microsoft.AspNetCore.Mvc;
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
            var fileUrl = Path.Combine(Environment.CurrentDirectory, "blog.sh");
            Process.Start(fileUrl);
            return Ok();
        }
    }
}
