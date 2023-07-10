using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Project.PropertyPlans.Validators
{
    public class IPropertyPlanDTOValidator : AbstractValidator<IPropertyPlanDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public IPropertyPlanDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            RuleFor(x => x.PlanImage)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
            RuleFor(x => x.PropertyId)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
        }
    }
}
