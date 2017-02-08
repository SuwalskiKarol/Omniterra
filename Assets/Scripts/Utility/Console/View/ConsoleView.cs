using System.Collections.Generic;

namespace Scripts.Utility.Console {
    /// <summary>
    /// Abstract class for view of console. This class implements IConsoleView.
    /// </summary>
    public abstract class ConsoleView : IConsoleView {
        /// <summary>
        /// Initialize Console view (location and size)
        /// </summary>
        /// <param name="rect">Container with location and size</param>
        /// <returns></returns>
        public abstract bool InitializeView ( UnityEngine.Rect rect );
        /// <summary>
        /// Show all logs in console.
        /// </summary>
        /// <param name="messages">List of showing messages.</param>
        public abstract void ShowAllLogs ( List<Message> messages );
    }
}
