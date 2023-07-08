using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Project.PropertDTOs.Validators
{
    public class IPropertyDTOValidator : AbstractValidator<IPropertyDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public IPropertyDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            
            
            RuleFor(x => x.CityId)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.CityRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
            
            
            RuleFor(x => x.FeatureImage)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
            
            
            RuleFor(x => x.PropertyContractTypeId)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.PropertyContractTypeRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
            
            
            RuleFor(x => x.PropertyTypeId)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.PropertyTypeRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}
