using System.Xml.Serialization;

namespace Scripts.Utility.Configuration {
    /// <summary>
    /// Texture quality levels
    /// </summary>
    public enum TextureQuality {
        /// <summary>
        /// Low level texture
        /// </summary>
        [XmlElement ("Low")]
        LOW,
        /// <summary>
        /// Medium level texture
        /// </summary>
        [XmlElement ("Medium")]
        MEDIUM,
        /// <summary>
        /// High level texture
        /// </summary>
        [XmlElement ("High")]
        HIGH
    }
}
