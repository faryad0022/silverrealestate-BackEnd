﻿namespace Application.DTOs.Paging
{
    public class Pager
    {
        public static BasePaging Build(int pageCount, int pageNumber, int take)
        {
            if (pageNumber <= 1)
                pageNumber = 1;
            return new BasePaging()
            {
                PageCount = pageCount,
                ActivePage = pageNumber,
                PageId = pageNumber,
                TakeEntity = take,
                SkipEntity = (pageNumber - 1) * take,
                StartPage = pageNumber - 3 <= 0 ? 1 : pageNumber - 3,
                EndPage = pageNumber + 3 > pageCount ? pageCount : pageNumber + 3
            };
        }
    }
}
