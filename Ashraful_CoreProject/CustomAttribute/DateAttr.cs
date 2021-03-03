﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ashraful_CoreProject.CustomAttribute
{
    public class DateAttr : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                DateTime date = new DateTime(((DateTime)value).Year, ((DateTime)value).Month, ((DateTime)value).Day);
                if (date == DateTime.Today)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Registration date must be today.");
                }
            }
            catch (Exception ex)
            {
                return new ValidationResult(ex.Message);
            }
        }
    }
}

