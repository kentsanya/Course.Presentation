using Course.Presentation.Logic.Interfaces;

namespace Course.Presentation.Logic.Services
{
    public class UTCTimeService : ITimerService
    {
        public string GetTime()
        {
            return DateTime.UtcNow.ToShortTimeString();
        }
    }
}
