using Microsoft.AspNetCore.Mvc;
using Tutorial8.Services;


namespace Tutorial8.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly DbTestService _dbTestService;

        public TestController(DbTestService dbTestService)
        {
            _dbTestService = dbTestService;
        }

        [HttpGet("ping-db")]
        public IActionResult PingDb()
        {
            return _dbTestService.TestConnection()
                ? Ok("Połączenie z bazą danych działa!")
                : StatusCode(500, "Nie udało się połączyć z bazą danych.");
        }
    }

}