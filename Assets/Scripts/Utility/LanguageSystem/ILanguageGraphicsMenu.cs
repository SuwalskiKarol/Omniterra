namespace Scripts.Utility.LanguageSystem {
    /// <summary>
    /// Interface for handling all graphics texts.
    /// </summary>
    public interface ILanguageGraphicsMenu : ILanguageSystem {        
        /// <summary>
        /// This function get string for label "Resolution" in game from correct language pack.
        /// </summary>
        /// <returns>"Resolution" in correct language</returns>
        string GetResolutionText ();
        /// <summary>
        /// This function get string for label "GraphicLevels" in game from correct language pack.
        /// </summary>
        /// <returns>"Graphic level" in correct language</returns>
        string GetGraphicLevelText ();
        /// <summary>
        /// This function get string for label "VSync" in game from correct language pack.
        /// </summary>
        /// <returns>"VSync" in correct language</returns>
        string GetVSyncText ();
        /// <summary>
        /// This function get string for label "TripleBuffering" in game from correct language pack.
        /// </summary>
        /// <returns>"Triple buffering" in correct language</returns>
        string GetTripleBufferingText ();
        /// <summary>
        /// This function get string for label "LevelOfDetail" in game from correct language pack.
        /// </summary>
        /// <returns>"Level of detail" in correct language</returns>
        string GetLevelOfDetailText ();
        /// <summary>
        /// This function get string for label "TextureQuality" in game from correct language pack.
        /// </summary>
        /// <returns>"Texture quality" in correct language</returns>
        string GetTextureQualityText ();
        /// <summary>
        /// This function get string for label "AdditionalEffects" in game from correct language pack.
        /// </summary>
        /// <returns>"Additional effects" in correct language</returns>
        string GetAdditionalEffectsText ();
        /// <summary>
        /// This function get string for label "Antyaliasing" in game from correct language pack.
        /// </summary>
        /// <returns>"Antialiasing" in correct language</returns>
        string GetAntialiasingText ();
        /// <summary>
        /// This function get string for state "ON" in game from correct language pack.
        /// </summary>
        /// <returns>"ON" in correct language</returns>
        string GetStatusOnText ();
      /// <summary>
        /// This function get string for status "OFF" in game from correct language pack.
        /// </summary>
        /// <returns>"OFF" in correct language</returns>
        string GetStatusOffText ();
        /// <summary>
        /// This function get string for status "LOW" in game from correct language pack.
        /// </summary>
        /// <returns>"Low" in correct language</returns>
        string GetStatusLow ();

        /// <summary>
        /// This function get string for status "MEDIUM" in game from correct language pack.
        /// </summary>
        /// <returns>"Medium" in correct language</returns>
        string GetStatusMediumText ();
        /// <summary>
        /// This function get string for status "HIGH" in game from correct language pack.
        /// </summary>
        /// <returns>"High" in correct language</returns>
        string GetStatusHighText ();
        /// <summary>
        /// This function get string for status "SIMPLE" in game from correct language pack.
        /// </summary>
        /// <returns>"Simple" in correct language</returns>
        string GetStatusSimpleText ();
        /// <summary>
        /// This function get string for status "FASTEST" in game from correct language pack.
        /// </summary>
        /// <returns>"Fastest" in correct language</returns>
        string GetStatusFastestText ();
        /// <summary>
        /// This function get string for status "FAST" in game from correct language pack.
        /// </summary>
        /// <returns>"Fast" in correct language</returns>
        string GetStatusFastText ();
        /// <summary>
        /// This function get string for status "GOOD" in game from correct language pack.
        /// </summary>
        /// <returns>"Good" in correct language</returns>
        string GetStatusGoodText ();
        /// <summary>
        /// This function get string for status "Beautiful" in game from correct language pack.
        /// </summary>
        /// <returns>"Beautiful" in correct language</returns>
        string GetStatusBeautifulText ();
        /// <summary>
        /// This function get string for status "FANTASTIC" in game from correct language pack.
        /// </summary>
        /// <returns>"Fantastic" in correct language</returns>
        string GetStatusFantasticText ();
        /// <summary>
        /// This function get string for status "DEFAULT" in game from correct language pack.
        /// </summary>
        /// <returns>"Default" in correct language</returns>
        string GetStatusDefaultText ();
    }
}
