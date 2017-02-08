namespace Scripts.Utility.Serializer {
    /// <summary>
    /// Interface for handling serialization configuration game
    /// </summary>
    public interface ISerializerConfiguration {
        /// <summary>
        /// Load config file
        /// </summary>
        /// <returns>Config file</returns>
        Configuration.Config LoadConfigFile ();
        /// <summary>
        /// Save config file
        /// </summary>
        /// <param name="myConfig">Saving config</param>
        /// <returns>TRUE if all operations goint witout any errors</returns>
        bool SaveConfigFile ( Configuration.Config myConfig );
    }
}