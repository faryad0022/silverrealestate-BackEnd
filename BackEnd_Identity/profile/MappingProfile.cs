using Application.Models.Identity;
using AutoMapper;
using BackEnd_Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_Identity.profile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region User
            CreateMap<ApplicationUserRole, UserRoleDTO>()
                .ForMember(dest => dest.RoleName, opt =>
                {
                    opt.MapFrom(src => src.Role.Name);
                })
                .ForMember(dest => dest.UserName, opt =>
                {
                    opt.MapFrom(src => src.User.UserName);
                }).ReverseMap();


            CreateMap<ApplicationUser, RegisteredUserDTO>()
                .ForMember(dest => dest.UserName, opt =>
                {
                    opt.MapFrom(src => src.UserName);
                })
                .ForMember(dest => dest.FirstName, opt =>
                {
                    opt.MapFrom(src => src.FirstName);
                })
                .ReverseMap();


            CreateMap<ApplicationUser, CurrentUserDTO>().ReverseMap();

            #endregion

            #region Role
            CreateMap<ApplicationRole, RoleDTO>()
                .ForMember(dest => dest.RoleName, opt =>
                {
                    opt.MapFrom(src => src.Name);
                })
                .ForMember(dest=>dest.RoleId, opt =>
                {
                    opt.MapFrom(src => src.Id);
                })
                .ReverseMap();
            #endregion
        }
    }
}
