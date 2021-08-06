using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphastellarHomeTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int colorId)
        {
            var result = _carService.GetByColorId(colorId);
            
            return Ok(result);
        }

        [HttpPost("closethecarlightbyid")]
        public IActionResult CloseTheCarLightById(int carId)
        {
            var result = _carService.CloseTheCarLightById(carId);

            return Ok(result);
        }

        [HttpDelete("deletecarbyid")]
        public IActionResult DeleteCarById(int carId)
        {
            var result = _carService.GetByColorId(carId);

            return Ok(result);
        }
    }
}
