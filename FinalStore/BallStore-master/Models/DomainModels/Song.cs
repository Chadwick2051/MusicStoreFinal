using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace SongStore.Models
{
    public class Song
    {
        
        public int SongId { get; set; }

        [Required(ErrorMessage = "You must enter a song name.")]
        public string? SongName { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must enter a song artist.")]
        public string Artist { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must enter a song price.")]
        [Range(0, 1000, ErrorMessage = "Song price must be >= 0.01")]
        public decimal SongPrice { get; set; } = 1.0M;

        public string? SongImageUrl { get; set; } = string.Empty;

        public string? SongImageThumbnailUrl { get; set; } = string.Empty;

        [ValidateNever]
        public bool IsSongOnSale { get; set; } = false;

        [ValidateNever]
        public bool IsSongInStock { get; set; } = false;

        [Required(ErrorMessage = "SELECT A COUNTRY")]
		public int CategoryId { get; set; }                 //  Foreign key

        [ValidateNever]
        public Category? Category { get; set; } = null;     //  Navigation property
    }
}
