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
    public class AuthorController : ControllerBase
    {
        public AuthorService _authorService;
        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost("create")]
        public IActionResult AddBook([FromBody] AuthorVM author)
        {
            _authorService.AddAuthor(author);
            return Ok();
        }
        [HttpGet("read/{id}")]
        public IActionResult GetAuthorWithBooks(int id)
        {
            var response = _authorService.GetAuthorWithBooks(id);
            return Ok(response);
        }

    }
}
