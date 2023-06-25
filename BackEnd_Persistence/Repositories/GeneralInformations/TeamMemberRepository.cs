using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using Application.DTOs.Paging;
using Application.Extensions;
using Application.Models.FilterModels;
using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.GeneralInformations
{
    public class TeamMemberRepository : GenericRepository<TeamMember>, ITeamMemberRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public TeamMemberRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<FilterTeamMember> FilterTeamMembers(FilterTeamMember filter)
        {
            var teamMemberQuery = GetEntitiesQuery().AsQueryable();
            if (!string.IsNullOrEmpty(filter.Name))
                teamMemberQuery = teamMemberQuery.Where(n => n.Name.Contains(filter.Name));
            if (!string.IsNullOrEmpty(filter.CellPhone))
                teamMemberQuery = teamMemberQuery.Where(c => c.CellPhone.Contains(filter.CellPhone));
            if (!string.IsNullOrEmpty(filter.MemberPosition))
                teamMemberQuery = teamMemberQuery.Where(m => m.MemberPosition.Contains(filter.MemberPosition));
            if (!string.IsNullOrEmpty(filter.Email))
                teamMemberQuery = teamMemberQuery.Where(e => e.Email.Contains(filter.Email));

            teamMemberQuery = teamMemberQuery.Where(x => x.IsDelete == filter.IsDelete);
            teamMemberQuery = teamMemberQuery.Where(x => x.IsSelected == filter.IsSelected);

            var count = (int)Math.Ceiling(teamMemberQuery.Count() / (double)filter.TakeEntity);
            var pager = Pager.Build(count, filter.PageId, filter.TakeEntity);
            var teamMembers = await teamMemberQuery.Paging(pager).ToListAsync();
            return filter.SetPaging(pager).SetTeamMembers(teamMembers);
        }
    }
}
