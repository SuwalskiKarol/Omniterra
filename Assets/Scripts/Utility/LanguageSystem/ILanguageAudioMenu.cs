namespace Scripts.Utility.LanguageSystem {
    /// <summary>
    /// Interface to handling all audio texts menu.
    /// </summary>
    public interface ILanguageAudioMenu : ILanguageSystem {
        /// <summary>
        /// This function get string for label "Sound" in game from correct language pack.
        /// </summary>
        /// <returns>"Sound" in correct language</returns>
        string GetSoundText ();

        /// <summary>
        /// This function get string for label "Music" in game from correct language pack.
        /// </summary>
        /// <returns>"Music" in correct language</returns>
        string GetMusicText ();

        /// <summary>
        /// This function get string for active option in game from correct language pack.
        /// </summary>
        /// <returns>"ON" in correct language</returns>
        string GetStatusOnText ();

        /// <summary>
        /// This function get string for deactive option in game from correct language pack.
        /// </summary>
        /// <returns>"OFF" in correct language</returns>
        string GetStatusOffText ();
    }
}
