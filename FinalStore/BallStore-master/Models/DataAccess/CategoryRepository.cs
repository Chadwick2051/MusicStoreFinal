
using SongStore.Models.DataAccess;

namespace SongStore.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly SongContext _ballContext;

        public CategoryRepository(SongContext ballContext)
        {
            _ballContext = ballContext;
        }

        public IEnumerable<Category> GetCategories => _ballContext.Categories;
    }
}
