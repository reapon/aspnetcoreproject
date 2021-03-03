using Ashraful_CoreProject.CustomAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ashraful_CoreProject.Models
{
    public class Registration
    {
        [Key]
        public int RegistrationID { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "Name should be 3-70 Character!!")]
        [Display(Name = "Full Name")]

        public string FullName { get; set; }

        [Required(ErrorMessage = "Required")]
        [EmailAddress]

        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.PhoneNumber)]

        public int Phone { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.MultilineText)]

        public string Address { get; set; }

        [Required(ErrorMessage = "Required")]
        [Range(18, 90, ErrorMessage = "Age should Be in between 18-90")]

        public int Age { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]

        [DateAttr]

        public DateTime RegDate { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        [RegularExpression(@"[^\s]+", ErrorMessage = "White Space are not allowed")]

        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password Not Matched")]
        public string ConfirmPassword { get; set; }
    }
}
