using App.BusinessLogic.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace App.BusinessLogic {
    public static class IServiceCollectionExtensions {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services, Func<IServiceProvider, INotificationService> notificationServiceFactory) {
            return services
                .AddSingleton(notificationServiceFactory)
                .AddSingleton<IClockService, ClockService>()
                .AddSingleton<IHelloService, HelloService>();
        }
    }
}
