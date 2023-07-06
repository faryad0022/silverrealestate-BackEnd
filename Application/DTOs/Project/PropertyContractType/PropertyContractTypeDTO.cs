using Application.DTOs.Common;

namespace Application.DTOs.Project.PropertyContractType
{
    public class PropertyContractTypeDTO : BaseEntityDTO
    {
        public string ContractType { get; set; }//Sell,Rent,PreSell...
    }
}
