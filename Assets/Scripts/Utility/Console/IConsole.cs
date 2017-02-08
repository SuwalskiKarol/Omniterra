namespace Scripts.Utility.Console {
    /// <summary>
    /// Interface handling console
    /// </summary>
    public interface IConsole {
        /// <summary>
        /// Here You can add log to console (communication beetwen Game and User, or beetwen Users)
        /// </summary>
        /// <param name="message">Message content</param>
        /// <returns></returns>
        bool AddLog ( Message message );
        /// <summary>
        /// Show console
        /// </summary>
        void Show ();
        /// <summary>
        /// Set consoles visible state
        /// </summary>
        /// <param name="newState">New console state</param>
        void SetVisible (bool newState);
        /// <summary>
        /// This function set all parameters for console showing in game menu. This function is TESTING FUNCTION! (leter this will to be deleted)
        /// </summary>
        void SetMenuConsole ();

        /// <summary>
        /// Set horizontal location for console
        /// </summary>
        /// <param name="x">Position in percentage (Range: 0 - 1)</param>
        void SetXPosition (float x);
        /// <summary>
        /// Set vertical location for console
        /// </summary>
        /// <param name="y">Position in percentage (Range: 0 - 1)</param>
        void SetYPosition (float y);
        /// <summary>
        /// Set width for console
        /// </summary>
        /// <param name="width">Width in in percentage (Range: 0 - 1)</param>
        void SetWidth ( float width );
        /// <summary>
        /// Set height for console
        /// </summary>
        /// <param name="height">Height in percentage (Range: 0 - 1)</param>
        void SetHeight ( float height );
        /// <summary>
        /// Limit to show message
        /// </summary>
        /// <param name="limit">Limit must be greater or equal zero (if limit = 0, then console don't have limits)</param>
        void SetMessageLimit ( int limit );
        /// <summary>
        /// Allows/Non-allows User to write and to send message to console
        /// </summary>
        /// <param name="state">TRUE: Allows
        /// FALSE: Non-allows</param>
        void SetCanWrite ( bool state );
        /// <summary>
        /// Allows/Non-allows User to change size
        /// </summary>
        /// <param name="state">TRUE: Allows
        /// FALSE: Non-allows</param>
        void SetIsResizeable ( bool state );
        /// <summary>
        /// Show/Don't show in console debug message.
        /// </summary>
        /// <param name="state">TRUE: Show
        /// FALSE: Don't show</param>
        void SetDebugMode ( bool state );

        /// <summary>
        /// Return visible state console
        /// </summary>
        /// <returns>TRUE: is visible
        /// FALSE: isn't visible</returns>
        bool IsShowing ();
        /// <summary>
        /// Reinitialize console view
        /// </summary>
        void ReinitializeView ();

        /// <summary>
        /// Save logs from this sesion
        /// </summary>
        /// <returns>If wasn't any error: TRUE</returns>
        bool SaveLogs ();
    }
}
