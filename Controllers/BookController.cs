using LibraryAPI.Data;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BookController : ControllerBase
{
    private readonly LibraryDbContext _db;

    public BookController(LibraryDbContext db)
    {
        _db = db;
    }
    
    [HttpGet]
    public async Task<IEnumerable<Book>> GetAllBooks(){
        return await _db.Books.ToListAsync();
    }

    [HttpGet("{id}")]
    public ActionResult GetBook(int id){
        var book = _db.Books.FirstOrDefault(x => x.Id == id);
        if(book == null) {
            return NotFound();
        }
        return Ok(book);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create(Book book){
        _db.Books.Add(book);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
    }

    
    [HttpPut("{id}")]
    public async Task<ActionResult> PutBook(int id, Book book){
        if(id != book.Id){
            return BadRequest();
        }
        _db.Entry(book).State = EntityState.Modified;
        try
        {
            await _db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if(!_db.Books.Any(g => g.Id == id)){
                return NotFound();
            }
            else{
                throw;              
            }       
        }
        return Ok(book);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Book>> DeleteBook(int id)
    {
        var book = await _db.Books.FindAsync(id);
        if (book == null)
        {
            return NotFound();
        }
        _db.Books.Remove(book);
        await _db.SaveChangesAsync();
        return book;
    }
}