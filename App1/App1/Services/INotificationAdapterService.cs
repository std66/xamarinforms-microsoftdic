using System;

namespace App1.Services {
    public interface INotificationAdapterService {
        event EventHandler<(string title, string message)> OnNotification;
    }
}