using Microsoft.AspNetCore.Mvc;
using CityApp.WiewModels;
using CityApp.Servies;
using CityApp.Models;
using System.Linq;
using System;
using Microsoft.Extensions.Logging;

namespace CityApp.Controllers
{

    /// <summary>
    ///  Контроллер, определяет логику по управлению данными городов
    /// </summary>
    public class CityController : Controller
    {

        private ILogger _logger;
        private CityStorage _storage;

        public CityController(ILogger<CityController> logger, CityStorage storage)
        {
            _logger = logger;
            _storage = storage;
        }

        // GET /cities
        // GET /api/city/list
        [HttpGet("cities")]
        [HttpGet("api/city/list")]
        public IActionResult List()
        {
            var cities = _storage
                .GetAll()
                .Select(x => new CityViewModel(x))
                .OrderBy((CityViewModel viewModel) => viewModel.Name);

            return Ok(cities);
        }

        [HttpGet("cities/{id}", Name = "Get")]
        [HttpGet("api/city/{id}", Name = "ApiGet")]
        public IActionResult Get(Guid id)
        {
            if (id == Guid.Empty)
            {
                _logger.LogWarning("Invalid id specified");
                return BadRequest();
            }
            var city = _storage.Get(id);

            if (city == null)
            {
                _logger.LogWarning("City with id {0} is not found", id);
                return NotFound();
            }

            return Ok(new DetailCityViewModel(city));

        }

        // POST /cities
        // POST /api/city
        [HttpPost("cities")]
        [HttpPost("api/city")]
        public IActionResult Create([FromBody] CreateCityViewModel city)
        {
            if (city == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                var models = ModelState
                    .Select(pair => new ValidationErrorViewModel(pair.Key, pair.Value))
                    .ToArray();
                return BadRequest();
            }

            var model = new City
               (
                city.Name,
                city.Description,
                city.Population
                );
            _storage.Create(model);
            return CreatedAtAction("Get", model);
        }

        [HttpDelete("cities/{id}")]
        [HttpDelete("api/city/{id}")]
        public IActionResult Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                _logger.LogWarning("Invalid id specified");
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _storage.Delete(id);

            return Ok();
        }

        [HttpPut("cities/{id}")]
        [HttpPut("api/city/{id}")]
        public IActionResult Update([FromBody] UpadateCityViewModel city, Guid id)
        {
            if (city == null || id == default)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var model = new City
                (
                city.Name,
                city.Description,
                city.Population,
                id
                );
            _storage.Update(model);
            return Ok();
        }
	}
}
