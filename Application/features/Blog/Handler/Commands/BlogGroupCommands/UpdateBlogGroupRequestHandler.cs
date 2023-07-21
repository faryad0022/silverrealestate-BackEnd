using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogGroup;
using Application.DTOs.Blog.BlogGroup.Validators;
using Application.features.Blog.Request.Commands.BlogGroupCommands;
using AutoMapper;
using Domain.Entities.Blog;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Commands.BlogGroupCommands
{
    public class UpdateBlogGroupRequestHandler : IRequestHandler<UpdateBlogGroupRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateBlogGroupRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(UpdateBlogGroupRequest request, CancellationToken cancellationToken)
        {
            var blogGroup = await _unitofWork.BlogGroupRepository.GetEntityAsync(request.updateBlogGroupDTO.Id);

            if (blogGroup is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            #region Validation
            var validatore = new UpdateBlogGroupDTOValidator();
            var validatorResult = await validatore.ValidateAsync(request.updateBlogGroupDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(_mapper.Map<BlogGroupDTO>(request.updateBlogGroupDTO), StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<BlogGroup>(request.updateBlogGroupDTO);
            _unitofWork.BlogGroupRepository.UpdateEntity(toUpdate);
            await _unitofWork.SaveChangesAsync();
            var updatedDTO = _mapper.Map<BlogGroupDTO>(request.updateBlogGroupDTO);
            return ResponseResultDTO.SetResult(updatedDTO, StatusMessage.Success, null);
            throw new NotImplementedException();
        }
    }
}
