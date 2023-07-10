using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyGalleries.Validators;
using Application.DTOs.Project.PropertyGalleries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Const.Response;

namespace Application.DTOs.Project.PropertyVideos.Validatores
{
    public class CreatePropertyVideoDTOValidator : AbstractValidator<CreatePropertyVideoDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public CreatePropertyVideoDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            Include(new IPropertyVideoDTOValidator(_unitofWork));
            RuleFor(x => x.PropertyId)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.PropertyRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}
