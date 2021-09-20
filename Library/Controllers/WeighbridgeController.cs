using Library.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeighbridgeController : ControllerBase
    {
        public WeighbridgeService _weighbridgeService;

        public WeighbridgeController(WeighbridgeService weighbridgeService)
        {
            _weighbridgeService = weighbridgeService;
        }
        [HttpGet("read_all")]
        public IActionResult GetPorts()
        {
            var allPorts = _weighbridgeService.GetPorts();
            var json = JsonConvert.SerializeObject(allPorts);
            return Ok(json);

        }

    }
}
