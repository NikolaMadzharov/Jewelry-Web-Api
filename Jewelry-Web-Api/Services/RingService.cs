using Jewelry_Web_Api.Contracts;
using Jewelry_Web_Api.Data;
using Jewelry_Web_Api.Data.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Jewelry_Web_Api.Services
{
    public class RingService : IRingService
    {

        private WebApiContext webApiContext;

        public RingService(WebApiContext webApiContext)
        {
            this.webApiContext = webApiContext;
        }

        public async Task<Ring> AddAsync(Ring product)
        {
            var ring = new Ring
            {
                Id = product.Id,
                Price = product.Price,
                Description = product.Description,
                Size = product.Size,
                Type = product.Type,
                Name = product.Name,
                Url = product.Url,
            };

            await this.webApiContext.AddAsync(ring);
            await this.webApiContext.SaveChangesAsync();

            return ring;

        }

        public async Task DeleteAsyc(int id)
        {
            var ring = await this.webApiContext.Rings.FirstOrDefaultAsync(x => x.Id == id);

            if (ring == null)
            {
                throw new ArgumentException();
            }

            this.webApiContext.Rings.Remove(ring);
            await this.webApiContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Ring>> GetAllAsync()
          => await this.webApiContext.Rings.ToListAsync();


        public async Task<Ring> GetByIdAsync(int id)
        {
            var ring = await this.webApiContext.Rings.FirstOrDefaultAsync(x => x.Id == id);

            if (ring == null)
            {
                throw new ArgumentException();
            }

            return ring;
        }

        public async Task<Ring> UpdateProductAsync(Ring product, int ringId)
        {
            var ring = await this.webApiContext.Rings.FirstOrDefaultAsync(x => x.Id == ringId);


            if (ring == null)
            {

                throw new NullReferenceException("Employee not found!");

            }

            if (ring != null)
            {
                ring.Type = product.Type;
                ring.Size = product.Size;
                ring.Price = product.Price;
                ring.Description = product.Description;
                ring.Name = product.Name;
                ring.Url = product.Url;

                await this.webApiContext.SaveChangesAsync();
            }



            return ring;
        }
    }
}
