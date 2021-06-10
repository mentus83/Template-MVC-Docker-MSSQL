using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.Controllers;
using mvc.Data.Models;

namespace mvc.Api.Controllers
{
    [Route("/api/[Controller]")]
    public class MyObjectController : Controller
    {
        private MyObjectRepository _repo;
        private readonly ILogger<MyObjectController> _logger;
        public MyObjectController(ILogger<MyObjectController> logger, MyObjectRepository repo)
        {
            _repo = repo;
            _logger = logger;
        }
        public IActionResult GetAll()
        {
            if (!_repo.DatabaseIsAvailable()) return BadRequest("Database is not available!");
            try
            {
                var myObjects = _repo.GetAll();
                if (myObjects == null) return NotFound("Nothing was found!");
                return Json(myObjects);
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Failed to return data: {ex}");
            }
        }
    }
}
