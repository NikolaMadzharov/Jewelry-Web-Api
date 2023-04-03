using Jewelry_Web_Api.Data.Models;

namespace Jewelry_Web_Api.Contracts
{
    public interface IRingService
    {
        Task<IEnumerable<Ring>> GetAllAsync();


        Task<Ring> GetByIdAsync(int id);

        Task DeleteAsyc(int id);

        Task<Ring> UpdateProductAsync(Ring product, int ringId);

         Task<Ring> AddAsync(Ring product);  

    }
}
