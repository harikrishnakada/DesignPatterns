// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");
ILogger logger = new Logger();
var infoLogger = new InfoLogger();
var warnLogger = new WarnLogger();
var errorLogger = new ErrorLogger();
logger.SetNextLogger(infoLogger);
infoLogger.SetNextLogger(warnLogger);
warnLogger.SetNextLogger(errorLogger);

logger.Log(LogLevel.Info, "logmessage");

