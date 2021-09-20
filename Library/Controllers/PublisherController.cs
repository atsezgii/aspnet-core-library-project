using Library.Data.Services;
using Library.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        public PublisherService _publisherservice;
        public PublisherController(PublisherService publisherservice)
        {
            _publisherservice = publisherservice;
        }

        [HttpPost("create")]
        public IActionResult AddPublisher([FromBody] PublisherVM publisher)
        {
            _publisherservice.AddPublisher(publisher);
            return Ok();
        }
        [HttpGet("read/{id}")]
        public IActionResult GetPublisherWithId(int id)
        {
            var response = _publisherservice.GetPublisherWithId(id);
            return Ok(response);
        }
        [HttpDelete("delete/{id}")]
        public IActionResult DeletePublisherById(int id)
        {
            _publisherservice.DeletePublisherById(id);
            return Ok();
        }

    }
}
