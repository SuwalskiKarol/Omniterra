namespace Scripts.Utility.Configuration {
    /// <summary>
    /// Interface to handling graphic configuration
    /// </summary>
    public interface IGraphicConfigurator {
        /// <summary>
        /// Switch additional effects state (on to off or off to on)
        /// </summary>
        void SwitchStateAdditionalEffects ();
        /// <summary>
        /// Get actual additional effects state
        /// </summary>
        /// <returns>Actual additional effects state</returns>
        bool GetStateAdditionalEffects ();

        /// <summary>
        /// Set new resolution
        /// </summary>
        /// <param name="newResolution">Setting resolution</param>
        void SetResolution ( UnityEngine.Resolution newResolution );
        /// <summary>
        /// Return actual resolution
        /// </summary>
        /// <returns>Actual resolution</returns>
        UnityEngine.Resolution GetResolution ();
        /// <summary>
        /// Return all available resolutions
        /// </summary>
        /// <returns>All available resolutions</returns>
        UnityEngine.Resolution[] GetAvailableResolutions ();

        /// <summary>
        /// Switch VSync state (from ON to OFF or from OFF to ON)
        /// </summary>
        void SwitchVSyncState ();
        /// <summary>
        /// Get actual VSync state
        /// </summary>
        /// <returns>VSync state</returns>
        bool GetVSyncState ();

        /// <summary>
        /// Get actual Level of Details
        /// </summary>
        /// <returns>Level of Details</returns>
        LOD GetActualLOD ();
        /// <summary>
        /// Set new Level of Details
        /// </summary>
        /// <param name="newLevel">New Level of Detail</param>
        void SetActualLOD ( LOD newLevel );
        /// <summary>
        /// Get all available Level of Details
        /// </summary>
        /// <returns>Available Level of Details</returns>
        LOD[] GetAvailableLOD ();

        /// <summary>
        /// Get actual texture quality level
        /// </summary>
        /// <returns>Actual texture quality level</returns>
        TextureQuality GetActualTextureQuality ();
        /// <summary>
        /// Set new texture quality level
        /// </summary>
        /// <param name="newTextureQuality">New texture quality level</param>
        void SetActualTextureQuality ( TextureQuality newTextureQuality );
        /// <summary>
        /// Get available texture qualities
        /// </summary>
        /// <returns>All available texture qualities</returns>
        TextureQuality[] GetAvailableTextureQualities ();

        /// <summary>
        /// Get actual AntiAliasing level
        /// </summary>
        /// <returns>Actual AntiAliasing</returns>
        AntiAliasing GetActualAntiAliasing ();
        /// <summary>
        /// Set new AntiAliasing level
        /// </summary>
        /// <param name="newAntiAliasing">New AntiAliasing level</param>
        void SetActualAntiAliasing ( AntiAliasing newAntiAliasing );
        /// <summary>
        /// Return all available AntiAliasing levels
        /// </summary>
        /// <returns>Available AntiAliasing levels</returns>
        AntiAliasing[] GetAvailableAntiAliasings ();

        /// <summary>
        /// Get actual quality level
        /// </summary>
        /// <returns>Number of quality level</returns>
        int GetActualQualityLevel ();
        /// <summary>
        /// Set new quality level
        /// </summary>
        /// <param name="newLevel">New quality level</param>
        /// <returns></returns>
        bool SetActualQualityLevel ( int newLevel );
        /// <summary>
        /// Get all available quality levels
        /// </summary>
        /// <returns>Available quality levels</returns>
        int[] GetAvailableQualityLevels ();

        /// <summary>
        /// Get state of triple buffering
        /// </summary>
        /// <returns>Actual state of triple buffering</returns>
        bool GetTripleBufferingState ();
        /// <summary>
        /// Switch triple buffering state (from ON to OFF or from OFF to ON)
        /// </summary>
        void SwitchTripleBufferingState ();
    }
}
