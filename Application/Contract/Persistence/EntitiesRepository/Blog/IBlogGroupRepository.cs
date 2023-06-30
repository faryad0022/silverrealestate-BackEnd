
using Application.Contract.Persistence.CommonGenericRepository;
using Domain.Entities.Blog;
using System.Threading.Tasks;

namespace Application.Contract.Persistance.EntitiesRepository.Blog
{
    public interface IBlogGroupRepository : IGenericRepository<BlogGroup>
    {
        Task<bool> IsDuplicate(string name);
    }
}
