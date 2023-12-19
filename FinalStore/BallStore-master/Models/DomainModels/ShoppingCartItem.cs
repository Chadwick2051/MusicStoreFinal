namespace SongStore.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public string? ShoppingCartId { get; set; }

        public Song? Song { get; set; } = null;

        public int Amount { get; set; } = 0;
    }
}
