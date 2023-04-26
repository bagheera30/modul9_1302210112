using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302210112.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class moviesController : ControllerBase
    {
          
        // GET: api/<movie>
        [HttpGet]
        public IEnumerable<movie> Get()
        {
            return movie.Movies;
        }

        // GET api/<movie>/5
        [HttpGet("{id}")]
        public ActionResult<movie> Get(int id)
        {
            try
            {
                if (movie.Movies == null || id < 0 || id >= movie.Movies.Count)
                {
                    return NotFound("movie.Movies mahasiswa tidak ditemukan");
                }
                return movie.Movies[id];
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<movie>
        [HttpPost]
        public void Post([FromBody] movie value)
        {
            if (value == null)
            {
                BadRequest("Data mahasiswa tidak valid");
                return;
            }
            movie.Movies.Add(value);
            CreatedAtAction(nameof(Get), new { id = movie.Movies.IndexOf(value) }, value);
        }

     

        // DELETE api/<movie>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                if (movie.Movies == null || id < 0 || id >= movie.Movies.Count)
                {
                    NotFound("Data mahasiswa tidak ditemukan"); // Return a NotFound response if movie.Movies is null, or id is out of range
                    return;
                }

                movie.Movies.RemoveAt(id);
                NoContent();
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
        }
    }
}
