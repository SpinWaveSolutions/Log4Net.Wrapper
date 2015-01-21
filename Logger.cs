using System;
using System.IO;
using System.Reflection;
using log4net;

namespace Log4Net
{
    public static class Logger
    {
        private static readonly ILog _instance = LogManager.GetLogger("Log4NetClient");

        static Logger()
        {
            string logFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Log4Net.Config";
            FileInfo finfo = new FileInfo(logFilePath);
            GlobalContext.Properties["LogFolder"] = Path.GetDirectoryName(Assembly.GetCallingAssembly().CodeBase) + "\\Log4Net\\";
            log4net.Config.XmlConfigurator.ConfigureAndWatch(finfo); 
        }

        public static ILog Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
