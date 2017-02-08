namespace Scripts.Utility.Configuration {
    /// <summary>
    /// Interface to handling Configuration
    /// </summary>
    public interface IConfig : IAudioConfigurator, IGraphicConfigurator {
        /// <summary>
        /// Change language
        /// </summary>
        /// <param name="newLanguage">Set this language</param>
        void ChangeLanguage ( LanguageSystem.Language newLanguage );
        /// <summary>
        /// Get actual language
        /// </summary>
        /// <returns>Actual language</returns>
        LanguageSystem.Language GetLanguage ();
        /// <summary>
        /// Set default initialization
        /// </summary>
        void DefaultInitialization ();
    }
}
