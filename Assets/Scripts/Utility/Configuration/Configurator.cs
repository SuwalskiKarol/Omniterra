using Scripts.Utility.LanguageSystem;
using UnityEngine;

namespace Scripts.Utility.Configuration {
    public class Configurator : IConfig {
        private static Configurator instance;

        private IConfig config;
        private Serializer.ISerializerConfiguration serializer;

        protected Configurator () {
            serializer = Serializer.SerializerByXML.GetInstance ();
            config = serializer.LoadConfigFile ();
            if ( config == null ) {
                config = new Config ();
                config.DefaultInitialization ();
                serializer.SaveConfigFile ( (config as Config) );
            }
        }
        /// <summary>
        /// THIS MUST BE REWRITING BY KRAKERS!
        /// </summary>
        public void SaveAndUseConfig () {
            serializer.SaveConfigFile ( ( config as Config ) );
            // TODO: tutaj Krakers musisz uzupełnić zmiany z config'a do Unity.
        }

        public static Configurator GetInstance () {
            return ( instance ?? ( instance = new Configurator () ) );
        }

        public Language GetLanguage () {
            return config.GetLanguage ();
        }

        public void ChangeLanguage ( Language newLanguage ) {
            this.config.ChangeLanguage ( newLanguage );
        }

        public bool DecreaseAllAudioLevel () {
            return this.config.DecreaseAllAudioLevel ();
        }

        public bool DecreaseDialogueLevel () {
            return this.config.DecreaseDialogueLevel ();
        }

        public bool DecreaseMusicLevel () {
            return this.config.DecreaseMusicLevel ();
        }

        public bool DecreaseSoundLevel () {
            return this.config.DecreaseSoundLevel ();
        }

        public void DefaultInitialization () {
            this.config.DefaultInitialization ();
        }

        public AntiAliasing GetActualAntiAliasing () {
            return this.config.GetActualAntiAliasing ();
        }

        public LOD GetActualLOD () {
            return this.config.GetActualLOD ();
        }

        public int GetActualQualityLevel () {
            return this.config.GetActualQualityLevel ();
        }

        public TextureQuality GetActualTextureQuality () {
            return this.config.GetActualTextureQuality ();
        }

        public AntiAliasing[] GetAvailableAntiAliasings () {
            return this.config.GetAvailableAntiAliasings ();
        }

        public LOD[] GetAvailableLOD () {
            return this.config.GetAvailableLOD ();
        }

        public int[] GetAvailableQualityLevels () {
            return this.config.GetAvailableQualityLevels ();
        }

        public Resolution[] GetAvailableResolutions () {
            return this.config.GetAvailableResolutions ();
        }

        public TextureQuality[] GetAvailableTextureQualities () {
            return this.config.GetAvailableTextureQualities ();
        }

        public Resolution GetResolution () {
            return this.config.GetResolution ();
        }

        public bool GetStateAdditionalEffects () {
            return this.config.GetStateAdditionalEffects ();
        }

        public bool GetTripleBufferingState () {
            return this.config.GetTripleBufferingState ();
        }

        public bool GetVSyncState () {
            return this.config.GetVSyncState ();
        }

        public bool IncreaseAllAudioLevel () {
            return this.config.IncreaseAllAudioLevel ();
        }

        public bool IncreaseDialogueLevel () {
            return this.config.IncreaseDialogueLevel ();
        }

        public bool IncreaseMusicLevel () {
            return this.config.IncreaseMusicLevel ();
        }

        public bool IncreaseSoundLevel () {
            return this.config.IncreaseSoundLevel ();
        }

        public bool IsAllAudioUnmute () {
            return this.config.IsAllAudioUnmute ();
        }

        public bool IsDialogueUnmute () {
            return this.config.IsDialogueUnmute ();
        }

        public bool IsMusicUnmute () {
            return this.config.IsMusicUnmute ();
        }

        public bool IsSoundUnmute () {
            return this.config.IsSoundUnmute ();
        }

        public void SetActualAntiAliasing ( AntiAliasing newAntiAliasing ) {
            this.config.SetActualAntiAliasing ( newAntiAliasing );
        }

        public void SetActualLOD ( LOD newLevel ) {
            this.config.SetActualLOD ( newLevel );
        }

        public bool SetActualQualityLevel ( int newLevel ) {
            return this.config.SetActualQualityLevel ( newLevel );
        }

        public void SetActualTextureQuality ( TextureQuality newTextureQuality ) {
            this.config.SetActualTextureQuality ( newTextureQuality );
        }

        public bool SetAllAudioLevel ( float level ) {
            return this.config.SetAllAudioLevel ( level );
        }

        public bool SetDialogueLevel ( float level ) {
            return this.config.SetDialogueLevel ( level );
        }

        public bool SetMusicLevel ( float level ) {
            return this.config.SetMusicLevel ( level );
        }

        public void SetResolution ( Resolution newResolution ) {
            this.config.SetResolution ( newResolution );
        }

        public bool SetSoundLevel ( float level ) {
            return this.config.SetSoundLevel ( level );
        }

        public void SwitchAllAudioState () {
            this.config.SwitchAllAudioState ();
        }

        public void SwitchDialogueState () {
            this.config.SwitchDialogueState ();
        }

        public void SwitchMusicState () {
            this.config.SwitchMusicState ();
        }

        public void SwitchSoundState () {
            this.config.SwitchSoundState ();
        }

        public void SwitchStateAdditionalEffects () {
            this.config.SwitchStateAdditionalEffects ();
        }

        public void SwitchTripleBufferingState () {
            this.config.SwitchTripleBufferingState ();
        }

        public void SwitchVSyncState () {
            this.config.SwitchVSyncState ();
        }
    }
}
