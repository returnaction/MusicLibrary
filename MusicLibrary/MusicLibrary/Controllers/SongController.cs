using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Models;
using MusicLibrary.Repository.IRepository;

namespace MusicLibrary.Controllers
{
    [Route("api/song")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly IRepository<Song> _repository;

        public SongController(IRepository<Song> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var songs = _repository.GetAll();
            return Ok(songs);
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var song = _repository.GetById(id);

            if (song is null)
                return NotFound();

            return Ok(song);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Song song)
        {
            if (song is null)
                return NotFound();

            _repository.Create(song);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song song)
        {
            if (song is null)
                return BadRequest();

            _repository.Update(id, song);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return NoContent();
        }

    }
}
