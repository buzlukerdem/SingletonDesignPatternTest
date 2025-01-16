using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SingletonAspNetCoreExample.Services;

namespace SingletonAspNetCoreExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Action1()
        {
            DatabaseServices databaseServices = DatabaseServices.GetDatabase;
            databaseServices.Connection();
            databaseServices.DisConnection();
            return Ok(databaseServices.Count);
        }
        [HttpGet("[action]")]
        public IActionResult Action2()
        {
            DatabaseServices databaseServices = DatabaseServices.GetDatabase;
            databaseServices.Connection();
            databaseServices.DisConnection();
            return Ok(databaseServices.Count);
        }
    }
}
