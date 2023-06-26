using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.DTOs.GeneralSiteInformationsDTO.Logo.Validator;
using Application.features.GeneralInformations.LogoFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.LogoFeatures.Handler.Commands
{
    public class CreateLogoRequestHandler : IRequestHandler<CreateLogoRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateLogoRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(CreateLogoRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreateLogoValidator();
            var validatorResult = await validator.ValidateAsync(request.createLogoDTO);
            if (!validatorResult.IsValid)
                return ResponseResult.SetResult(
                    null,
                    StatusMessage.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var logo = _mapper.Map<Logo>(request.createLogoDTO);
            await _unitofWork.LogoRepository.AddEntityAsync(logo);
            await _unitofWork.SaveChangesAsync();
            return ResponseResult.SetResult(request.createLogoDTO, StatusMessage.Success, null);
        }
    }
}
