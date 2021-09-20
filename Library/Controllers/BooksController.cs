using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO.Ports;
using Library.Data.Services;
using Library.Data.ViewModels;
using Newtonsoft.Json;
using Library.Data.Models;

namespace Library.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;
        public WeighbridgeService _service;

        public BooksController(BooksService booksService, WeighbridgeService service)
        {
            _booksService = booksService;
            _service = service;
        }

        [HttpPost("create")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();
        }

        [HttpGet("read_all")]
        public IActionResult GetAllBooks()
        {

            var allBooks = _booksService.GetAllBooks();
            return Ok(allBooks);
        }
        [HttpGet("read/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _booksService.GetBookById(id);
            return Ok(book);
        }
        [HttpPut("update/{id}")]
        public IActionResult UpdateBookById(int id, [FromBody]BookVM book)
        {
            var updatedBook = _booksService.UpdateBookById(id, book);
            return Ok(updatedBook);
        }
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteBookById(int id)
        {
            _booksService.DeleteBookById(id);
            return Ok();
        }


    }
   
}
