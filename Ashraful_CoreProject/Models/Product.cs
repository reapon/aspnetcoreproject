using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ashraful_CoreProject.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        public string UrlImage { get; set; }

        [Required]
        public string Price { get; set; }
        [Required]
        public string Detail { get; set; }

        [NotMapped]
        public IFormFile ImageUrl { get; set; }
    }
}
