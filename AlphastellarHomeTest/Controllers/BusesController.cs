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
    public class BusesController : ControllerBase
    {
        IBusService _busService;

        public BusesController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int busId)
        {
            var result = _busService.GetByColorId(busId);

            return Ok(result);
        }

    }
}
