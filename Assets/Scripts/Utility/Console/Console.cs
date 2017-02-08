using System;

namespace Scripts.Utility.Console {
    /// <summary>
    /// Console implements interface IConsole. Additionaly using Singleton and MVC templates. 
    /// </summary>
    public class Console : IConsole {
        private const int MIN_VALUE_PERCENT = 0;
        private const int MAX_VALUE_PERCENT = 1;

        private static Console instance;

        private ConsoleView view;
        private ConsoleConfig config;
        private Serializer.ISerializerConsole serializer;


        private Console () {
            serializer = Serializer.SerializerByXML.GetInstance ();
            config = serializer.LoadConsoleConfig ();
            if (config == null) {
                config = new ConsoleConfig ();
                config.DefaultInitialization ();
                serializer.SaveConsoleConfig ( config );
            }
            view = new ConsoleViewUnity ();
            
            view.InitializeView ( config.GetRect () );
        }
        /// <summary>
        /// Get instance of Console.
        /// </summary>
        /// <returns>Console instance.</returns>
        public static Console GetInstance () {
            return ( instance ?? ( instance = new Console () ) );
        }

        /// <summary>
        /// Add log to Console.
        /// </summary>
        /// <param name="message">Log</param>
        /// <returns>If all operations going without errors: TRUE.
        /// If any operation going with any errors: FALSE.</returns>
        public bool AddLog ( Message message ) {
            bool result = true;
            try {
                config.logContainer.Add ( message );
            } catch ( Exception err ) {
                UnityEngine.Debug.Log ( err );
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Set consoles visible state
        /// </summary>
        /// <param name="newState">New console state</param>
        public void SetVisible ( bool state ) {
            config.isVisible = state;
        }

        /// <summary>
        /// Show Console.
        /// </summary>
        /// <returns>If all operations going without errors: TRUE.
        /// If any operation going with any errors: FALSE.</returns>
        public void Show () {
            if ( config.isVisible)
                view.ShowAllLogs ( config.GetMessages() );
        }

        /// <summary>
        /// Return visible state console
        /// </summary>
        /// <returns>TRUE: is visible
        /// FALSE: isn't visible</returns>        
        public bool IsShowing () {
            return config.isVisible;
        }

        /// <summary>
        /// Set console configuration for Menu
        /// </summary>
        public void SetMenuConsole () {
            config.canWrite = false;
            config.debugMode = true;
            config.height = 0.3f;
            config.width = 0.7f;
            config.isResizeable = false;
            config.isVisible = true;
            config.x = 0.15f;
            config.y = 0.7f;

            view.InitializeView ( config.GetRect () );
        }

        /// <summary>
        /// Set horizontal location for console
        /// </summary>
        /// <param name="x">Position in percentage (Range: 0 - 1)</param>
        public void SetXPosition ( float x ) {
            CheckData ( x );
            config.x = x;
        }
        /// <summary>
        /// Set vertical location for console
        /// </summary>
        /// <param name="y">Position in percentage (Range: 0 - 1)</param>
        public void SetYPosition ( float y ) {
            CheckData ( y );
            config.y = y;    
        }
        /// <summary>
        /// Set width for console
        /// </summary>
        /// <param name="width">Width in in percentage (Range: 0 - 1)</param>
        public void SetWidth ( float width ) {
            CheckData ( width );
            config.width = width;
        }
        /// <summary>
        /// Set height for console
        /// </summary>
        /// <param name="height">Height in percentage (Range: 0 - 1)</param>
        public void SetHeight ( float height ) {
            new NotImplementedException ();
            CheckData ( height );
            config.height = height;
        }
        /// <summary>
        /// Limit to show message
        /// </summary>
        /// <param name="limit">Limit must be greater or equal zero (if limit = 0, then console don't have limits)</param>
        public void SetMessageLimit ( int limit ) {
            if ( limit < MIN_VALUE_PERCENT )
                throw new ArgumentException ();
            config.countMessages = limit;
        }

        private void CheckData (float value) {
            if ( value < MIN_VALUE_PERCENT || value > MAX_VALUE_PERCENT )
                throw new ArgumentException ();
        }
        /// <summary>
        /// Allows/Non-allows User to write and to send message to console
        /// </summary>
        /// <param name="state">TRUE: Allows
        /// FALSE: Non-allows</param>
        public void SetCanWrite ( bool state ) {
            config.canWrite = state;
        }
        /// <summary>
        /// Allows/Non-allows User to change size
        /// </summary>
        /// <param name="state">TRUE: Allows
        /// FALSE: Non-allows</param>
        public void SetIsResizeable ( bool state ) {
            config.isResizeable = state;
        }
        /// <summary>
        /// Show/Don't show in console debug message.
        /// </summary>
        /// <param name="state">TRUE: Show
        /// FALSE: Don't show</param>
        public void SetDebugMode ( bool state ) {
            config.debugMode = state;
        }

        /// <summary>
        /// Reinitialize console view
        /// </summary>
        public void ReinitializeView () {
            view.InitializeView ( config.GetRect () );
        }

        /// <summary>
        /// Save logs from this sesion
        /// </summary>
        /// <returns>If wasn't any error: TRUE</returns>
        public bool SaveLogs () {
            return serializer.SaveLogFile (config.nameLogFile, config.logContainer);
        }
    }
}