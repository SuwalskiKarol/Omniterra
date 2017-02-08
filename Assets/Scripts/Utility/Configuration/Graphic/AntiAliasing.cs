using System.Xml.Serialization;

namespace Scripts.Utility.Configuration {
    /// <summary>
    /// AntiAliasing levels
    /// </summary>
    public enum AntiAliasing {
        /// <summary>
        /// Turn off antyaliasing
        /// </summary>
        [XmlElement ("Off")]
        OFF,
        /// <summary>
        /// Low level antyaliasing
        /// </summary>
        [XmlElement ( "Low" )]
        LOW,
        /// <summary>
        /// Medium level antyaliasing
        /// </summary>
        [XmlElement ( "Medium" )]
        MEDIUM,
        /// <summary>
        /// High level antyaliasing
        /// </summary>
        [XmlElement ( "High" )]
        HIGH
    }
}
