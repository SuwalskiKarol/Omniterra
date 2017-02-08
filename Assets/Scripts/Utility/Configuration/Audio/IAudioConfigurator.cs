namespace Scripts.Utility.Configuration {
    /// <summary>
    /// Interface to handling Audio Configuration
    /// </summary>
    public interface IAudioConfigurator {
        /// <summary>
        /// Return sound state
        /// </summary>
        /// <returns>TRUE: if is unmute (if sounds == true)</returns>
        bool IsSoundUnmute ();
        /// <summary>
        /// Return music state
        /// </summary>
        /// <returns>TRUE: if is unmute (if music == true)</returns>
        bool IsMusicUnmute ();
        /// <summary>
        /// Return dialogue state
        /// </summary>
        /// <returns>TRUE: if is unmute (if dialogue == true)</returns>
        bool IsDialogueUnmute ();
        /// <summary>
        /// Return all audio state
        /// </summary>
        /// <returns>TRUE: if is unmute (if allAudio == true)</returns>
        bool IsAllAudioUnmute ();

        /// <summary>
        /// Switch sound state (on -> off / off -> on)
        /// </summary>
        void SwitchSoundState ();
        /// <summary>
        /// Switch music state (on -> off / off -> on)
        /// </summary>
        void SwitchMusicState ();
        /// <summary>
        /// Switch dialogue state (on -> off / off -> on)
        /// </summary>
        void SwitchDialogueState ();
        /// <summary>
        /// Switch all audio state (on -> off / off -> on)
        /// </summary>
        void SwitchAllAudioState ();

        /// <summary>
        /// Increase sound level by defined value
        /// </summary>
        /// <returns>FALSE if sound level wasn't change</returns>
        bool IncreaseSoundLevel ();
        /// <summary>
        /// Increase music level by defined value
        /// </summary>
        /// <returns>FALSE if music level wasn't change</returns>
        bool IncreaseMusicLevel ();
        /// <summary>
        /// Increase dialogue level by defined value
        /// </summary>
        /// <returns>FALSE if dialogue level wasn't change</returns>
        bool IncreaseDialogueLevel ();
        /// <summary>
        /// Increase all audio level by defined value
        /// </summary>
        /// <returns>FALSE if all audio level wasn't change</returns>
        bool IncreaseAllAudioLevel ();

        /// <summary>
        /// Decrease sound level by defined value
        /// </summary>
        /// <returns>FALSE if sound level wasn't change</returns>
        bool DecreaseSoundLevel ();
        /// <summary>
        /// Decrease music level by defined value
        /// </summary>
        /// <returns>FALSE if music level wasn't change</returns>
        bool DecreaseMusicLevel ();
        /// <summary>
        /// Decrease dialogue level by defined value
        /// </summary>
        /// <returns>FALSE if dialogue level wasn't change</returns>
        bool DecreaseDialogueLevel ();
        /// <summary>
        /// Decrease all audio level by defined value
        /// </summary>
        /// <returns>FALSE if all audio level wasn't change</returns>
        bool DecreaseAllAudioLevel ();

        /// <summary>
        /// Set sound level
        /// </summary>
        /// <param name="level">New sound level</param>
        /// <returns>TRUE if sound level is change</returns>
        bool SetSoundLevel ( float level );
        /// <summary>
        /// Set music level
        /// </summary>
        /// <param name="level">New music level</param>
        /// <returns>TRUE if music level is change</returns>
        bool SetMusicLevel ( float level );
        /// <summary>
        /// Set dialogue level
        /// </summary>
        /// <param name="level">New dialogue level</param>
        /// <returns>TRUE if dialogue level is change</returns>
        bool SetDialogueLevel ( float level );
        /// <summary>
        /// Set all audio level
        /// </summary>
        /// <param name="level">New all audio level</param>
        /// <returns>TRUE if all audio level is change</returns>
        bool SetAllAudioLevel ( float level );

    }
}
