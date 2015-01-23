using System;
using System.IO;
using log4net;

namespace Log4Net.Wrapper
{
    public static class Logger
    {
        private static readonly ILog Instance = LogManager.GetLogger("Log4Net");

        static Logger()
        {
            string logFilePath = AppDomain.CurrentDomain.BaseDirectory + @"Log4Net.Config";
            FileInfo finfo = new FileInfo(logFilePath);
            GlobalContext.Properties["LogFolder"] = AppDomain.CurrentDomain.BaseDirectory + @"Logs\";
            log4net.Config.XmlConfigurator.ConfigureAndWatch(finfo); 
        }

        public static void Info(object message)
        {
            Instance.Info(message);
        }

        public static void Debug(object message)
        {
            Instance.Debug(message);
        }

        public static void Error(Exception exception, object message = null)
        {
            Instance.Error(message, exception);
        }

        public static void Fatal(Exception exception, object message = null)
        {
            Instance.Fatal(message, exception);
        }

    }
}
