using App.BusinessLogic.Entities;
using System;

namespace App.BusinessLogic.Services {
    public class ClockService : IClockService {
        public DayPartBE GetCurrentLocalDayPart() {
            DateTime time = DateTime.Now;

            if (time.Hour >= 23 && time.Hour < 6)
                return DayPartBE.Night;
            else if (time.Hour >= 6 && time.Hour < 12)
                return DayPartBE.Morning;
            else if (time.Hour >= 12 && time.Hour < 13)
                return DayPartBE.Midday;
            else if (time.Hour >= 13 && time.Hour < 20)
                return DayPartBE.Afternoon;
            else
                return DayPartBE.Evening;
        }
    }
}
