using System.Xml.Serialization;

namespace Scripts.Utility.Configuration {
    /// <summary>
    /// Configuration audio
    /// </summary>
    [System.Serializable]
    public class AudioConfig {
        private const float DEFAULT_VALUE = 0.5f;

        [XmlIgnore]
        public readonly int MIN_VALUE = 0;
        [XmlIgnore]
        public readonly int MAX_VALUE = 1;
        [XmlIgnore]
        public readonly float CHANGE_VALUE = 0.05f;

        /// <summary>
        /// Sounds state
        /// </summary>
        public bool soundState { get; set; }
        /// <summary>
        /// Music state
        /// </summary>
        public bool musicState { get; set; }
        /// <summary>
        /// Dialogue state
        /// </summary>
        public bool dialogueState { get; set; }
        /// <summary>
        /// All audio options state
        /// </summary>
        public bool allAudioState { get; set; }
        /// <summary>
        /// Sounds level (in percentage)
        /// Range: &lt; 0; 1 &gt;
        /// </summary>
        public float soundLevel { get; set; }
        /// <summary>
        /// Music level (in percentage)
        /// Range: &lt; 0; 1 &gt;
        /// </summary>
        public float musicLevel { get; set; }
        /// <summary>
        /// Dialogue level (in percentage)
        /// Range: &lt; 0; 1 &gt;
        /// </summary>
        public float dialogueLevel { get; set; }
        /// <summary>
        /// All audio settings level (in percentage)
        /// Range: &lt; 0; 1 &gt;
        /// </summary>
        public float allAudioLevel { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public AudioConfig () {}

        /// <summary>
        /// Default initialization
        /// </summary>
        public void DefaultInitialization () {
            soundState = true;
            musicState = true;
            dialogueState = true;
            allAudioState = true;

            soundLevel = DEFAULT_VALUE;
            musicLevel = DEFAULT_VALUE;
            dialogueLevel = DEFAULT_VALUE;
            allAudioLevel = DEFAULT_VALUE;
        }
    }
}
