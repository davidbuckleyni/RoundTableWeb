using FluentValidation;

using System;
using System.Collections.Generic;
using System.Text;
using RoundTableDal.Models;

namespace RoundTableERPDal.Validators.Orders
{
    public class StockItemValidator : AbstractValidator<Stock>
    {
        public StockItemValidator()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.StockCode).Length(1, 50).WithMessage("Stock code must be less than 50");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Start date must have a value");





        }

    }
}
