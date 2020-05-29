﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Note> Notes { get; set; }
        //public DateTimeOffset CreatedUtc { get; set; }
        //public DateTimeOffset ModifiedUtc { get; set; }
    }
}
