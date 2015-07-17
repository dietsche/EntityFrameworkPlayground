using System;

namespace EntityFrameworkPlayground.Abstract
{
    /// <summary>
    ///     A very simple logger
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        ///     Record a message in the log
        /// </summary>
        /// <param name="message">your message</param>
        void Log(string message);

        /// <summary>
        ///     Record an exception in the log
        /// </summary>
        /// <param name="exception">the exception</param>
        void Log(Exception exception);
    }
}