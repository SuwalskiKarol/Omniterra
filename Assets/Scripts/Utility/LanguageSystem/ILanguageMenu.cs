namespace Scripts.Utility.LanguageSystem {
    /// <summary>
    /// Interface for handling all texts in menus.
    /// </summary>
    public interface  ILanguageMenu : ILanguageSystem {
        /// <summary>
        /// This function get string for button "Credits" in game from correct language pack.
        /// </summary>
        /// <returns>"Credits" in correct language</returns>
        string GetTextButtonCredits ();
        /// <summary>
        /// This function get string for button "Options" in game from correct language pack.
        /// </summary>
        /// <returns>"Options" in correct language</returns>
        string GetTextButtonOptions ();
        /// <summary>
        /// This function get string for button "Exit" in game from correct language pack.
        /// </summary>
        /// <returns>"Exit" in correct language</returns>
        string GetTextButtonExit ();
        /// <summary>
        /// This function get string for text area with confirmation exit text in game from correct language pack.
        /// </summary>
        /// <returns>Exit confirmation question in correct language</returns>
        string GetTextConfirmationExit ();
        /// <summary>
        /// This function get string for button "Accept" in game from correct language pack.
        /// </summary>
        /// <returns>"Accept" in correct language</returns>
        string GetTextButtonAcceptExit ();
        /// <summary>
        /// This function get string for button "Decline" in game from correct language pack.
        /// </summary>
        /// <returns>"Decline" in correct language</returns>
        string GetTextButtonDeclineExit ();
        /// <summary>
        /// This function get string for button "Audio" in game from correct language pack.
        /// </summary>
        /// <returns>"Audio" in correct language</returns>
        string GetTextButtonAudio ();
        /// <summary>
        /// This function get string for button "Language" in game from correct language pack.
        /// </summary>
        /// <returns>"Language" in correct language</returns>
        string GetTextButtonLanguage ();
        /// <summary>
        /// This function get string for button "Graphics" in game from correct language pack.
        /// </summary>
        /// <returns>"Graphics" in correct language</returns>
        string GetTextButtonGraphics ();
        /// <summary>
        /// This function get string for button "Keys" in game from correct language pack.
        /// </summary>
        /// <returns>"Keys" in correct language</returns>
        string GetTextButtonKeys ();
        /// <summary>
        /// This function get string for button "Multiplayer" in game from correct language pack.
        /// </summary>
        /// <returns>"Multiplayer" in correct language</returns>
        string GetTextButtonMulti ();
        /// <summary>
        /// This function get string for button "Singleplayer" in game from correct language pack.
        /// </summary>
        /// <returns>"Singleplayer" in correct language</returns>
        string GetTextButtonSingle ();
        /// <summary>
        /// This function get string for button "Select map" in game from correct language pack.
        /// </summary>
        /// <returns>"Select map" in correct language</returns>
        string GetTextButtonSelectMap ();
        /// <summary>
        /// This function get string for button "Campaign" in game from correct language pack.
        /// </summary>
        /// <returns>"Campaign" in correct language</returns>
        string GetTextButtonCampaign ();
        /// <summary>
        /// This function get string for button "Select campaign" in game from correct language pack.
        /// </summary>
        /// <returns>"Select campaign" in correct language</returns>
        string GetTextButtonSelectCampaign ();
        /// <summary>
        /// This function get string for button "Load state game" in game from correct language pack.
        /// </summary>
        /// <returns>"Load game" in correct language</returns>
        string GetTextButtonLoadState ();
        /// <summary>
        /// This function get string for button "Back" in game from correct language pack.
        /// </summary>
        /// <returns>"Back" in correct language</returns>
        string GetTextButtonBack ();
        /// <summary>
        /// This function get string for button "Start" in game from correct language pack.
        /// </summary>
        /// <returns>"Start" in correct language</returns>
        string GetTextButtonStart ();
    }
}