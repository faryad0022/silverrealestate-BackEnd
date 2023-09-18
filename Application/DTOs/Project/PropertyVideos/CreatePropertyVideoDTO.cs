namespace Application.DTOs.Project.PropertyVideos
{
    public class CreatePropertyVideoDTO : IPropertyVideoDTO
    {
        public string VideoLink { get; set; }
        public long PropertyId { get; set; }
    }
}
