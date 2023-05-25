
using Application.Contract.Persistence.CommonGenericRepository;
using Application.DTOs.Blog.BlogGroup;
using Domain.Entities.Blog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Persistance.EntitiesRepository.Blog
{
    public interface IBlogGroupRepository : IGenericRepository<BlogGroup>
    {
        Task<bool> IsDuplicate(string name);
    }
}
