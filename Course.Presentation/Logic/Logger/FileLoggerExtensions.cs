using System.Runtime.CompilerServices;

namespace Course.Presentation.Logic.Logger
{
    public static class FileLoggerExtensions
    {
        public static ILoggingBuilder AddFile(this ILoggingBuilder builder, string path) 
        {
            builder.AddProvider(new FileLogerProvider(path));
            return builder;
        }
    }
}
