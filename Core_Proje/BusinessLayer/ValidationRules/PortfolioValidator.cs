using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Portfolio name can not be null");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("ImageUrl can not be null");
            RuleFor(x => x.Platform).NotEmpty().WithMessage("Platform can not be null");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Price can not be null");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Value can not be null");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Portfolio name has at least 5 characters");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Portfolio name has at most 100 characters");

        }
    }
}
