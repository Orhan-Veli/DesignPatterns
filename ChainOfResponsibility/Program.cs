using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger loggerChain = GetChainOfLoggers();
            loggerChain.LogMessage((int)Errors.Info,"this is info");

            loggerChain.LogMessage((int)Errors.Debug,"this is an debug level");

            loggerChain.LogMessage((int)Errors.Error, "this is an error info");
        }
        
        private static AbstractLogger GetChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger((int)Errors.Error);
            AbstractLogger fileLogger = new FileLogger((int)Errors.Debug);
            AbstractLogger consoleLogger = new ConsoleLogger((int)Errors.Info);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }
    }

    public abstract class AbstractLogger
    {
        protected int level;
        protected AbstractLogger nextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void LogMessage(int level,string message)
        {
            if(this.level <= level)
            {
                Write(message);
            }
            if(nextLogger != null)
            {
                nextLogger.LogMessage(level,message);
            }
        }

        abstract protected void Write(string message);
    }

public class ConsoleLogger : AbstractLogger{
    public ConsoleLogger(int level)
    {
        this.level = level;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("StandartLogger " + message);
    }
}

public class ErrorLogger : AbstractLogger
{
    public ErrorLogger(int level)
    {
        this.level = level;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("Error Console "+ message);
    }
}

public class FileLogger : AbstractLogger
{
    public FileLogger(int level)
    {
        this.level = level;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("File logger "+ message);
    }
}

    public enum Errors
    {
        Info=1,Debug=2,Error=3
    }
}
