using System.Xml.Serialization;

namespace Scripts.Utility.Configuration {
    /// <summary>
    /// Enum containing levels of detail
    /// </summary>
    public enum LOD {
        [XmlEnum ("Low")]
        /// <summary>
        /// Low level of details
        /// </summary>
        LOW,
        [XmlEnum ("Medium")]
        /// <summary>
        /// Medium level of details
        /// </summary>
        MEDIUM,
        [XmlEnum ("High")]
        /// <summary>
        /// High level of details
        /// </summary>
        HIGH
    }
}
