
using SongStore.Models.DataAccess;

namespace SongStore.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SongContext _songContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(SongContext songContext,
                               ShoppingCart shoppingCart)
        {
            _songContext = songContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            _songContext.Orders.Add(order);
            _songContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    Price = shoppingCartItem.Song.SongPrice,
                    SongId = shoppingCartItem.Song.SongId,
                    OrderId = order.OrderId
                };

                _songContext.OrderDetails.Add(orderDetail);
            }

            _songContext.SaveChanges();
        }
    }
}
