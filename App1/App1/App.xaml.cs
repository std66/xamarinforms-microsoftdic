using App.BusinessLogic;
using App.BusinessLogic.Services;
using App1.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xamarin.Forms;

namespace App1 {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            IServiceCollection serviceCollection = ConfigureServices();
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            MainPage = serviceProvider.GetService<MainPage>();
        }

        private IServiceCollection ConfigureServices() {
            return new ServiceCollection()
                .AddBusinessLogic(provider => provider.GetService<NotificationService>())

                .AddSingleton<NotificationService>()
                .AddSingleton<MainPage>(provider => {
                    MainPage page = new MainPage() {
                        HelloService = provider.GetService<IHelloService>(),
                        NotificationAdapter = provider.GetService<NotificationService>()
                    };

                    return page;
                });
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}
