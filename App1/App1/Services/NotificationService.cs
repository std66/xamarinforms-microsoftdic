using App.BusinessLogic.Services;
using System;
using System.Threading.Tasks;

namespace App1.Services {
    class NotificationService : INotificationService, INotificationAdapterService {
        public event EventHandler<(string title, string message)> OnNotification;

        public Task Notify(string title, string message) {
            OnNotification?.Invoke(this, (title, message));
            return Task.CompletedTask;
        }
    }
}
