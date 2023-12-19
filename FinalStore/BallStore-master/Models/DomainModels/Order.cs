using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace SongStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Display(Name = "First Name")]
        [StringLength(25)]
        [Required(ErrorMessage = "You must enter a first name.")]
        public string? FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        [StringLength(25)]
        [Required(ErrorMessage = "You must enter a last name.")]
        public string? LastName { get; set; } = string.Empty;

        [Display(Name = "Street Address")]
        [StringLength(50)]
        [Required(ErrorMessage = "You must enter an address.")]
        public string? Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must enter a city.")]
        public string? City { get; set; } = string.Empty;

        [StringLength(2, MinimumLength = 2)]
        [Required(ErrorMessage = "You must enter a state.")]
        public string? State { get; set; } = string.Empty;

        [StringLength(5, MinimumLength = 5)]
        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "You must enter a zip code.")]
        public string? ZipCode { get; set; } = string.Empty;

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "You must enter a phone number.")]
        public string? PhoneNumber { get; set; } = string.Empty;

        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; } = 0.0M;

        [BindNever]
        public DateTime OrderPlaced { get; set; } = DateTime.Now;
    }
}
