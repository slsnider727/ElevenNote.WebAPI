using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

        [ForeignKey("Category")] //Don't actually need this annotation but it's organizationally helpful. public virtual blah blah will automatically look at the line above it and uses it.
        [Required]
        public int CategoryId { get; set; } //pulling Category's key
        public virtual Category Category { get; set; } //what we call it in the note
        //using virtual allows Override on Category
    }
}
