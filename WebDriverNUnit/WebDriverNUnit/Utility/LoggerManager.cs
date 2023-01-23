namespace WebDriverNUnit.Utility
{
    using System;
    using System.IO;
    using log4net.Config;

    public static class LoggerManager
    {
        /// <summary>
        /// Initializes static members of the <see cref="LoggerManager"/> class.
        /// </summary>
        static LoggerManager()
        {
            XmlConfigurator.Configure(new FileInfo("D:\\EPAM\\TA\\temp\\ATMP-khl-module14\\WebDriverNUnit\\WebDriverNUnit\\Log.config"));
        }

        /// <summary>
        /// The get logger.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The <see cref="Logger"/>.</returns>
        public static Logger GetLogger(Type type)
        {
            return new Logger(type);
        }
    }
}
