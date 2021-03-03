using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ashraful_CoreProject.Models
{
    public class ProductAjax
    {
        [Key]
        [MaxLength(6)]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public string Category { get; set; }
        [Required]
        [DataType(DataType.Date)]



        public DateTime EntryDate { get; set; }
        [Required]

        public float Price { get; set; }
        [Required]

        public string ImageUrl { get; set; }
    }
}
