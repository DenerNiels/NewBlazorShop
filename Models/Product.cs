using System.ComponentModel.DataAnnotations;

namespace NewBlazorShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título")]
        [MinLength(3, ErrorMessage = "A categoria deve ter pelo menos 3 caracteres")]
        [MaxLength(60, ErrorMessage = "A categoria deve ter no máximo 60 caracteres")]
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage ="Informe o preºo do produto")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
