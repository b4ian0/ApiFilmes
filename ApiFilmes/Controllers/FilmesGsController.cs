using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiFilmes.Data;
using ApiFilmes.Models;

namespace ApiFilmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesGsController : ControllerBase
    {
        private readonly DbFilmesContext _context;

        public FilmesGsController(DbFilmesContext context)
        {
            _context = context;
        }

        // GET: api/FilmesGs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmesGs>>> GetFilmesGs()
        {
          if (_context.FilmesGs == null)
          {
              return NotFound();
          }
            return await _context.FilmesGs.ToListAsync();
        }

        // GET: api/FilmesGs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmesGs>> GetFilmesGs(int id)
        {
          if (_context.FilmesGs == null)
          {
              return NotFound();
          }
            var filmesGs = await _context.FilmesGs.FindAsync(id);

            if (filmesGs == null)
            {
                return NotFound();
            }

            return filmesGs;
        }

        // PUT: api/FilmesGs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilmesGs(int id, FilmesGs filmesGs)
        {
            if (id != filmesGs.Id)
            {
                return BadRequest();
            }

            _context.Entry(filmesGs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmesGsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FilmesGs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FilmesGs>> PostFilmesGs(FilmesGs filmesGs)
        {
          if (_context.FilmesGs == null)
          {
              return Problem("Entity set 'DbFilmesContext.FilmesGs'  is null.");
          }
            _context.FilmesGs.Add(filmesGs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilmesGs", new { id = filmesGs.Id }, filmesGs);
        }

        // DELETE: api/FilmesGs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilmesGs(int id)
        {
            if (_context.FilmesGs == null)
            {
                return NotFound();
            }
            var filmesGs = await _context.FilmesGs.FindAsync(id);
            if (filmesGs == null)
            {
                return NotFound();
            }

            _context.FilmesGs.Remove(filmesGs);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FilmesGsExists(int id)
        {
            return (_context.FilmesGs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
