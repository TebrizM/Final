using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class PaginatedList<T> : List<T>
    {
        public PaginatedList(List<T> items, int count, int pageindex, int pageSize)
        {

            this.PageIndex = pageindex;
            this.TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
            this.PageSize = pageSize;

        }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasNext => PageIndex < TotalPages;
        public bool HasPre => PageIndex > 1;

        public static PaginatedList<T> Create(IQueryable<T> query, int pageIndex, int pageSize)
        {
            var items = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return new PaginatedList<T>(items, query.Count(), pageIndex, pageSize);
        }
    }
}
