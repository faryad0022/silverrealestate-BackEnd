namespace Domain.Entities.Project
{
    public class PropertyVideo : BaseEntity
    {
        public string VideoName { get; set; }
        public long PropertyId { get; set; }

        public Property ProPerty { get; set; }
    }
}
