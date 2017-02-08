using System.Xml.Serialization;

namespace Scripts.Utility.LanguageSystem {
    /// <summary>
    /// Enum keys for texts from all Menus.
    /// </summary>
    public enum MenuTextKeys {
        /// <summary>
        /// This key is for string like "Credits" 
        /// </summary>
        [XmlEnum ( Name = "Credits" )]
        CREDITS,
        /// <summary>
        /// This key is for string like "Options" 
        /// </summary>
        [XmlEnum ( Name = "Options" )]
        OPTIONS,
        /// <summary>
        /// This key is for string like "Exit" 
        /// </summary>
        [XmlEnum ( Name = "Exit" )]
        EXIT,
        /// <summary>
        /// This key is for question about confirmation for exit 
        /// </summary>
        [XmlEnum ( Name = "Confirmation_Exit_Message" )]
        CONFIRMATION_EXIT_MESSAGE,
        /// <summary>
        /// This key is for string like "Yes, i Wanna Quit"
        /// </summary>
        [XmlEnum ( Name = "Accept_Exit" )]
        ACCEPT_EXIT,
        /// <summary>
        /// This key is for string like "No, i wanna play!" 
        /// </summary>
        [XmlEnum ( Name = "Decline_Exit" )]
        DECLINE_EXIT,
        /// <summary>
        /// This key is for string like "Audio" 
        /// </summary>
        [XmlEnum ( Name = "Audio" )]
        AUDIO,
        /// <summary>
        /// This key is for string like "Languages" 
        /// </summary>
        [XmlEnum ( Name = "Languages" )]
        LANGUAGES,
        /// <summary>
        /// This key is for string like "Graphics" 
        /// </summary>
        [XmlEnum ( Name = "Graphics" )]
        GRAPHICS,
        /// <summary>
        /// This key is for string like "Keys" 
        /// </summary>
        [XmlEnum ( Name = "Keys" )]
        KEYS,
        /// <summary>
        /// This key is for string like "Multiplayer" 
        /// </summary>
        [XmlEnum ( Name = "Multi" )]
        MULTI,
        /// <summary>
        /// This key is for string like "Singleplayer" 
        /// </summary>
        [XmlEnum ( Name = "Single" )]
        SINGLE,
        /// <summary>
        /// This key is for string like "Select map" 
        /// </summary>
        [XmlEnum ( Name = "Select_Map" )]
        SELECT_MAP,
        /// <summary>
        /// This key is for string like "Campaign" 
        /// </summary>
        [XmlEnum ( Name = "Campaign" )]
        CAMPAIGN,
        /// <summary>
        /// This key is for string like "Select campaign" 
        /// </summary>
        [XmlEnum ( Name = "Select_Campaign" )]
        SELECT_CAMPAIGN,
        /// <summary>
        /// This key is for string like "Load state game" 
        /// </summary>
        [XmlEnum ( Name = "Load_State" )]
        LOAD_STATE,
        /// <summary>
        /// This key is for string like "Back" 
        /// </summary>
        [XmlEnum ( Name = "Back" )]
        BACK,
        /// <summary>
        /// This key is for string like "Start" 
        /// </summary>
        [XmlEnum ( Name = "Start" )]
        START
    }
}
