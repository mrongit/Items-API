using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record UpdateItemDto
    {
        [Required]
         public string Name { get; set; }
         [Required]
         [Range(1,500000)]
        public decimal Price { get; set; }
    }
}