using Application.DTOs.Common;

namespace Application.DTOs.Project.PropertyContractType
{
    public class UpdatePropertyContractTypeDTO : BaseEntityDTO, IPropertyContractTypeDTO
    {
        public string ContractType { get; set; }//Sell,Rent,PreSell...

    }
}
