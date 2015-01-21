using System.IO;
using log4net.Util;

namespace Log4Net
{
    public class CustomPatternConverter : PatternConverter
    {
        protected override void Convert(TextWriter writer, object state)
        {
            log4net.Core.LoggingEvent loggingEvent = (log4net.Core.LoggingEvent) state;
            string method = loggingEvent.LocationInformation.ClassName + "." + loggingEvent.LocationInformation.MethodName;
            writer.Write(method);
        }
    }
}
