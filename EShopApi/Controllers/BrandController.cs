using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EShopApi.Controllers
{
    public class BrandController : BaseApiController
    {
        private readonly EShopContext _context;

        public BrandController(EShopContext context)
        {
            _context = context;
        }
        [HttpGet("GetBrand")]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
        {
            return await _context.Brands.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Brand>> CreateBrands(string nameBrand)
        {
            var brand = new Brand
            {
                Name = nameBrand,
            };

            await _context.Brands.AddAsync(brand);

            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpPut]
        public async Task<ActionResult> UpdateBrand(Brand brand)
        {

            _context.Brands.Update(brand);

            await _context.SaveChangesAsync();
            return Ok();

        }
    }
}
