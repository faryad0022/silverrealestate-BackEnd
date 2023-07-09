namespace Domain.Entities.Project
{
    public class PropertyVideo : BaseEntity
    {
        public string YoutubeLinlk { get; set; }
        public string AparatLinlk { get; set; }

        public long PropertyId { get; set; }

        public Property ProPerty { get; set; }
    }
}
