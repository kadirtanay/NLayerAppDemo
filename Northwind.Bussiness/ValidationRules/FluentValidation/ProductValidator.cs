using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //---------------Fluent Validation---------------
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Product name not alow empty!");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThan((short)0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2).WithMessage("Great than 10");
            RuleFor(p => p.ProductName).Must(MyValidation).WithMessage("Product name end of '-' ");
            //---------------Fluent Validation---------------
        }
        private bool MyValidation(string arg)
        {
            return arg.EndsWith("-");
        }
    }
}
