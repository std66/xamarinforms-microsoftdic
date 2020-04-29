using App.BusinessLogic.Services;
using App1.Services;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace App1 {
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage {
        private INotificationAdapterService notificationAdapter;

        public IHelloService HelloService { get; set; }
        public INotificationAdapterService NotificationAdapter { 
            get => notificationAdapter; 
            set {
                if (notificationAdapter != null) {
                    notificationAdapter.OnNotification -= OnNotification;
                }

                notificationAdapter = value;
                value.OnNotification += OnNotification;
            }
        }

        private async void OnNotification(object sender, (string title, string message) e) {
            await this.DisplayAlert(e.title, e.message, "Ok");
        }

        public MainPage() {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e) {
            await HelloService.GreetUser(Name.Text);
        }
    }
}
