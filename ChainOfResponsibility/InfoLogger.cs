using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class InfoLogger : ILogger
    {
        private ILogger _nextLogger;

        public void Log(LogLevel level, string message)
        {
            if (level == LogLevel.Info)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(message);
            }
            else
            {
                this._nextLogger.Log(level, message);
            }
        }

        public void SetNextLogger(ILogger logger)
        {
            this._nextLogger = logger;
        }
    }
}
