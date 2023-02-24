using Course.Presentation.Logic.Interfaces;

namespace Course.Presentation.Logic.Services
{
    public class LocalTimeService : ITimerService
    {
        public string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
