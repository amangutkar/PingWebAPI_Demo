using Microsoft.AspNetCore.Mvc;

namespace PingWebAPI.Controller
{
    //[HttpGet]
    //[Route("api/[controller]")]
    //[ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        [Route("api/ping")]
        public ActionResult Ping()
        {
            return Ok("Pong..!!");
        }
    }
}