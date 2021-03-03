using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ashraful_CoreProject.Models
{
    public class EmployeeVM
    {
        public int EmployeeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public int Phone { get; set; }
        public IFormFile UrlImage { get; set; }
    }
}
