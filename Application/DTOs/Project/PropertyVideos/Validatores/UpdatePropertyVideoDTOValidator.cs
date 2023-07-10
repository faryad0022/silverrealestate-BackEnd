using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyGalleries.Validators;
using Application.DTOs.Project.PropertyGalleries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Project.PropertyVideos.Validatores
{
    public class UpdatePropertyVideoDTOValidator : AbstractValidator<UpdatePropertyVideoDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public UpdatePropertyVideoDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            Include(new IPropertyVideoDTOValidator(_unitofWork));
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
                    return await _unitofWork.PropertyVideoRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}
