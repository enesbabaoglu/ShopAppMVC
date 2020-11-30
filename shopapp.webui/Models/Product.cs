using System.ComponentModel.DataAnnotations;

namespace shopapp.webui.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(60,MinimumLength=5,ErrorMessage="Ürün ismi için 5-60 karakter gerekmektedir!")]
        public string Name { get; set; }
        [Required(ErrorMessage="Fiyat girmelisiniz!")]
        public double? Price { get; set; }
        
        public string Description { get; set; }
        [Required(ErrorMessage="En az 1 resim gerekmektedir!")]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        [Required]
        public int? CategoryId { get; set; }
    }
}