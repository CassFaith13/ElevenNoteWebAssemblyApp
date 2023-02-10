using System.ComponentModel.DataAnnotations;

namespace ElevenNoteWebApp.Shared.Models.Category
{
    public class CategoryEdit
    {
        [Required]
        public string? Name { get; set; }
    }
}