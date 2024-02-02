using Microsoft.AspNetCore.Mvc;
using NETFLIXLATAM.Data;
using NETFLIXLATAM.DTO;
using NETFLIXLATAM.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NETFLIXLATAM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private readonly ApiDbContext dbContext;
        public PeliculasController(ApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: api/<PeliculasController>
        [HttpGet]
        public IEnumerable<Peliculas> Get()
        {
            return dbContext.Peliculas;
        }

    

        // GET api/<PeliculasController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pelis = dbContext.Peliculas.FirstOrDefault(s => s.Id == id);

            if (pelis == null)
            {
                return NotFound();
            }

            return Ok(pelis);
        }

        // POST api/<PeliculasController>
        [HttpPost]
        public ActionResult Post([FromBody] PeliculasDTO newPeli)
        {
            var pelis = new Peliculas
            {
                Titulo = newPeli.Titulo,
                Duracion = newPeli.Duracion,
                Genero = newPeli.Genero,


            };
            dbContext.Peliculas.Add(pelis);
            dbContext.SaveChanges();

            return Ok();
        }

        // PUT api/<PeliculasController>/
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Peliculas updatedPeli)
        {
            if (updatedPeli == null || id != updatedPeli.Id)
            {
                return BadRequest();
            }

            var existingPeli = dbContext.Peliculas.FirstOrDefault(s => s.Id == id);

            if (existingPeli == null)
            {
                return NotFound();
            }

            existingPeli.Titulo = existingPeli.Titulo;
            existingPeli.Duracion = existingPeli.Duracion;
            existingPeli.Genero = existingPeli.Genero;

            dbContext.SaveChanges();

            return NoContent();
        }

        // DELETE api/<PeliculasController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var peliToDelete = dbContext.Peliculas.FirstOrDefault(s => s.Id == id);

            if (peliToDelete == null)
            {
                return NotFound();
            }

            dbContext.Peliculas.Remove(peliToDelete);
            dbContext.SaveChanges();

            return NoContent();
        }
    }
}
