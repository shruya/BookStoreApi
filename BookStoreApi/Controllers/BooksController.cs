using Microsoft.AspNetCore.Mvc;
using BookStoreApi.Models;

namespace BookStoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        // In-memory list of books
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "C# Basics", Author = "John Doe", Price = 299 },
            new Book { Id = 2, Title = "ASP.NET Core", Author = "Jane Smith", Price = 399 }
        };

        // GET: api/books
        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(books);
        }

        // GET: api/books/{id}
        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound("Book not found");
            return Ok(book);
        }

        // POST: api/books
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            book.Id = books.Max(b => b.Id) + 1;
            books.Add(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        // PUT: api/books/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book updatedBook)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound("Book not found");

            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Price = updatedBook.Price;

            return NoContent();
        }

        // DELETE: api/books/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound("Book not found");

            books.Remove(book);
            return NoContent();
        }
    }
}