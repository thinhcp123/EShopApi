namespace EShopApi.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly EShopContext _context;

        public BasketController(EShopContext context)
        {
            _context = context;
        }


    }
}
