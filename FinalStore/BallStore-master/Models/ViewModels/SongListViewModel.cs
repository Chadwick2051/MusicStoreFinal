namespace SongStore.Models.ViewModels
{
    public class SongListViewModel
    {
        public IEnumerable<Song>? Songs { get; set; } = null;
        public string? CurrentCategory { get; set; } = string.Empty;
        public string? SalesOrNot { get; set; } = string.Empty;
        public string? PageName { get; set; } = string.Empty;
        public int Page { get; set; } = 1;
    }
}
