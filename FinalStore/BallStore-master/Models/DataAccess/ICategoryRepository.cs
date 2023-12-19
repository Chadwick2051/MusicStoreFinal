namespace SongStore.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories { get; }
    }
}
