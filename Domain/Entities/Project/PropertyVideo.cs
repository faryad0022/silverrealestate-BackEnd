namespace Domain.Entities.Project
{
    public class PropertyVideo : BaseEntity
    {
        public string VideoLink { get; set; }
        public long PropertyId { get; set; }
        public Property ProPerty { get; set; }
    }
}
