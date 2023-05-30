using RealEstateUI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateUI.Contract
{
    public interface IConstructorInformationService
    {
        Task<IReadOnlyList<ConstructorVM>> GetAllConstructorAsync();
    }
}
