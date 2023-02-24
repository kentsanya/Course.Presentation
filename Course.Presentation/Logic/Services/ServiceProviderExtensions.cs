using Course.Presentation.Logic.Interfaces;

namespace Course.Presentation.Logic.Services
{
    public static class ServiceProviderExtensions
    {
        public static void AddTimeService(this IServiceCollection service) 
        {
            service.AddTransient<ITimerService, LocalTimeService>();
        }
    }
}
