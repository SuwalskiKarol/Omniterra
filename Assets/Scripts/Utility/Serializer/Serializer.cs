using System.Collections.Generic;
using Scripts.Utility.Configuration;
using Scripts.Utility.Console;
using Scripts.Utility.Keys;
using Scripts.Utility.LanguageSystem;

namespace Scripts.Utility.Serializer {
    /// <summary>
    /// This abstract class is parent for another serializers.
    /// </summary>
    public abstract class Serializer :  ISerializerTexts, 
                                        ISerializerConfiguration,
                                        ISerializerConsole,
                                        ISerializerKey {

        /// <summary>
        /// Configuration for actual serializer.
        /// </summary>
        protected ConfigurationSerializer myConfig;

        /// <summary>
        /// Instance of actual serializer.
        /// </summary>
        protected static Serializer instance;

        /// <summary>
        /// Load available language names
        /// </summary>
        /// <returns>All language names</returns>
        public abstract Dictionary<Language, string> LoadLanguageKeys ();
        /// <summary>
        /// Load available texts to Menu
        /// </summary>
        /// <returns>All texts to Menu</returns>
        public abstract Dictionary<MenuTextKeys, string> LoadMainMenu ();
        /// <summary>
        /// Load available key action names
        /// </summary>
        /// <returns>All key action names</returns>
        public abstract Dictionary<KeyName, string> LoadNamesKeys ();
        /// <summary>
        /// Load available texts to audio menu
        /// </summary>
        /// <returns>All texts to audio menu</returns>
        public abstract Dictionary<AudioTextKeys, string> LoadTextAudioMenu ();
        /// <summary>
        /// Load available texts to graphics menu
        /// </summary>
        /// <returns>All texts to graphics menu</returns>
        public abstract Dictionary<GraphicsTextKeys, string> LoadTextGraphicsMenu ();
        /// <summary>
        /// This function will save a consoles configuration.
        /// </summary>
        /// <param name="myConsole">Console configuration file</param>
        /// <returns>If all operations going without errors: TRUE.
        /// If any operation going with any errors: FALSE.</returns>
        public abstract bool SaveConsoleConfig ( ConsoleConfig myConsole );
        /// <summary>
        /// Load existing configuration for console.
        /// </summary>
        /// <returns>Console Configuration</returns>
        public abstract ConsoleConfig LoadConsoleConfig ();
        /// <summary>
        /// Save all logs from this session.
        /// </summary>
        /// <param name="name">Log file name</param>
        /// <param name="logs">List of all logs</param>
        /// <returns>If all operations going without errors: TRUE.
        /// If any operation going with any errors: FALSE.</returns>
        public abstract bool SaveLogFile ( string name, List<Message> logs );
        public abstract Config LoadConfigFile ();
        public abstract bool SaveConfigFile ( Config myConfig );
    }
}
