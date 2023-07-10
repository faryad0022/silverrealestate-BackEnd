using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyGalleries.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Project.PropertyPlans.Validators
{
    public class CreatePropertyPlanDTOValidator : AbstractValidator<CreatePropertyPlanDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public CreatePropertyPlanDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            Include(new IPropertyPlanDTOValidator(_unitofWork));
            RuleFor(x => x.PropertyId)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.PropertyRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}
