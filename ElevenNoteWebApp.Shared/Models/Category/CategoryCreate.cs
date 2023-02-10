using System.ComponentModel.DataAnnotations;

namespace ElevenNoteWebApp.Shared.Models.Category
{
    public class CategoryCreate
    {
        [Required]
        public string? Name { get; set; }
    }
}