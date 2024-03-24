using HouseRentingSystem.Core.Contracts.House;
using HouseRentingSystem.Core.Services.House;
using HouseRentingSystem.Infrastructure.Common;
using HouseRentingSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection  //change the namespace from HouseRentingSystem.Extensions
{
    public static class ServiceCollectionExtension  // extension is always static
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IHouseService, HouseService>(); // when we create HouseService.cs

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>(); // when we create Repository.cs

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;

            })
                    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddControllersWithViews();

            return services;
        }

    }
}
