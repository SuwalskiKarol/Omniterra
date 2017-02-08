namespace Scripts.Utility.LanguageSystem {
    /// <summary>
    /// Interface for handling keyboard controls.
    /// </summary>
    public interface ILanguageNamesKey : ILanguageSystem {
        /// <summary>
        /// This function get string for label "BackKey" in game from correct language pack.
        /// </summary>
        /// <returns>"Back" in correct language</returns>
        string GetNameBackKey ();
        /// <summary>
        /// This function get string for label "CameraUp" in game from correct language pack.
        /// </summary>
        /// <returns>"Camera up" in correct language</returns>
        string GetNameCameraUpKey ();
        /// <summary>
        /// This function get string for label "CameraDown" in game from correct language pack.
        /// </summary>
        /// <returns>"Camera down" in correct language</returns>
        string GetNameCameraDownKey ();
        /// <summary>
        /// This function get string for label "CameraLeft" in game from correct language pack.
        /// </summary>
        /// <returns>"Camera left" in correct language</returns>
        string GetNameCameraLeftKey ();
        /// <summary>
        /// This function get string for label "CameraRight" in game from correct language pack.
        /// </summary>
        /// <returns>"Camera right" in correct language</returns>
        string GetNameCameraRightKey ();
        /// <summary>
        /// This function get string for label "GoAndAttack" in game from correct language pack.
        /// </summary>
        /// <returns>"Go and attack" in correct language</returns>
        string GetNameGoAndAttack ();
        /// <summary>
        /// This function get string for label "UseSpecialAttack" in game from correct language pack.
        /// </summary>
        /// <returns>"Use special attack" in correct language</returns>
        string GetNameUseSpecialAttack ();
        /// <summary>
        /// This function get string for label "Patrol" in game from correct language pack.
        /// </summary>
        /// <returns>"Patrol" in correct language</returns>
        string GetNamePatrol ();
        /// <summary>
        /// This function get string for label "Pause" in game from correct language pack.
        /// </summary>
        /// <returns>"Pause" in correct language</returns>
        string GetNamePause ();
        /// <summary>
        /// This function get string for label "SwitchHUDState" in game from correct language pack.
        /// </summary>
        /// <returns>"Switch HUD state" in correct language</returns>
        string GetNameSwitchHudState ();
        /// <summary>
        /// This function get string for label "GoToAlert" in game from correct language pack.
        /// </summary>
        /// <returns>"Go to alert" in correct language</returns>
        string GetNameGoToAlert ();
    }
}
