using SongStore.Models;

namespace SongStore.Models
{
	public class SongViewModel
	{
		public Song Song { get; set; } = null!;

		public string Action { get; set; } = string.Empty;

		public IEnumerable<Category>? Categories { get; set; }
	}
}
