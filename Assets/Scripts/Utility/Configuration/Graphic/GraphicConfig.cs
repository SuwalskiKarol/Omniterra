using System.Xml.Serialization;

namespace Scripts.Utility.Configuration {
    /// <summary>
    /// Graphic configuration
    /// </summary>
    public class GraphicConfig {
        [XmlIgnore]
        public readonly int MIN_QUALITY_LEVEL = 0;
        [XmlIgnore]
        public readonly int MAX_QUALITY_LEVEL = 6;

        /// <summary>
        /// Actual level of detail
        /// </summary>
        public LOD actualLOD { get; set; }
        /// <summary>
        /// Actual level of antyaliasing
        /// </summary>
        public AntiAliasing actualAntiAliasing { get; set; }
        /// <summary>
        /// Actual texture quality settings
        /// </summary>
        public TextureQuality actualTextureQuality { get; set; }
        /// <summary>
        /// Additional effects status
        /// </summary>
        public bool additionalEffectsState { get; set; }
        /// <summary>
        /// Actual resolution
        /// </summary>
        public UnityEngine.Resolution actualResolution { get; set; }
        /// <summary>
        /// VSync state
        /// </summary>
        public bool vSyncState { get; set; }
        /// <summary>
        /// Actual quality configuration
        /// </summary>
        public int actualQualityConfig { get; set; }
        /// <summary>
        /// Triple buffering state
        /// </summary>
        public bool tripleBufferingState { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public GraphicConfig () { }

        /// <summary>
        /// Default initialization
        /// </summary>
        public void DefaultInitialization () {
            actualAntiAliasing = AntiAliasing.MEDIUM;
            actualLOD = LOD.MEDIUM;
            actualQualityConfig = 0;
            actualResolution = UnityEngine.Screen.currentResolution;
            actualTextureQuality = TextureQuality.MEDIUM;
            additionalEffectsState = true;
            vSyncState = true;
            tripleBufferingState = true;
        }
    }
}
