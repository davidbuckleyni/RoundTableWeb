using FluentValidation;
using RoundTableERPDal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoundTableERPDal.Validators.Orders
{
    public class OrderValidator : AbstractValidator<Documents>
    {

        public OrderValidator()
        {

            

            RuleFor(x => x.Description).NotEmpty().WithMessage("Description cannot be empty");
            RuleFor(x => x.Date).NotNull().WithMessage("Start Date cannot be empty");
            RuleFor(x => x.DeliveryDate).NotNull().WithMessage("Delivery date cannot be empty");
            RuleFor(x => x.PromisedDeliveryDate).NotNull().WithMessage("Dispatched Date cannot be empty");
            

        }
    }
}
