using FluentValidation;

using System;
using System.Collections.Generic;
using System.Text;
using RoundTableDal.Models;

namespace RoundTableERPDal.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {

        public CustomerValidator()
        {



            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Name cannot be empty");

        }
    }
}
