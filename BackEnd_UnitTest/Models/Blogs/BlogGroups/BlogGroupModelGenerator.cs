using Application.DTOs.Blog.BlogGroup;
using Domain.Entities.Blog;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Models.Blogs.BlogGroups
{
    public static class BlogGroupModelGenerator
    {
        public static List<BlogGroup> blogGroupList = new List<BlogGroup>
            {
                new BlogGroup
                {
                     Id = 1,
                     Name = "News",
                     BlogContents = new List<BlogContent>
                     {
                         new BlogContent
                         {
                             Id=1,
                             BlogGroupId=1,
                             ImageName="adfasdfasdfw",
                             IsSelected=true,
                             Status=true,
                             Tags="dasds,qwerwr,bdfbgdfgb,qwerwerq,bdbdfg",
                             Title="Cyprus News",
                             Text="asdfadfasdjkcbwlcjkbecljikebiebebjhbjhed"

                         }
                     },
                     IsDelete=false
                },
                new BlogGroup
                {
                     Id = 2,
                     Name = "News 2",
                     BlogContents = new List<BlogContent>
                     {
                         new BlogContent
                         {
                             Id=2,
                             BlogGroupId=2,
                             ImageName="adfasdfasdfw",
                             IsSelected=true,
                             Status=true,
                             Tags="dasds,qwerwr,bdfbgdfgb,qwerwerq,bdbdfg",
                             Title="Cyprus News BlogGroup 22",
                             Text="asdfadfasdjkcbwlcjkbecljikebiebebjhbjhed"
                         }
                     },
                     IsDelete=false
                },
                new BlogGroup
                {
                     Id = 3,
                     Name = "News 3",
                     BlogContents = new List<BlogContent>
                     {
                         new BlogContent
                         {
                             Id=3,
                             BlogGroupId=3,
                             ImageName="adfasdfasdfw",
                             IsSelected=true,
                             Status=true,
                             Tags="dasds,qwerwr,bdfbgdfgb,qwerwerq,bdbdfg",
                             Title="Cyprus News 3",
                             Text="asdfadfasdjkcbwlcjkbecljikebiebebjhbjhed"

                         },
                         new BlogContent
                         {
                             Id=4,
                             BlogGroupId=3,
                             ImageName="adfasdfasdfw",
                             IsSelected=true,
                             Status=true,
                             Tags="dasds,qwerwr,bdfbgdfgb,qwerwerq,bdbdfg",
                             Title="Cyprus News 3 4",
                             Text="asdfadfasdjkcbwlcjkbecljikebiebebjhbjhed"
                         }
                     },
                     IsDelete=false
                },

            };
        public static CreateBlogGroupDTO _createBlogGroupDTO_Valid = new CreateBlogGroupDTO
        {
            Name = "News 6"
        };
        public static CreateBlogGroupDTO _createBlogGroupDTO_InValid = new CreateBlogGroupDTO
        {
            Name = "News 3"
        };
    }
}
