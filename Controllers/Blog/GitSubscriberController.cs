using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
    }
}
