using System.Net.Http.Headers;
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
    public async Task<IEnumerable<Genre>> GetAll(){
        return await _db.Genres.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetOne(Guid id){
        var genre = await _db.Genres.FirstOrDefaultAsync(x => x.Id == id);
        if(genre == null) {
            return NotFound();
        }
        return Ok(genre);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create(Genre genre){
        _db.Genres.Add(genre);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetOne), new { id = genre.Id }, genre);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> PutGenre(Guid id, Genre genre){
        if(id != genre.Id){
            return BadRequest();
        }
        _db.Entry(genre).State = EntityState.Modified;
        try
        {
            await _db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if(!_db.Genres.Any(g => g.Id == id)){
                return NotFound();
            }
            else{
                throw;              
            }       
        }
        return Ok(genre);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteGenre(Guid id)
    {
        var genre = await _db.Genres.FindAsync(id);
        if (genre is null)
        {
            return NotFound();
        }
        _db.Genres.Remove(genre);
        await _db.SaveChangesAsync();
        return Ok("Deleted Successfully !!!");
    }
}