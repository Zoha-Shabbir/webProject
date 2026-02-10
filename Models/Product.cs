using System.ComponentModel.DataAnnotations;

namespace MyMvcAuthProject.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [StringLength(50)]
        public string? Category { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
