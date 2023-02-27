using NLog;
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Platform.Utils
{
    public static class Log<T>
    {
        static ILogger logger;

        static Log()
        {
            logger = LogManager.GetLogger(typeof(T).Name, typeof(T));
        }

        public static void Debug(object message)
        {
            logger.Debug(message);
        }

        public static void Info(object message)
        {
            logger.Info(message);
        }

        public static void Error(object message)
        {
            logger.Error(message);
        }

    }
}
