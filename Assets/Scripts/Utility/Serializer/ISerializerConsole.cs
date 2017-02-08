using System.Collections.Generic;

namespace Scripts.Utility.Serializer {
    /// <summary>
    /// Interface for handling serialization Console
    /// </summary>
    public interface ISerializerConsole {
        /// <summary>
        /// This function will save a consoles configuration.
        /// </summary>
        /// <param name="myConsole">Console configuration file</param>
        /// <returns>If all operations going without errors: TRUE.
        /// If any operation going with any errors: FALSE.</returns>
        bool SaveConsoleConfig ( Console.ConsoleConfig myConsole );
        /// <summary>
        /// Load existing configuration for console.
        /// </summary>
        /// <returns>Console Configuration</returns>
        Console.ConsoleConfig LoadConsoleConfig ();

        /// <summary>
        /// Save all logs from this session.
        /// </summary>
        /// <param name="name">Log file name</param>
        /// <param name="logs">List of all logs</param>
        /// <returns>If all operations going without errors: TRUE.
        /// If any operation going with any errors: FALSE.</returns>
        bool SaveLogFile ( string name, List<Console.Message> logs );
    }
}
