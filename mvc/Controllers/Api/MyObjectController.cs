using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.Controllers;
using mvc.Data.Models;
using mvc.Models.Entities;
using mvc.Models.ViewModels;

namespace mvc.Api.Controllers
{
    [Route("/api/[Controller]")]
    [ApiController]
    [Produces("application/json")]
    public class MyObjectController : Controller
    {
        private MyObjectRepository _repo;
        private readonly IMapper _mapper;
        private readonly ILogger<MyObjectController> _logger;
        public MyObjectController(ILogger<MyObjectController> logger, MyObjectRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            if (!_repo.DatabaseIsAvailable()) return NotFound("Database is not available!");
            try
            {
                var myObjects = _repo.GetAll();
                if (myObjects == null) return NotFound("Nothing was found!");
                return Json(_mapper.Map<IEnumerable<MyObjectViewModel>>(myObjects));
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Failed to return data: {ex}");
            }
        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            if (!_repo.DatabaseIsAvailable()) return NotFound("Database is not available!");
            try
            {
                var myObject = _repo.GetById(id);
                if (myObject == null) return NotFound("Nothing was found!");
                return Json(_mapper.Map<MyObjectViewModel>(myObject));
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Failed to return data: {ex}");
            }
        }

        [HttpPost]
        public IActionResult AddNew([FromBody]MyObjectViewModel model)
        {
            if (!_repo.DatabaseIsAvailable()) return NotFound("Database is not available!");
            if (!ModelState.IsValid) return Forbid($"Failed to store data in the database: {ModelState}");
            try
            {
                var myObject = _mapper.Map<MyObject>(model);
                _repo.AddEntity(myObject);
                _repo.SaveAll();
                return Created($"/api/myobject/{model.Id}", model);
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Failed to store data in the database: {ex.Message}");
            }
        }
    }
}
