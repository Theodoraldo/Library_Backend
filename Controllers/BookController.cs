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

    [HttpGet, Route("api/[controller]/{id}")]
    public ActionResult GetBook(int id){
        var book = _db.Books.FirstOrDefault(x => x.Id == id);
        if(book == null) {
            return NotFound();
        }
        return Ok(book);
    }
}