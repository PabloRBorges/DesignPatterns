using Decorator.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Decorator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ICarStore _carStore;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ICarStore carStore, ILogger<HomeController> logger)
        {
            _carStore = carStore;
            _logger = logger;
        }

        [HttpGet("id")]
        public IActionResult GetCar(int id)
        {
            _logger.LogInformation("consulta realizada");
            return Ok(_carStore.GetCarById(id));
        }

        [HttpGet]
        public IActionResult GetCars()
        {
            return Ok(_carStore.GetCars());        
        }
    }
}
