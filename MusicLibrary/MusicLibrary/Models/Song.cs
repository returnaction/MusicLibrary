using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models
{
    public class Song
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Artist { get; set; }
        public string? Album { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public int Likes { get; set; } = 0;

    }
}
