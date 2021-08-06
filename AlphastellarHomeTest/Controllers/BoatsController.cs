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
    public class BoatsController : ControllerBase
    {
        IBoatService _boatService;

        public BoatsController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int boatId)
        {
            var result = _boatService.GetByColorId(boatId);

            return Ok(result);
        }
    }
}
