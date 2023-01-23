namespace WebDriverNUnit.Utility
{
    using System;

    using log4net;

    /// <summary>
    /// The logger.
    /// </summary>
    public class Logger
    {
        private readonly ILog log;

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        internal Logger(Type type)
        {
            this.log = LogManager.GetLogger(type);
        }

        /// <summary>
        /// The info.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Info(string message)
        {
            this.log.Info(message);
        }

        /// <summary>
        /// The debug.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Debug(string message)
        {
            this.log.Debug(message);
        }

        /// <summary>
        /// The error.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Error(string message)
        {
            this.log.Error(message);
        }
    }
}
