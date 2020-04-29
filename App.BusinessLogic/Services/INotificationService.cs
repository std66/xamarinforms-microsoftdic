using System.Threading.Tasks;

namespace App.BusinessLogic.Services {
    public interface INotificationService {
        Task Notify(string title, string message);
    }
}