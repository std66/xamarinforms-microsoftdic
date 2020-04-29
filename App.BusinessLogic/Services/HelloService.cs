using App.BusinessLogic.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.BusinessLogic.Services {
    public class HelloService : IHelloService {
        private readonly INotificationService notificationService;
        private readonly IClockService clockService;

        private readonly IReadOnlyDictionary<DayPartBE, string> messages = new Dictionary<DayPartBE, string>() {
            [DayPartBE.Afternoon] = "Have a nice day :)",
            [DayPartBE.Evening] = "Your bed is missing you :(",
            [DayPartBE.Midday] = "What are your lunch plans? ^^",
            [DayPartBE.Morning] = "How about a bit more sleep?",
            [DayPartBE.Night] = "Hey! Leave me alone! I want to sleep."
        };

        public HelloService(INotificationService notificationService, IClockService clockService) {
            this.notificationService = notificationService;
            this.clockService = clockService;
        }

        public Task GreetUser(string name) {
            return notificationService.Notify($"Hey, {name}!", messages[clockService.GetCurrentLocalDayPart()]);
        }
    }
}
