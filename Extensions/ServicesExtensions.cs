//using Microsoft.Azure.SignalR.Management;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore;
using WebApi;
using Sevices.Contracts;
using Presentation.Service;

namespace WebApi.Extensions
{
    public static class ServicesExtensions
    {
        // this kodu ifade genişletmek için
        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration) => services.AddDbContext<RepositoryContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManagerr, ServiceManager>();

    }
    
   
}