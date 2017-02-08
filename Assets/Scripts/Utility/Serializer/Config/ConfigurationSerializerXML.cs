namespace Scripts.Utility.Serializer {
    /// <summary>
    /// Configuration class for serializer by XML.
    /// </summary>
    public class ConfigurationSerializerXML : ConfigurationSerializer {
        private Configuration.Configurator cfg = Configuration.Configurator.GetInstance();

        private readonly string LOCATION_KEYS = "Keys\\";
        private readonly string LOCATION_CONFIG = "Configuration\\";
        private readonly string LOCATION_LANGUAGE_FILES = "LanguagePack\\";
        private readonly string LOCATION_LANGUAGE_MENU = "\\Menu\\";
        private readonly string LOCATION_CONSOLE_CONFIG = "Console\\";
        private readonly string LOCATION_LOG_FILES = "Log\\";

        #region language packs
        private readonly string NAME_MAIN_MENU = "MainMenu";
        private readonly string NAME_GRAPHICS_MENU = "Graphics";
        private readonly string NAME_AUDIO_MENU = "Audio";
        private readonly string NAME_KEYS_TRANSLATE = "Keys";

        #endregion

        private readonly string NAME_CONFIG = "MyOwn.cfg";
        private readonly string NAME_CONSOLE_CONFIG = "MyConsole.cfg";
        private readonly string NAME_AVAILABLE_LANGUAGE = "AvailableLanguage.cfg";

        private readonly string NAME_KEYS_CONFIG = "MyKejolodżik.keys";

        private const string LOG_FILE_EXTENSION = ".log";
        private const string LANGUAGE_PACK_FILE_EXTENSION = ".lp";

        private readonly string format2 = "{0}{1}";
        private readonly string format3 = "{0}{1}{2}";
        private readonly string format4 = "{0}{1}{2}{3}";
        private readonly string format5 = "{0}{1}{2}{3}{4}";

        /// <summary>
        /// This function get path to file with audio texts.
        /// </summary>
        /// <returns>Path to file with audio texts.</returns>
        public string PathToAudioTextsFile () {
            return string.Format ( format5, LOCATION_LANGUAGE_FILES, cfg.GetLanguage ().ToString (), LOCATION_LANGUAGE_MENU, NAME_AUDIO_MENU, LANGUAGE_PACK_FILE_EXTENSION );
        }
        /// <summary>
        /// This function get path to file with graphics texts.
        /// </summary>
        /// <returns>Path to file with graphics texts.</returns>
        public string PathToGraphicTextsFile () {
            return string.Format ( format5, LOCATION_LANGUAGE_FILES, cfg.GetLanguage ().ToString (), LOCATION_LANGUAGE_MENU, NAME_GRAPHICS_MENU, LANGUAGE_PACK_FILE_EXTENSION );
        }
        /// <summary>
        /// This function get path to file with configuration.
        /// </summary>
        /// <returns>Path to file with configuration.</returns>
        public string PathToConfigFile () {
            return string.Format ( format2, LOCATION_CONFIG, NAME_CONFIG );
        }
        /// <summary>
        /// This function get path to file with configuration console.
        /// </summary>
        /// <returns>Path to console configuration file.</returns>
        public string PathToConsoleFile () {
            return string.Format ( format2, LOCATION_CONSOLE_CONFIG, NAME_CONSOLE_CONFIG );
        }
        /// <summary>
        /// This function get path to file with available keys for User.
        /// </summary>
        /// <returns>Path to keys configuration.</returns>
        public string PathToKeysConfig () {
            return string.Format ( format2, LOCATION_KEYS, NAME_KEYS_CONFIG );
        }
        /// <summary>
        /// This function get path to file with available languages.
        /// </summary>
        /// <returns>Path to file with available languages.</returns>
        public string PathToAvailableLanguagesFile () {
            return string.Format ( format2, LOCATION_LANGUAGE_FILES, NAME_AVAILABLE_LANGUAGE );
        }
        /// <summary>
        /// This function get path to file with texts from all menu.
        /// </summary>
        /// <returns>Path to file with texts from all menu.</returns>
        public string PathToMenuTextsFile () {
            return string.Format ( format5, LOCATION_LANGUAGE_FILES, cfg.GetLanguage ().ToString (), LOCATION_LANGUAGE_MENU, NAME_MAIN_MENU, LANGUAGE_PACK_FILE_EXTENSION );
        }
        /// <summary>
        /// This function get path to file with keys names.
        /// </summary>
        /// <returns>Path to keys names.</returns>
        public string PathToKeysTextFile () {
            return string.Format ( format4, LOCATION_LANGUAGE_FILES, cfg.GetLanguage ().ToString (), NAME_KEYS_TRANSLATE, LANGUAGE_PACK_FILE_EXTENSION );
        }
        /// <summary>
        /// This function get path to log file with "name"
        /// </summary>
        /// <param name="name">Name saving logfile</param>
        /// <returns></returns>
        public string PathToLogFiles (string name) {
            return string.Format ( format3, LOCATION_LOG_FILES, name, LOG_FILE_EXTENSION );
        }
    }
}
