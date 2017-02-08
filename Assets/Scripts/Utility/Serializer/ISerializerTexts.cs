using System.Collections.Generic;

namespace Scripts.Utility.Serializer {
    /// <summary>
    /// Interface for loading all available text groups.
    /// </summary>
    public interface ISerializerTexts {
        /// <summary>
        /// Load available texts to Menu
        /// </summary>
        /// <returns>All texts to Menu</returns>
        Dictionary<LanguageSystem.MenuTextKeys, string> LoadMainMenu ();
        /// <summary>
        /// Load available key action names
        /// </summary>
        /// <returns>All key action names</returns>
        Dictionary<Keys.KeyName, string> LoadNamesKeys ();
        /// <summary>
        /// Load available language names
        /// </summary>
        /// <returns>All language names</returns>
        Dictionary<LanguageSystem.Language, string> LoadLanguageKeys ();
        /// <summary>
        /// Load available texts to graphics menu
        /// </summary>
        /// <returns>All texts to graphics menu</returns>
        Dictionary<LanguageSystem.GraphicsTextKeys, string> LoadTextGraphicsMenu ();
        /// <summary>
        /// Load available texts to audio menu
        /// </summary>
        /// <returns>All texts to audio menu</returns>
        Dictionary<LanguageSystem.AudioTextKeys, string> LoadTextAudioMenu ();
    }
}