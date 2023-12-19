namespace SongStore.Models
{
    public interface ISongRepository
    {
        IEnumerable<Song> GetAllSongs { get; }
        IEnumerable<Song> GetSongsOnSale { get; }
        Song GetSongById(int ballId);

		void Insert(Song song);
		void Update(Song song);
		void Delete(Song song);
		void Save();

	}
}
