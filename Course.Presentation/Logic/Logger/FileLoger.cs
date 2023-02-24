namespace Course.Presentation.Logic.Logger
{
    public class FileLoger:ILogger, IDisposable
    {
       
        string _path;
        static object _lock = new();
        public FileLoger(string path) 
        {
            _path = path;
        }
        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            lock (_lock) 
            {
                File.AppendAllText(_path, $"{formatter(state, exception)} {Environment.NewLine}");
            }
        }
        public IDisposable BeginScope<TState>(TState state)
        {
            return this;
        }
        public void Dispose()
        {
            
        }

    }
}
