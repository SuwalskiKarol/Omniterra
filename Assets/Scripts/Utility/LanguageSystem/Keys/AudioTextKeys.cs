using System.Xml.Serialization;

namespace Scripts.Utility.LanguageSystem {
    /// <summary>
    /// Enum keys for texts from Audio Menu
    /// </summary>
    public enum AudioTextKeys {
        /// <summary>
        /// This key is for string like "Sounds" 
        /// </summary>
        [XmlEnum ( Name = "Sounds" )]
        SOUNDS,
        /// <summary>
        /// This key is for string like "Music"
        /// </summary>
        [XmlEnum ( Name = "Music" )]
        MUSIC,
        /// <summary>
        /// This key is for string like "On"
        /// </summary>
        [XmlEnum ( Name = "On" )]
        ON,
        /// <summary>
        /// This key is for string like "Off"
        /// </summary>
        [XmlEnum ( Name = "Off" )]
        OFF
    }
}
