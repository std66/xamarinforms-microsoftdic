using System.Threading.Tasks;

namespace App.BusinessLogic.Services {
    public interface IHelloService {
        Task GreetUser(string name);
    }
}