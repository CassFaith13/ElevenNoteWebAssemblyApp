using System.ComponentModel.DataAnnotations;

namespace ElevenNoteWebApp.Server.Models
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}