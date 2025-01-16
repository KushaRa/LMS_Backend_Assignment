using lmsBackend.Data;
using lmsBackend.Models;
using lmsBackend.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lmsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public BooksController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var allBooks = dbContext.Books.ToList();
            return Ok(allBooks);
        }

        [HttpPost]
        public IActionResult AddBook(AddBookDto addBookDto) //use dto obj as a parameter here its name addBookDto, //dto: Data Transfer objects, this transer data from one operation to another
        {
            var bookEntity = new Book()
            {
                Title = addBookDto.Title,
                Author = addBookDto.Author,
                Category = addBookDto.Category,
                EntrydDate = addBookDto.EntrydDate,
                Description = addBookDto.Description
            };


            dbContext.Books.Add(bookEntity);
            dbContext.SaveChanges();
            return Ok(bookEntity);

        }
        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetBookByID(Guid id)
        {
            var book = dbContext.Books.Find(id);
            if (book is null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPut]
        [Route("{id:guid}")]

        public IActionResult UpdateBook(Guid id, UpdateBookDto updateBookDto)

        {
            var book = dbContext.Books.Find(id);

            if (book is null)
            {
                return NotFound();
            }

            book.Title = updateBookDto.Title;
            book.Author = updateBookDto.Author;
            book.Category = updateBookDto.Category;
            book.EntrydDate = updateBookDto.EntrydDate;
            book.Description = updateBookDto.Description;

            dbContext.SaveChanges();
            return Ok(book);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteBook(Guid id)
        {
            var book = dbContext.Books.Find(id);

            if (book is null)
            {
                return NotFound();
            }
            dbContext.Books.Remove(book);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}

//35 min.to get lot of modularity sepereation of concern,readable