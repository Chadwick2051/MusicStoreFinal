namespace SongStore.Models.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart? ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; } = 0.0M;
    }
}
