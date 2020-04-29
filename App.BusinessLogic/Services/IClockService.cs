using App.BusinessLogic.Entities;

namespace App.BusinessLogic.Services {
    public interface IClockService {
        DayPartBE GetCurrentLocalDayPart();
    }
}