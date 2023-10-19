using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using MusicLibrary.Models;
using MusicLibrary.Repository.IRepository;
using System.Reflection.Metadata.Ecma335;

namespace MusicLibrary.Controllers
{
    [Route("api/song")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongRepository<Song> _repository;

        public SongController(ISongRepository<Song> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var song = await _repository.GetById(id);

            if (song is null)
                return NotFound();

            return Ok(song);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Song song)
        {
            if (song is null)
                return NotFound();

             await _repository.Create(song);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Song song)
        {
            if (song is null)
                return BadRequest();
            
            var updatedSong = await _repository.Update(id, song);

            if (updatedSong is null)
                return NotFound();

            return Ok();
        }

        [HttpPut("/like/{id}")]
        public async Task<IActionResult> LikeASong(int id)
        {
             var song = await _repository.LikeASong(id);

             if(song is null)
                return NotFound();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.Delete(id);
            return NoContent();
        }

        


    }
}
