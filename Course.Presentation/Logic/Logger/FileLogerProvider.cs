namespace Course.Presentation.Logic.Logger
{
    public class FileLogerProvider : ILoggerProvider
    {
        string path;
        public FileLogerProvider(string path) 
        {
            this.path = path;
        }
        public ILogger CreateLogger(string categoryName)
        {
            return new FileLoger(path);
        }

        public void Dispose()
        {
            
        }
    }
}
