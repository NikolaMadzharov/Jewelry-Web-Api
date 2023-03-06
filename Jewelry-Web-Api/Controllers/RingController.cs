using Jewelry_Web_Api.Contracts;
using Jewelry_Web_Api.Data;
using Jewelry_Web_Api.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Jewelry_Web_Api.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class RingController : ControllerBase
    {
        private readonly IRingService ringService;
      
        public RingController(IRingService ringService)
          
        {
            this.ringService = ringService;
           

        }

        [HttpGet]
        public async Task<IActionResult> AllRings()
        {
            var rings = await this.ringService.GetAllAsync();
            return Ok(rings);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRing(Ring ring)
        {
            await this.ringService.AddAsync(ring);
            return Ok(ring);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            await this.ringService.DeleteAsyc(id);

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRingById(int id)
        {
            var ring  =  await this.ringService.GetByIdAsync(id);
              
            return ring == null ? NotFound() : Ok(ring);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRing(Ring ring)
        {
           await this.ringService.UpdateProductAsync(ring);

            return Ok(ring);
        }
    }
}
