using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore31MongoDb.Models;
using DotNetCore31MongoDb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;

namespace DotNetCore31MongoDb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //https://thecodebuzz.com/mongodb-repository-implementation-unit-testing-net-core-example/
        private readonly BookService _bookService;

        public WeatherForecastController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<List<Object>> Get() =>
            _bookService.Get();

        //[HttpGet("{id:length(24)}", Name = "GetBook")]
        //public ActionResult<Book> Get(string id)
        //{
        //    var book = _bookService.Get(id);

        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    return book;
        //}

        //[HttpPost]
        //public ActionResult<Book> Create(Book book)
        //{
        //    _bookService.Create(book);

        //    return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);
        //}

        //[HttpPut("{id:length(24)}")]
        //public IActionResult Update(string id, Book bookIn)
        //{
        //    var book = _bookService.Get(id);

        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    _bookService.Update(id, bookIn);

        //    return NoContent();
        //}

        //[HttpDelete("{id:length(24)}")]
        //public IActionResult Delete(string id)
        //{
        //    var book = _bookService.Get(id);

        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    _bookService.Remove(book.Id);

        //    return NoContent();
        //}
    }
}
