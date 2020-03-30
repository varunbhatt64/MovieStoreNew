using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStoreNew.Models
{
    public class Min18YearsIfAMember: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.None)
                return ValidationResult.Success;

            if (customer.BirthDate == null)
                return new ValidationResult("Birthday is Required.");

            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;

            return (age < 18 ?
                new ValidationResult("Customer should be at least 18 to go on a membership")
                : ValidationResult.Success);

        }
    }
}