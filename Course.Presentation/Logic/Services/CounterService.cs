using Course.Presentation.Logic.Interfaces;

namespace Course.Presentation.Logic.Services
{
    public class CounterService
    {
        public ICounter _counter { get; }
        public CounterService(ICounter counter)
        {
            _counter= counter;
        }
    }
}
