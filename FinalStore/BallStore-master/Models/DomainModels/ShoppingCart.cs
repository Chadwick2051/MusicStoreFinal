using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SongStore.Models.DataAccess;

namespace SongStore.Models
{
    public class ShoppingCart
    {
        private readonly SongContext _songContext;
        public string? ShoppingCartId { get; set; }  

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(SongContext songContext)
        {
            _songContext = songContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<SongContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context)
            { 
                ShoppingCartId = cartId 
            };
        }

        public void AddToCart(Song song, int amount)
        {
            //  If it finds one here we already have 1 or
            //  more of this item in our ShoppingCart.
            var shoppingCartItem = _songContext.ShoppingCartItems
                                               .SingleOrDefault(
                                                   s => s.Song.SongId == song.SongId
                                               &&  s.ShoppingCartId == ShoppingCartId);

            //  If the check above was not true, 
            //  we have the first instance of a
            //  new shoppingCartItem to add to
            //  the ShoppingCart.
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Song = song,
                    Amount = amount
                };

                _songContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _songContext.SaveChanges();
        }

        public int RemoveFromCart(Song song)
        {
            var shoppingCartItem = _songContext
                                    .ShoppingCartItems
                                    .SingleOrDefault(
                                           s => s.Song.SongId == song.SongId &&
                                           s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    //  Only one of that item currently in the
                    //  cart. As it is now removed, you can
                    //  remove item completely from ShoppingCart.
                    ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _songContext.SaveChanges();

            //  New amount of this item in the cart
            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _songContext
                                                      .ShoppingCartItems
                                                      .Where(b => b.ShoppingCartId == ShoppingCartId)
                                                      .Include(s => s.Song)
                                                      .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _songContext
                            .ShoppingCartItems
                            .Where(c => ShoppingCartId == ShoppingCartId);

            _songContext.ShoppingCartItems.RemoveRange(cartItems);
            _songContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _songContext.ShoppingCartItems
                                    .Where(c => c.ShoppingCartId == ShoppingCartId)
                                    .Select(c => c.Song.SongPrice * c.Amount).Sum();

            return total;
        }
    }
}
