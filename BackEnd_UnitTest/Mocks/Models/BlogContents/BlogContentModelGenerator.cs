using Application.DTOs.Blog.BlogContent;
using Application.DTOs.Filters;
using Domain.Entities.Blog;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Mocks.Models.BlogContents
{
    public static class BlogContentModelGenerator
    {
        public static List<BlogContent> blogContentList = new()
        {
                new BlogContent
                {
                    Id=1,
                    BlogGroupId=1,
                    ImageName="hjgkjhgjhkgj",
                    Review="Source mode generates mock interfaces from a source file. It is enabled by using the -source flag. Other flags that",
                    Status=true,
                    Tags="jhgjhgjhg,kjhkjhk,ljkhjkh",
                    Text="jh,gkjhgkjhgjkh",
                    Title="Realistic Data Generation in .NET With Bogus",
                    ViewCount=50
                },
                new BlogContent
                {
                    Id=2,
                    BlogGroupId=1,
                    ImageName="hjgkjhgjhkgj",
                    Review="jkhgkjhgjhk",
                    Status=true,
                    Tags="Cyprus-Estate-Famagusta",
                    Text="jh,gkjhgkjhgjkh",
                    Title="What is Bogus?",
                    ViewCount=50
                },
                new BlogContent
                {
                    Id=3,
                    BlogGroupId=3,
                    ImageName="hjgkjhgjhkgj",
                    Review="jkhgkjhgjhk",
                    Status=true,
                    Tags="jhgjhgjhg,kjhkjhk,ljkhjkh",
                    Text="jh,gkjhgkjhgjkh",
                    Title="Why Use Bogus?",
                    ViewCount=50
                },
                new BlogContent
                {
                    Id=4,
                    BlogGroupId=1,
                    ImageName="hjgkjhgjhkgj",
                    Review="jkhgkjhgjhk",
                    Status=true,
                    Tags="jhgjhgjhg,kjhkjhk,ljkhjkh",
                    Text="jh,gkjhgkjhgjkh",
                    Title="Preparing the Environment",
                    ViewCount=50
                },
                new BlogContent
                {
                    Id=5,
                    BlogGroupId=1,
                    ImageName="hjgkjhgjhkgj",
                    Review="jkhgkjhgjhk",
                    Status=true,
                    Tags="jhgjhgjhg,kjhkjhk,ljkhjkh",
                    Text="jh,gkjhgkjhgjkh",
                    Title="Bogus",
                    ViewCount=50
                },
                new BlogContent
                {
                    Id=6,
                    BlogGroupId=2,
                    ImageName="hjgkjhgjhkgj",
                    Review="jkhgkjhgjhk",
                    Status=true,
                    Tags="jhgjhgjhg,kjhkjhk,ljkhjkh",
                    Text="jh,gkjhgkjhgjkh",
                    Title="Specifying Bogus Rules",
                    ViewCount=50
                },
            };
        public static List<BlogContentDTO> blogContentListDTO = new()
        {
                new BlogContentDTO
                {
                    Id=1,
                    BlogGroupId=1,
                    ImageName="hjgkjhgjhkgj",
                    Status=true,
                    Tags="jhgjhgjhg,kjhkjhk,ljkhjkh",
                    Text="jh,gkjhgkjhgjkh",
                    Title="Realistic Data Generation in .NET With Bogus",
                    ViewCount=50
                },
                new BlogContentDTO
                {
                    Id=2,
                    BlogGroupId=1,
                    ImageName="hjgkjhgjhkgj",
                    Status=true,
                    Tags="Cyprus-Estate-Famagusta",
                    Text="jh,gkjhgkjhgjkh",
                    Title="What is Bogus?",
                    ViewCount=50
                },
                new BlogContentDTO
                {
                    Id=4,
                    BlogGroupId=1,
                    ImageName="hjgkjhgjhkgj",
                    Status=true,
                    Tags="jhgjhgjhg,kjhkjhk,ljkhjkh",
                    Text="jh,gkjhgkjhgjkh",
                    Title="Preparing the Environment",
                    ViewCount=50
                },
                new BlogContentDTO
                {
                    Id=5,
                    BlogGroupId=1,
                    ImageName="hjgkjhgjhkgj",
                    Status=true,
                    Tags="jhgjhgjhg,kjhkjhk,ljkhjkh",
                    Text="jh,gkjhgkjhgjkh",
                    Title="Bogus",
                    ViewCount=50
                },

            };

        public static CreateBlogContentDTO _createBlogContentDTO_Valid = new CreateBlogContentDTO
        {
            BlogGroupId = 1,
            ImageName = "faryad.jpg",
            Tags = "cyprus-Villa",
            Text = "jhgkjvgvlkjlkjlkjlkjljlgkgkdddr",
            Title = "jjljhkjk"
        };
        public static CreateBlogContentDTO _createBlogContentDTO_EmptyBlogGroupId_InValid = new CreateBlogContentDTO
        {
            ImageName = "sfgdsgdfljjkkjydfhdfh",
            Tags = "kjhkjhkjh",
            Text = "jhgkjvgvlkjlkjlkjlkjljlgkgkdddr",
            Title = "jjljhkjk"
        };
        public static CreateBlogContentDTO _createBlogContentDTO_NotExistBlogGroup_InValid = new CreateBlogContentDTO
        {
            BlogGroupId = 20,
            ImageName = "sfgdsgdfljjkkjydfhdfh",
            Tags = "kjhkjhkjh",
            Text = "jhgkjvgvlkjlkjlkjlkjljlgkgkdddr",
            Title = "jjljhkjk"
        };

        public static UpdateBlogContentDTO _updateBlogContentDTO_Valid = new UpdateBlogContentDTO
        {
            Id = 1,
            BlogGroupId = 1,
            ImageName = "asdfasdfasf",
            Tags = "kjhksdasdjhkjh",
            Text = "welcome to north cyprus mother fuckers",
            Title = "Welcome Hosgaldiniz"
        };

        public static List<BlogContent> MappingBlogContent(List<BlogContentDTO> blogContents)
        {
            var blogContentList = new List<BlogContent>();
            foreach (var item in blogContents)
            {
                var blogContent = new BlogContent
                {
                    Id = item.Id,
                    Status = item.Status,
                    BlogGroupId = item.BlogGroupId,
                    BlogGroupName = item.BlogGroupName,
                    IsSelected = item.IsSelected,
                    Tags = item.Tags,
                    ImageName = item.ImageName,
                    Text = item.Text,
                    Title = item.Title,
                    ViewCount = item.ViewCount,
                };
                blogContentList.Add(blogContent);
            }
            return blogContentList;
        }
        public static FilterBlogContentDTO filterBlogContent_ById_Valid = new FilterBlogContentDTO
        {
            BlogGroupId = 1,
        };
        public static FilterBlogContentDTO filterBlogContent_ByTitle_blogList_Valid = new FilterBlogContentDTO
        {
            Title = "Bogus",
            BlogGroupId = 1,
            BlogContentList = blogContentListDTO
        };


        public static ChangeBlogContentStatusDTO changeBlogContentStatusDTO_Valid = new()
        {
            Id = 1,
            Status = true
        };

        public static ChangeBlogContentIsSelectedDTO changeBlogContentIsSelectedDTO_Valid = new()
        {
            Id = 1,
            IsSelected = true
        };
    }
}
