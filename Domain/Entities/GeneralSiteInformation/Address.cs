namespace Domain.Entities.GeneralSiteInformation
{
    public class Address : BaseEntity
    {
        public string Location { get; set; }
        public string CellPhone { get; set; }
        public string Telephone { get; set; }
        public string WorkHour { get; set; }
        public string Email { get; set; }
    }
}
