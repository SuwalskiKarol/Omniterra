namespace Scripts.Utility.LanguageSystem {
    /// <summary>
    /// Interface to handling available languages.
    /// </summary>
    public interface IAvailableLanguages : ILanguageSystem {
        /// <summary>
        /// This function get string for button "Polish" in game from correct language pack.
        /// </summary>
        /// <returns>"Polish" in correct language</returns>
        string GetNamePolish ();
        /// <summary>
        /// This function get string for button "English" in game from correct language pack.
        /// </summary>
        /// <returns>"English" in correct language</returns>
        string GetNameEnglish ();

    }
}
