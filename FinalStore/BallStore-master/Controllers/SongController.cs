using SongStore.Models;
using SongStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace SongStore.Controllers
{
    public class SongController : Controller
    {
        private readonly ISongRepository? _songRepository;
        private readonly ICategoryRepository? _categoryRepository;

        public SongController(ISongRepository? songRepository, 
                              ICategoryRepository? categoryRepository)
        {
            _songRepository = songRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category, string sale, int page, string pageName)
        {
            IEnumerable <Song> songs;
            string currentCategory = "";
            int pageSize = 6;
            if(page < 1) { page = 1; }

            if (string.IsNullOrEmpty (category))
            {
                songs = _songRepository.GetAllSongs
                                       .OrderBy(c => c.SongId).Skip((page-1)*pageSize).Take(pageSize);
                pageName = "All Songs";
            }
            else
            {
                songs = _songRepository.GetAllSongs
                                       .Where(c => c.Category.CategoryName == category).OrderBy(c => c.SongId).Skip((page - 1) * pageSize).Take(pageSize);

                currentCategory = _categoryRepository
                                  .GetCategories
                                  .FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            if (sale == "SALE")
            {
                songs = _songRepository.GetAllSongs
                                       .Where(c => c.IsSongOnSale == true).OrderBy(c => c.SongId).Skip((page - 1) * pageSize).Take(pageSize);
                pageName = "All Sales";
            }

            return View(new SongListViewModel
            {
                Songs = songs,
                CurrentCategory = currentCategory,
                SalesOrNot = sale,
                Page = page,
                PageName = pageName
            });
        }

        public IActionResult Details(int id)
        {
            var ball = _songRepository?.GetSongById(id);

            if (ball == null)
            {
                return NotFound();
            }

            return View(ball);
        }

		[HttpGet]
        [Authorize(Roles = "Admin")]
		public ViewResult Add()
		{
			var vm = new SongViewModel();
			vm.Action = "Add";

			vm.Categories = _categoryRepository.GetCategories.ToList();

			return View("AddEdit", vm);
		}

		[HttpGet]
        [Authorize(Roles = "Admin")]
        public ViewResult Edit(int id)
		{
			var vm = new SongViewModel();
			vm.Action = "Edit";

			vm.Categories = _categoryRepository.GetCategories.ToList();

			vm.Song = _songRepository.GetSongById(id)!;
			return View("AddEdit", vm);
		}

		[HttpPost]
		public IActionResult Edit(SongViewModel vm)
		{
			if (ModelState.IsValid)
			{
				if (vm.Song.SongId == 0)
				{
					_songRepository.Insert(vm.Song);
				}
				else
				{
					_songRepository.Update(vm.Song);
				}
				_songRepository.Save();
				return RedirectToAction("List", "Song");
			}
			else
			{
				vm.Action = (vm.Song.SongId == 0) ? "Add" : "Edit";

				vm.Categories = _categoryRepository.GetCategories.ToList();

				return View("AddEdit", vm);
			}
		}
        [HttpGet]
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ViewResult Delete(int id)
        {
            var product = _songRepository.GetSongById(id);
            return View(product);
        }
        [HttpPost]
        public RedirectToActionResult Delete(Song song)
        {
            string Name = song.SongName;
            TempData["message"] = $"{Name} was Deleted";
            _songRepository.Delete(song);
            _songRepository.Save();
            return RedirectToAction("List");
        }
    }
}
