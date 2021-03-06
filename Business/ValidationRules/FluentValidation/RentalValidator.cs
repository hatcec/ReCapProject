using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(p => p.ReturnDate).NotEqual(null);
            RuleFor(p => p.RentDate).GreaterThan(p => p.ReturnDate);
        }
    }
}
