using EShopApi.Services;
using EShopApi.Services.Account;
using EShopApi.Utilities.Constants;
using Microsoft.EntityFrameworkCore;

namespace EShopApi.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IAccountServices, AccountServices>();
            services.AddScoped<PaymentService>();

            services.AddDbContext<EShopContext>(opt => opt.UseSqlServer(
                config.GetConnectionString(SystemConstants.MainConnectionString)
            ));

            return services;
        }
    }
}
