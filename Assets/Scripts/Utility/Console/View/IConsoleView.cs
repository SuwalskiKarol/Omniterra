using System.Collections.Generic;

namespace Scripts.Utility.Console {
    /// <summary>
    /// Interface for ConsoleView
    /// </summary>
    public interface IConsoleView {
        /// <summary>
        /// Initialize Console view (location and size)
        /// </summary>
        /// <param name="rect">Container with location and size</param>
        /// <returns></returns>
        bool InitializeView ( UnityEngine.Rect rect );
        /// <summary>
        /// Show all logs in console.
        /// </summary>
        /// <param name="messages">List of showing messages.</param>
        void ShowAllLogs ( List<Message> messages );
    }
}
