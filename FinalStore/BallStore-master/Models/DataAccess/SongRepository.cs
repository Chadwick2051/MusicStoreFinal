using Microsoft.EntityFrameworkCore;
using SongStore.Models.DataAccess;
using System.Collections.Generic;

namespace SongStore.Models
{
    public class SongRepository : ISongRepository
    {
        private readonly SongContext _songContext;

		public SongRepository(SongContext songContext)
        {
            _songContext = songContext;
		}

        public IEnumerable<Song> GetAllSongs
        {
            get
            {
            return _songContext.Songs
                                .Include(c => c.Category);
            }
        }

        public IEnumerable<Song> GetSongsOnSale
        {
            get
            {
                return _songContext.Songs
                                   .Include(c => c.Category)
                                   .Where(b => b.IsSongOnSale);
            }
        }

        public Song GetSongById(int songId)
        {
			return _songContext.Songs
							   .FirstOrDefault(b => b.SongId == songId);
        }
        public void Insert(Song song)
        {
            _songContext.Add(song);
        }
		public void Update(Song song)
		{
			_songContext.Update(song);
		}
		public void Delete(Song song)
		{
			_songContext.Remove(song);
		}
		public void Save()
		{
			_songContext.SaveChanges();
		}
	}
}
