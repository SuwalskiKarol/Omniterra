using System.Xml.Serialization;

namespace Scripts.Utility.LanguageSystem {
    /// <summary>
    /// Available language for this game.
    /// </summary>
    public enum Language {
        /// <summary>
        /// Polish language.
        /// </summary>
        [XmlEnum ( Name = "Polish" )]
        Polish,
        /// <summary>
        /// English language.
        /// </summary>
        [XmlEnum ( Name = "English" )]
        English
    }
}
