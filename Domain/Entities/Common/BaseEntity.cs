using System;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public bool IsDelete { get; set; }
        public bool IsSelected { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
