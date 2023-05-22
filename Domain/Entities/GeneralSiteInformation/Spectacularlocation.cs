using System.Collections.Generic;

namespace Domain.Entities.GeneralSiteInformation
{
    public class Spectacularlocation : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<SpectacularLocationImages> spectacularLocationImages { get; set; }
    }
}
