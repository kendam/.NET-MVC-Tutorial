using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NETAPP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public readonly NETAPPContext _context;

        public BookController(NETAPPContext context)
        {
            _context = context;
        }

        /*
         200 ,  
         400 
         500
         */


        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _context.Book.ToList();
            return Ok(books);
            
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById( int id)
        {
            Book book = _context.Book.Find(id);
            if(book==null)
            {
                return NotFound();
            }
                return Ok(book);
        }

        [HttpPost]
        public IActionResult SaveBook( Book book)
        {
            _context.Book.Add(book);
            _context.SaveChanges();
            return Ok(book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook( Book book, int id )
        {
            _context.Book.Update(book);
            _context.SaveChanges();
            return Ok( new { message= "content updated" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveBook(int id)
        {
            var book = await _context.Book.FindAsync(id);
            if(book ==null)
            {
                return NotFound();
            }
            _context.Book.Remove(book);
           await _context.SaveChangesAsync();
            return Ok();
        }

        
    }
}
