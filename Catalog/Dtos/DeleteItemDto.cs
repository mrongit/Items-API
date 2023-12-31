using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record DeleteItemDto
    {
        [Required]
          public Guid Id { get; init; }
    }
}