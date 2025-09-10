using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyApi.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }
        [JsonIgnore] 
        public List<Product> Products { get; set; } = new List<Product>();
    }
}