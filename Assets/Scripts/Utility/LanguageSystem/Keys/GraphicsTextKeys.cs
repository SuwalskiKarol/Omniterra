using System.Xml.Serialization;

namespace Scripts.Utility.LanguageSystem {
    /// <summary>
    /// Enum keys for texts from Graphic menu.
    /// </summary>
    public enum GraphicsTextKeys {
        /// <summary>
        /// This key is for string like "Resolution" 
        /// </summary>
        [XmlEnum ( Name = "Resolution" )]
        RESOLUTION,
        /// <summary>
        /// This key is for string like "Graphic level" 
        /// </summary>
        [XmlEnum ( Name = "Graphic_Level" )]
        GRAPHIC_LEVEL,
        /// <summary>
        /// This key is for string like "VSync" 
        /// </summary>
        [XmlEnum ( Name = "VSync" )]
        VSYNC,
        /// <summary>
        /// This key is for string like "Triple Buffering" 
        /// </summary>
        [XmlEnum ( Name = "Triple_Buffering" )]
        TRIPLE_BUFFERING,
        /// <summary>
        /// This key is for string like "Level of details" 
        /// </summary>
        [XmlEnum ( Name = "Level_Of_Detail" )]
        LEVEL_OF_DETAIL,
        /// <summary>
        /// This key is for string like "Texture quality" 
        /// </summary>
        [XmlEnum ( Name = "Texture_Quality" )]
        TEXTURE_QUALITY,
        /// <summary>
        /// This key is for string like "Additional effects" 
        /// </summary>
        [XmlEnum ( Name = "Additional_Effects" )]
        ADDITIONAL_EFFECTS,
        /// <summary>
        /// This key is for string like "AntiAliasing" 
        /// </summary>
        [XmlEnum ( Name = "AntiAliasing" )]
        ANTIALIASING,
        /// <summary>
        /// This key is for string like "On" 
        /// </summary>
        [XmlEnum ( Name = "On" )]
        ON,
        /// <summary>
        /// This key is for string like "Off" 
        /// </summary>
        [XmlEnum ( Name = "Off" )]
        OFF,
        /// <summary>
        /// This key is for string like "Low" 
        /// </summary>
        [XmlEnum ( Name = "Low" )]
        LOW,
        /// <summary>
        /// This key is for string like "Medium" 
        /// </summary>
        [XmlEnum ( Name = "Medium" )]
        MEDIUM,
        /// <summary>
        /// This key is for string like "High" 
        /// </summary>
        [XmlEnum ( Name = "High" )]
        HIGH,
        /// <summary>
        /// This key is for string like "Simple" 
        /// </summary>
        [XmlEnum ( Name = "Simple" )]
        SIMPLE,
        /// <summary>
        /// This key is for string like "Fastest" 
        /// </summary>
        [XmlEnum ( Name = "Fastest" )]
        FASTEST,
        /// <summary>
        /// This key is for string like "Fast" 
        /// </summary>
        [XmlEnum ( Name = "Fast" )]
        FAST,
        /// <summary>
        /// This key is for string like "Good" 
        /// </summary>
        [XmlEnum ( Name = "Good" )]
        GOOD,
        /// <summary>
        /// This key is for string like "Beautiful" 
        /// </summary>
        [XmlEnum ( Name = "Beautiful" )]
        BEAUTIFUL,
        /// <summary>
        /// This key is for string like "Fantastic" 
        /// </summary>
        [XmlEnum ( Name = "Fantastic" )]
        FANTASTIC,
        /// <summary>
        /// This key is for string like "Default" 
        /// </summary>
        [XmlEnum ( Name = "Default" )]
        DEFAULT
    }
}
