using DailyFocus.Application.Interfaces;
using DailyFocus.Application.Services;

namespace DailyFocus.Web.Extensions.DependencyInjection
{
    public static class DailyFocusServiceCollectionExtension
    {
        public static IServiceCollection AddDailyFocusServices(this IServiceCollection services)
        {
            // Register application services
            services.AddScoped<ITaskService, TaskService>();
            //// Register infrastructure services
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer("YourConnectionStringHere"));
            //// Register controllers
            //services.AddControllersWithViews();
            return services;
        }
    }
}
