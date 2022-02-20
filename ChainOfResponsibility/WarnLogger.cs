using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ErrorLogger: ILogger
    {
        private ILogger _nextLogger;

        public void Log(LogLevel level, string message)
        {
            if (level == LogLevel.Error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
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
