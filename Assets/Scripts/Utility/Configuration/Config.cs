using UnityEngine;

namespace Scripts.Utility.Configuration {
    public class Config : IConfig {
        public LanguageSystem.Language myLanguage { get; set; }
        public AudioConfig audio { get; set; }
        public GraphicConfig graphic { get; set; }

        public Config () {
            audio = new AudioConfig ();
            graphic = new GraphicConfig ();
        }

        /// <summary>
        /// Change language
        /// </summary>
        /// <param name="newLanguage">Set this language</param>
        void IConfig.ChangeLanguage(LanguageSystem.Language newLanguage) {
            myLanguage = newLanguage;
        }
        /// <summary>
        /// Set default initialization
        /// </summary>
        void IConfig.DefaultInitialization () {
            myLanguage = LanguageSystem.Language.English;
            audio.DefaultInitialization ();
            graphic.DefaultInitialization ();
        }
        /// <summary>
        /// Get actual language
        /// </summary>
        /// <returns>Actual language</returns>
        LanguageSystem.Language IConfig.GetLanguage () {
            return myLanguage;
        }

        #region IAudioConfigurator

        /// <summary>
        /// Return sound state
        /// </summary>
        /// <returns>TRUE: if is unmute (if sounds == true)</returns>
        bool IAudioConfigurator.IsSoundUnmute () {
            return audio.soundState;
        }
        /// <summary>
        /// Return music state
        /// </summary>
        /// <returns>TRUE: if is unmute (if music == true)</returns>
        bool IAudioConfigurator.IsMusicUnmute () {
            return audio.musicState;
        }
        /// <summary>
        /// Return dialogue state
        /// </summary>
        /// <returns>TRUE: if is unmute (if dialogue == true)</returns>
        bool IAudioConfigurator.IsDialogueUnmute () {
            return audio.dialogueState;
        }
        /// <summary>
        /// Return all audio state
        /// </summary>
        /// <returns>TRUE: if is unmute (if allAudio == true)</returns>
        /// 
        bool IAudioConfigurator.IsAllAudioUnmute () {
            return audio.allAudioState;
        }

        /// <summary>
        /// Switch sound state (on -> off / off -> on)
        /// </summary>
        void IAudioConfigurator.SwitchSoundState () {
            audio.soundState = !audio.soundState;
        }
        /// <summary>
        /// Switch music state (on -> off / off -> on)
        /// </summary>
        void IAudioConfigurator.SwitchMusicState () {
            audio.musicState = !audio.musicState;
        }
        /// <summary>
        /// Switch dialogue state (on -> off / off -> on)
        /// </summary>
        void IAudioConfigurator.SwitchDialogueState () {
            audio.dialogueState = !audio.dialogueState;
        }
        /// <summary>
        /// Switch all audio state (on -> off / off -> on)
        /// </summary>
        void IAudioConfigurator.SwitchAllAudioState () {
            audio.allAudioState = !audio.allAudioState;
        }

        /// <summary>
        /// Increase sound level by defined value
        /// </summary>
        /// <returns>FALSE if sound level wasn't change</returns>
        bool IAudioConfigurator.IncreaseSoundLevel () {
            if ( audio.soundLevel >= audio.MAX_VALUE ) {
                audio.soundLevel = audio.MAX_VALUE;
                return false;
            }

            audio.soundLevel += audio.CHANGE_VALUE;
            return true;
        }
        /// <summary>
        /// Increase music level by defined value
        /// </summary>
        /// <returns>FALSE if music level wasn't change</returns>
        bool IAudioConfigurator.IncreaseMusicLevel () {
            if ( audio.musicLevel >= audio.MAX_VALUE ) {
                audio.musicLevel = audio.MAX_VALUE;
                return false;
            }

            audio.musicLevel += audio.CHANGE_VALUE;
            return true;
        }
        /// <summary>
        /// Increase dialogue level by defined value
        /// </summary>
        /// <returns>FALSE if dialogue level wasn't change</returns>
        bool IAudioConfigurator.IncreaseDialogueLevel () {
            if ( audio.dialogueLevel >= audio.MAX_VALUE ) {
                audio.dialogueLevel = audio.MAX_VALUE;
                return false;
            }

            audio.dialogueLevel += audio.CHANGE_VALUE;
            return true;
        }
        /// <summary>
        /// Increase all audio level by defined value
        /// </summary>
        /// <returns>FALSE if all audio level wasn't change</returns>
        bool IAudioConfigurator.IncreaseAllAudioLevel () {
            if ( audio.allAudioLevel >= audio.MAX_VALUE ) {
                audio.allAudioLevel = audio.MAX_VALUE;
                return false;
            }

            audio.allAudioLevel += audio.CHANGE_VALUE;
            return true;
        }

        /// <summary>
        /// Decrease sound level by defined value
        /// </summary>
        /// <returns>FALSE if sound level wasn't change</returns>
        bool IAudioConfigurator.DecreaseSoundLevel () {
            if ( audio.soundLevel <= audio.MIN_VALUE ) {
                audio.soundLevel = audio.MIN_VALUE;
                return false;
            }

            audio.soundLevel -= audio.CHANGE_VALUE;
            return true;
        }
        /// <summary>
        /// Decrease music level by defined value
        /// </summary>
        /// <returns>FALSE if music level wasn't change</returns>
        bool IAudioConfigurator.DecreaseMusicLevel () {
            if ( audio.musicLevel <= audio.MIN_VALUE ) {
                audio.musicLevel = audio.MIN_VALUE;
                return false;
            }

            audio.musicLevel -= audio.CHANGE_VALUE;
            return true;
        }
        /// <summary>
        /// Decrease dialogue level by defined value
        /// </summary>
        /// <returns>FALSE if dialogue level wasn't change</returns>
        bool IAudioConfigurator.DecreaseDialogueLevel () {
            if ( audio.dialogueLevel <= audio.MIN_VALUE ) {
                audio.dialogueLevel = audio.MIN_VALUE;
                return false;
            }

            audio.dialogueLevel -= audio.CHANGE_VALUE;
            return true;
        }
        /// <summary>
        /// Decrease all audio level by defined value
        /// </summary>
        /// <returns>FALSE if all audio level wasn't change</returns>
        bool IAudioConfigurator.DecreaseAllAudioLevel () {
            if ( audio.allAudioLevel <= audio.MIN_VALUE ) {
                audio.allAudioLevel = audio.MIN_VALUE;
                return false;
            }

            audio.allAudioLevel -= audio.CHANGE_VALUE;
            return true;
        }

        /// <summary>
        /// Set sound level
        /// </summary>
        /// <param name="level">New sound level</param>
        /// <returns>TRUE if sound level is change</returns>
        bool IAudioConfigurator.SetSoundLevel ( float level ) {
            if ( level <= audio.MIN_VALUE ) {
                audio.soundLevel = audio.MIN_VALUE;
                return false;
            }
            if (level >= audio.MAX_VALUE) {
                audio.soundLevel = audio.MAX_VALUE;
                return false;
            }
            audio.soundLevel = level;
            return true;
        }
        /// <summary>
        /// Set music level
        /// </summary>
        /// <param name="level">New music level</param>
        /// <returns>TRUE if music level is change</returns>
        bool IAudioConfigurator.SetMusicLevel ( float level ) {
            if ( level <= audio.MIN_VALUE ) {
                audio.musicLevel = audio.MIN_VALUE;
                return false;
            }
            if ( level >= audio.MAX_VALUE ) {
                audio.musicLevel = audio.MAX_VALUE;
                return false;
            }
            audio.musicLevel = level;
            return true;
        }
        /// <summary>
        /// Set dialogue level
        /// </summary>
        /// <param name="level">New dialogue level</param>
        /// <returns>TRUE if dialogue level is change</returns>
        bool IAudioConfigurator.SetDialogueLevel ( float level ) {
            if ( level <= audio.MIN_VALUE ) {
                audio.dialogueLevel = audio.MIN_VALUE;
                return false;
            }
            if ( level >= audio.MAX_VALUE ) {
                audio.dialogueLevel = audio.MAX_VALUE;
                return false;
            }
            audio.dialogueLevel = level;
            return true;
        }
        /// <summary>
        /// Set all audio level
        /// </summary>
        /// <param name="level">New all audio level</param>
        /// <returns>TRUE if all audio level is change</returns>
        bool IAudioConfigurator.SetAllAudioLevel ( float level ) {
            if ( level <= audio.MIN_VALUE ) {
                audio.allAudioLevel = audio.MIN_VALUE;
                return false;
            }
            if ( level >= audio.MAX_VALUE ) {
                audio.allAudioLevel = audio.MAX_VALUE;
                return false;
            }
            audio.allAudioLevel = level;
            return true;
        }
        #endregion

        #region IGraphicConfigurator
        /// <summary>
        /// Switch additional effects state (on to off or off to on)
        /// </summary>
        void IGraphicConfigurator.SwitchStateAdditionalEffects () {
            graphic.additionalEffectsState = !graphic.additionalEffectsState;
        }
        /// <summary>
        /// Get actual additional effects state
        /// </summary>
        /// <returns>Actual additional effects state</returns>
        bool IGraphicConfigurator.GetStateAdditionalEffects () {
            return graphic.additionalEffectsState;
        }

        /// <summary>
        /// Set new resolution
        /// </summary>
        /// <param name="newResolution">Setting resolution</param>
        void IGraphicConfigurator.SetResolution ( Resolution newResolution ) {
            graphic.actualResolution = newResolution;
        }
        /// <summary>
        /// Return actual resolution
        /// </summary>
        /// <returns>Actual resolution</returns>
        Resolution IGraphicConfigurator.GetResolution () {
            return graphic.actualResolution;
        }
        /// <summary>
        /// Return all available resolutions
        /// </summary>
        /// <returns>All available resolutions</returns>
        Resolution[] IGraphicConfigurator.GetAvailableResolutions () {
            return Screen.resolutions;
        }

        /// <summary>
        /// Switch VSync state (from ON to OFF or from OFF to ON)
        /// </summary>
        void IGraphicConfigurator.SwitchVSyncState () {
            graphic.vSyncState = !graphic.vSyncState;
        }
        /// <summary>
        /// Get actual VSync state
        /// </summary>
        /// <returns>VSync state</returns>
        bool IGraphicConfigurator.GetVSyncState () {
            return graphic.vSyncState;
        }

        /// <summary>
        /// Get actual Level of Details
        /// </summary>
        /// <returns>Level of Details</returns>
        LOD IGraphicConfigurator.GetActualLOD () {
            return graphic.actualLOD;
        }
        /// <summary>
        /// Set new Level of Details
        /// </summary>
        /// <param name="newLevel">New Level of Detail</param>
        void IGraphicConfigurator.SetActualLOD ( LOD newLevel ) {
            graphic.actualLOD = newLevel;
        }
        /// <summary>
        /// Get all available Level of Details
        /// </summary>
        /// <returns>Available Level of Details</returns>
        LOD[] IGraphicConfigurator.GetAvailableLOD () {
            LOD[] tmp = { LOD.LOW, LOD.MEDIUM, LOD.HIGH };
            return tmp;
        }

        /// <summary>
        /// Get actual texture quality level
        /// </summary>
        /// <returns>Actual texture quality level</returns>
        TextureQuality IGraphicConfigurator.GetActualTextureQuality () {
            return graphic.actualTextureQuality;
        }
        /// <summary>
        /// Set new texture quality level
        /// </summary>
        /// <param name="newTextureQuality">New texture quality level</param>
        void IGraphicConfigurator.SetActualTextureQuality ( TextureQuality newTextureQuality ) {
            graphic.actualTextureQuality = newTextureQuality;
        }
        /// <summary>
        /// Get available texture qualities
        /// </summary>
        /// <returns>All available texture qualities</returns>
        TextureQuality[] IGraphicConfigurator.GetAvailableTextureQualities () {
            TextureQuality[] tmp = {TextureQuality.LOW, TextureQuality.MEDIUM, TextureQuality.HIGH};
            return tmp;
        }

        /// <summary>
        /// Get actual AntiAliasing level
        /// </summary>
        /// <returns>Actual AntiAliasing</returns>
        AntiAliasing IGraphicConfigurator.GetActualAntiAliasing () {
            return graphic.actualAntiAliasing;
        }
        /// <summary>
        /// Set new AntiAliasing level
        /// </summary>
        /// <param name="newAntiAliasing">New AntiAliasing level</param>
        void IGraphicConfigurator.SetActualAntiAliasing ( AntiAliasing newAntiAliasing ) {
            graphic.actualAntiAliasing = newAntiAliasing;
        }
        /// <summary>
        /// Return all available AntiAliasing levels
        /// </summary>
        /// <returns>Available AntiAliasing levels</returns>
        AntiAliasing[] IGraphicConfigurator.GetAvailableAntiAliasings () {
            AntiAliasing[] tmp = { AntiAliasing.OFF, AntiAliasing.LOW, AntiAliasing.MEDIUM, AntiAliasing.HIGH };
            return tmp;
        }

        /// <summary>
        /// Get actual quality level
        /// </summary>
        /// <returns>Number of quality level</returns>
        int IGraphicConfigurator.GetActualQualityLevel () {
            return graphic.actualQualityConfig;
        }
        /// <summary>
        /// Set new quality level
        /// </summary>
        /// <param name="newLevel">New quality level</param>
        /// <returns></returns>
        bool IGraphicConfigurator.SetActualQualityLevel ( int newLevel ) {
            if ( newLevel < graphic.MIN_QUALITY_LEVEL || 
                newLevel > graphic.MAX_QUALITY_LEVEL )
                return false;
            graphic.actualQualityConfig = newLevel;
            return true;
        }
        /// <summary>
        /// Get all available quality levels
        /// </summary>
        /// <returns>Available quality levels</returns>
        int[] IGraphicConfigurator.GetAvailableQualityLevels () {
            int[] tmp = {0, 1, 2, 3, 4, 5, 6};
            return tmp;
        }

        /// <summary>
        /// Get state of triple buffering
        /// </summary>
        /// <returns>Actual state of triple buffering</returns>
        bool IGraphicConfigurator.GetTripleBufferingState () {
            return graphic.tripleBufferingState;
        }
        /// <summary>
        /// Switch triple buffering state (from ON to OFF or from OFF to ON)
        /// </summary>
        void IGraphicConfigurator.SwitchTripleBufferingState () {
            graphic.tripleBufferingState = !graphic.tripleBufferingState;
        }
        #endregion
    }
}
