namespace Scripts.Utility.LanguageSystem {
    /// <summary>
    /// Main interface for Language system. 
    /// </summary>
    public interface ILanguageSystem {

        /// <summary>
        /// This function load language pack.
        /// </summary>
        /// <param name="file">Pack name</param>
        /// <returns>True if load without errors, false if were any error</returns>
        bool LoadTextsFrom ( LanguageFiles file );
        /// <summary>
        /// This function unload language pack.
        /// </summary>
        /// <param name="file">Pack name</param>
        /// <returns>True if load without errors, false if were any error</returns>
        bool UnloadTextsFrom ( LanguageFiles file );
        /// <summary>
        /// This function unload all language packs.
        /// </summary>
        /// <returns>True if load without errors, false if were any error</returns>
        bool UnloadAll ();
        /// <summary>
        /// Reload all initialized language files
        /// </summary>
        void ReloadAll ();
        /// <summary>
        /// This function return language system with menu texts.
        /// </summary>
        /// <returns>Return this object with menu texts</returns>
        ILanguageMenu MenuLanguageSystem ();
        /// <summary>
        /// This function return language system with audio menu texts.
        /// </summary>
        /// <returns>Return this object with audio menu texts</returns>
        ILanguageAudioMenu AudioMenuLanguageSystem ();
        /// <summary>
        /// This function return language system with graphics menu texts.
        /// </summary>
        /// <returns>Return this object with graphics menu texts</returns>
        ILanguageGraphicsMenu GraphicsMenuLanguageSystem ();
        /// <summary>
        /// This function return language system with key names.
        /// </summary>
        /// <returns>Return this object with key names</returns>
        ILanguageNamesKey LanguageNamesKey ();
        /// <summary>
        /// This function return language system with language names.
        /// </summary>
        /// <returns>Return this object with language names</returns>
        IAvailableLanguages AvailableLanguages ();
        
    } 
}