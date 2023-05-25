using Application.Contract.Persistance.EntitiesRepository.Blog;
using Application.DTOs.Blog.BlogGroup;
using Domain.Entities.Blog;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.Blogs
{
    public class BlogGroupRepository : GenericRepository<BlogGroup>, IBlogGroupRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public BlogGroupRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> IsDuplicate(string name)
        {
            var blogGroup = await _dbContext.BlogGroups.FirstOrDefaultAsync(x => x.Name == name);
            if (blogGroup == null) { return false; }
            return true;
        }
    }
}
