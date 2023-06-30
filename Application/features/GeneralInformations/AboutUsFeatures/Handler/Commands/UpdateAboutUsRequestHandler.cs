using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs.Validators;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.AboutUsFeatures.Handler.Commands
{
    public class UpdateAboutUsRequestHandler : IRequestHandler<UpdateAboutUsRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateAboutUsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(UpdateAboutUsRequest request, CancellationToken cancellationToken)
        {
            var about = await _unitofWork.AboutUsRepository.GetEntityAsync(request.updateAboutUsDTO.Id);

            if (about is null)
            {
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            }
            #region Validation
            var validator = new UpdateAboutUsDTOValidator(_unitofWork.AboutUsRepository);
            var validatorResult = await validator.ValidateAsync(request.updateAboutUsDTO);
            if (!validatorResult.IsValid)
            {
                return ResponseResultDTO.SetResult(null, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            }
            #endregion

            _unitofWork.AboutUsRepository.UpdateEntity(about);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(request.updateAboutUsDTO, StatusMessage.Success, null);

        }
    }
}
