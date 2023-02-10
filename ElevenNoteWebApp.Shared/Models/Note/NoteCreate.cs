using System.ComponentModel.DataAnnotations;

namespace ElevenNoteWebApp.Shared.Models.Note
{
    public class NoteCreate
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }
        public int CategoryId { get; set; }
    }
}