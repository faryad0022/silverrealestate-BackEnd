using Application.DTOs.Paging;
using System.Linq;

namespace Application.Extensions
{
    public static class PagingExtension
    {
        public static IQueryable<T> Paging<T>(this IQueryable<T> queryable, BasePaging pager)
        {
            return queryable.Skip(pager.SkipEntity).Take(pager.TakeEntity);
        }
    }
}
