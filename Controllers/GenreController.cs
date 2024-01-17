using LibraryAPI.Data;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class GenreController : ControllerBase
{
    private readonly LibraryDbContext _db;

    public GenreController(LibraryDbContext db)
    {
        _db = db;
    }
    
    [HttpGet]
    public async Task<IEnumerable<Genre>> GetAllGenres(){
        return await _db.Genres.ToListAsync();
    }

    [HttpGet, Route("api/[controller]/{id}")]
    public ActionResult GetGenre(int id){
        var genre = _db.Genres.FirstOrDefault(x => x.Id == id);
        if(genre == null) {
            return NotFound();
        }
        return Ok(genre);
    }
}