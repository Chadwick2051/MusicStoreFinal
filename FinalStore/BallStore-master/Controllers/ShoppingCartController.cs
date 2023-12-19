using SongStore.Models;
using SongStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace SongStore.Controllers
{
	public class ShoppingCartController : Controller
    {
        private readonly ISongRepository _songRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ISongRepository songRepository,
                                      ShoppingCart shoppingCart)
        {
            _songRepository = songRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            //  Retrieve all shoppingCartItems
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int songId)
        {
            var selectedSong = _songRepository.GetAllSongs
                                              .FirstOrDefault(b => b.SongId == songId);

            //  Does selected ball exist
            if (selectedSong != null)
            {
                _shoppingCart.AddToCart(selectedSong, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int songId)
        {
            var selectedSong = _songRepository.GetAllSongs
                                              .FirstOrDefault(b => b.SongId == songId);

            if (selectedSong != null)
            {
                _shoppingCart.RemoveFromCart(selectedSong);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();

            return RedirectToAction("Index");
        }
    }
}
