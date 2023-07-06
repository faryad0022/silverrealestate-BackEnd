﻿using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.City.Validators
{
    public class UpdateCityDTOValidator : AbstractValidator<UpdateCityDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public UpdateCityDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;

            Include(new ICItyDTOVlidator());
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan);
            RuleFor(x => x.CountryId)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.CountryRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}
