using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyGalleries.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Project.PropertyPlans.Validators
{
    public class UpdatePropertyPlanDTOValidator : AbstractValidator<UpdatePropertyPlanDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public UpdatePropertyPlanDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            Include(new IPropertyPlanDTOValidator(_unitofWork));
            RuleFor(x => x.PropertyId)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.PropertyRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.PropertyPlanRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}
