namespace SongStore.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int SongId { get; set; }

        public Song Song { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }

        public Order Order { get; set; }

    }
}
