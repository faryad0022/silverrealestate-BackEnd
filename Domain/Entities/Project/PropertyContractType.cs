using System.Collections.Generic;

namespace Domain.Entities.Project
{
    public class PropertyContractType : BaseEntity
    {
        public string ContractType { get; set; }//Sell,Rent,PreSell...
        public ICollection<Property> Properties { get; set; }
    }
}
