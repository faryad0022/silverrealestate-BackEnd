using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Domain.Entities.GeneralSiteInformation;
using System;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Models.General.TeamMembers
{
    public static class TeamMemberModelGenerator
    {
        public static List<TeamMember> TeamMemberList = new()
        {
                new TeamMember
                {
                    Id = 1,
                    CellPhone = "09123071411",
                    MemberPicture = "faryad.jpg",
                    MemberPosition = "CEO",
                    Name = "Faryad",
                    Email="mahancomputer49@gmail.com",
                    CreateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false
                },
                new TeamMember
                {
                    Id = 2,
                    CellPhone = "09352499091",
                    MemberPicture = "farzad.jpg",
                    MemberPosition = "CEO",
                    Name = "Farzad",
                    Email="mahancomputer49@gmail.com",
                    CreateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false
                },
                new TeamMember
                {
                    Id = 3,
                    CellPhone = "09122895170",
                    MemberPicture = "mojgan.jpg",
                    MemberPosition = "Sell Manager",
                    Name = "Mojgan",
                    Email="mahancomputer49@gmail.com",
                    CreateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false
                },
                new TeamMember
                {
                    Id = 4,
                    CellPhone = "00905338355243",
                    MemberPicture = "payam.jpg",
                    MemberPosition = "Sell Manager",
                    Name = "Payam",
                    Email="mahancomputer49@gmail.com",
                    CreateDate = DateTime.Now,
                    IsSelected = false,
                    IsDelete = false
                }
        };


        public static CreateTeamMmeberDTO CreateTeamMmeberDTO_Valid = new()
        {
            CellPhone = "09125757063",
            MemberPicture = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAApgAAAKYB3X3/OAAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAANCSURBVEiJtZZPbBtFFMZ/M7ubXdtdb1xSFyeilBapySVU8h8OoFaooFSqiihIVIpQBKci6KEg9Q6H9kovIHoCIVQJJCKE1ENFjnAgcaSGC6rEnxBwA04Tx43t2FnvDAfjkNibxgHxnWb2e/u992bee7tCa00YFsffekFY+nUzFtjW0LrvjRXrCDIAaPLlW0nHL0SsZtVoaF98mLrx3pdhOqLtYPHChahZcYYO7KvPFxvRl5XPp1sN3adWiD1ZAqD6XYK1b/dvE5IWryTt2udLFedwc1+9kLp+vbbpoDh+6TklxBeAi9TL0taeWpdmZzQDry0AcO+jQ12RyohqqoYoo8RDwJrU+qXkjWtfi8Xxt58BdQuwQs9qC/afLwCw8tnQbqYAPsgxE1S6F3EAIXux2oQFKm0ihMsOF71dHYx+f3NND68ghCu1YIoePPQN1pGRABkJ6Bus96CutRZMydTl+TvuiRW1m3n0eDl0vRPcEysqdXn+jsQPsrHMquGeXEaY4Yk4wxWcY5V/9scqOMOVUFthatyTy8QyqwZ+kDURKoMWxNKr2EeqVKcTNOajqKoBgOE28U4tdQl5p5bwCw7BWquaZSzAPlwjlithJtp3pTImSqQRrb2Z8PHGigD4RZuNX6JYj6wj7O4TFLbCO/Mn/m8R+h6rYSUb3ekokRY6f/YukArN979jcW+V/S8g0eT/N3VN3kTqWbQ428m9/8k0P/1aIhF36PccEl6EhOcAUCrXKZXXWS3XKd2vc/TRBG9O5ELC17MmWubD2nKhUKZa26Ba2+D3P+4/MNCFwg59oWVeYhkzgN/JDR8deKBoD7Y+ljEjGZ0sosXVTvbc6RHirr2reNy1OXd6pJsQ+gqjk8VWFYmHrwBzW/n+uMPFiRwHB2I7ih8ciHFxIkd/3Omk5tCDV1t+2nNu5sxxpDFNx+huNhVT3/zMDz8usXC3ddaHBj1GHj/As08fwTS7Kt1HBTmyN29vdwAw+/wbwLVOJ3uAD1wi/dUH7Qei66PfyuRj4Ik9is+hglfbkbfR3cnZm7chlUWLdwmprtCohX4HUtlOcQjLYCu+fzGJH2QRKvP3UNz8bWk1qMxjGTOMThZ3kvgLI5AzFfo379UAAAAASUVORK5CYII=",
            MemberPosition = "CEO",
            Name = "Asghar",
            Email = "mahancomputer49@gmail.com",
        };
        public static CreateTeamMmeberDTO CreateTeamMmeberDTO_ValidationError_InValid = new()
        {
            CellPhone = "09125757063",
            MemberPicture = "asghar.jpg",
            MemberPosition = "CEO",
            Name = "",
        };

        public static UpdateTeamMemberDTO UpdateTeamMemberDTO_Valid = new()
        {
            Id = 4,
            CellPhone = "00905338355243",
            MemberPicture = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAApgAAAKYB3X3/OAAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAANCSURBVEiJtZZPbBtFFMZ/M7ubXdtdb1xSFyeilBapySVU8h8OoFaooFSqiihIVIpQBKci6KEg9Q6H9kovIHoCIVQJJCKE1ENFjnAgcaSGC6rEnxBwA04Tx43t2FnvDAfjkNibxgHxnWb2e/u992bee7tCa00YFsffekFY+nUzFtjW0LrvjRXrCDIAaPLlW0nHL0SsZtVoaF98mLrx3pdhOqLtYPHChahZcYYO7KvPFxvRl5XPp1sN3adWiD1ZAqD6XYK1b/dvE5IWryTt2udLFedwc1+9kLp+vbbpoDh+6TklxBeAi9TL0taeWpdmZzQDry0AcO+jQ12RyohqqoYoo8RDwJrU+qXkjWtfi8Xxt58BdQuwQs9qC/afLwCw8tnQbqYAPsgxE1S6F3EAIXux2oQFKm0ihMsOF71dHYx+f3NND68ghCu1YIoePPQN1pGRABkJ6Bus96CutRZMydTl+TvuiRW1m3n0eDl0vRPcEysqdXn+jsQPsrHMquGeXEaY4Yk4wxWcY5V/9scqOMOVUFthatyTy8QyqwZ+kDURKoMWxNKr2EeqVKcTNOajqKoBgOE28U4tdQl5p5bwCw7BWquaZSzAPlwjlithJtp3pTImSqQRrb2Z8PHGigD4RZuNX6JYj6wj7O4TFLbCO/Mn/m8R+h6rYSUb3ekokRY6f/YukArN979jcW+V/S8g0eT/N3VN3kTqWbQ428m9/8k0P/1aIhF36PccEl6EhOcAUCrXKZXXWS3XKd2vc/TRBG9O5ELC17MmWubD2nKhUKZa26Ba2+D3P+4/MNCFwg59oWVeYhkzgN/JDR8deKBoD7Y+ljEjGZ0sosXVTvbc6RHirr2reNy1OXd6pJsQ+gqjk8VWFYmHrwBzW/n+uMPFiRwHB2I7ih8ciHFxIkd/3Omk5tCDV1t+2nNu5sxxpDFNx+huNhVT3/zMDz8usXC3ddaHBj1GHj/As08fwTS7Kt1HBTmyN29vdwAw+/wbwLVOJ3uAD1wi/dUH7Qei66PfyuRj4Ik9is+hglfbkbfR3cnZm7chlUWLdwmprtCohX4HUtlOcQjLYCu+fzGJH2QRKvP3UNz8bWk1qMxjGTOMThZ3kvgLI5AzFfo379UAAAAASUVORK5CYII=",
            MemberPosition = "Sell Manager",
            Name = "Payam Abolhassani",
            Email = "mahancomputer49@gmail.com",
        };
        public static UpdateTeamMemberDTO UpdateTeamMemberDTO_NotFound_InValid = new()
        {
            Id = 40,
            CellPhone = "00905338355243",
            MemberPicture = "payam.jpg",
            MemberPosition = "Sell Manager",
            Name = "Payam Abolhassani",
        };
        public static UpdateTeamMemberDTO UpdateTeamMemberDTO_ValidationError_InValid = new()
        {
            Id = 4,
            CellPhone = "00905338355243",
            MemberPicture = "",
            MemberPosition = "",
            Name = "Payam Abolhassani",
        };


    }
}
