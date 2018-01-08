using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = validationContext.ObjectInstance as Customer;

            if (customer?.MembershipTypeId == (byte)MembershipTypes.Unknown || 
                customer?.MembershipTypeId == (byte)MembershipTypes.PayAsYouGo)
                return ValidationResult.Success;

            if (customer?.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            return age >= 18
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 year old to go on a memebership.");
        }
    }
}