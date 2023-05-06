using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs.Validators;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.AboutUsFeatures.Handler.Commands
{
    public class CreateAboutUsRequestHandler : IRequestHandler<CreateAboutUsRequest, ReturnData<CreateAboutUsDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateAboutUsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<CreateAboutUsDTO>> Handle(CreateAboutUsRequest request, CancellationToken cancellationToken)
        {
            #region Validator
            var validator = new CreateAboutUsDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.createAboutUsDTO);
            if (!validatorResult.IsValid)
            {
                return FillRetuenData<CreateAboutUsDTO>.FillByEntity(null, ResponseStatus.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());

            }
            #endregion
            var aboutUsCount = await _unitofWork.AboutUsRepository.GetAboutUsCountAsync();
            if (aboutUsCount > 0)
            {
                return FillRetuenData<CreateAboutUsDTO>.FillByEntity(null, ResponseStatus.NotAllow, null);

            }
            var aboutUs = _mapper.Map<AboutUs>(request.createAboutUsDTO);
            await _unitofWork.AboutUsRepository.AddEntityAsync(aboutUs);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<CreateAboutUsDTO>.FillByEntity(request.createAboutUsDTO, ResponseStatus.Success, null);

        }
    }
}
