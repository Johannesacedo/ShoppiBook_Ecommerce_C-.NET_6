﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BulkyBook.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Cover Type")]
        [MaxLength(50)]
        public string? Name { get; set; }
    }
}
