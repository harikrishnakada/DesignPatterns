using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public enum LogLevel
    {
        Info,
        Warn,
        Error,
    }

    public interface ILogger
    {
        public void Log(LogLevel level, string message);

        public void SetNextLogger(ILogger logger);
    }

    public class Logger : ILogger
    {
        private ILogger _nextLogger;

        public void Log(LogLevel level, string message)
        {
            this._nextLogger.Log(level, message);
        }

        public void SetNextLogger(ILogger logger)
        {
            this._nextLogger = logger;
        }
    }
}
