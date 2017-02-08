using System;
using System.Collections.Generic;

namespace Scripts.Utility.LanguageSystem {
    /// <summary>
    /// Main language manager. Here is all function to getting all texts (by regions) and by this manager developer must take specific texts grup.
    /// </summary>
    public class LanguageManager : ILanguageSystem, IAvailableLanguages, ILanguageAudioMenu, ILanguageGraphicsMenu, ILanguageMenu, ILanguageNamesKey {
        private Dictionary<MenuTextKeys, string> menuTexts;
        private Dictionary<Keys.KeyName, string> nameKeys;
        private Dictionary<Language, string> availableLanguages;
        private Dictionary<GraphicsTextKeys, string> graphicsMenuTexts;
        private Dictionary<AudioTextKeys, string> audioMenuTexts;

        private static LanguageManager instance;
        private Serializer.ISerializerTexts serializer;


        private LanguageManager () {
            serializer = Serializer.SerializerByXML.GetInstance ();
        }

        /// <summary>
        /// Take instance of Language manager.
        /// </summary>
        /// <returns>Instance of Language Manager.</returns>
        public static LanguageManager GetInstance () {
            return ( instance ?? ( instance = new LanguageManager () ) );
        }

        #region ILanguageSystem
        bool ILanguageSystem.LoadTextsFrom ( LanguageFiles file ) {
            bool result = true;
            try {
                switch ( file ) {
                    case LanguageFiles.AUDIO_MENU_TEXTS:
                    //audioMenuTexts = serializer.
                    break;

                    case LanguageFiles.AVAILABLE_LANGUAGES:
                    break;

                    case LanguageFiles.GRAPHICS_MENU_TEXTS:
                    break;

                    case LanguageFiles.MENU:
                    menuTexts = serializer.LoadMainMenu (); // tymczasowo!!
                    break;

                    case LanguageFiles.NAMES_KEY:
                    break;
                }

            } catch ( Exception err ) {
                Console.Message msg = new Console.Message ( err.Message );
                Console.Console.GetInstance ().AddLog ( msg );
                result = false;
            }

            return result;
        }

        bool ILanguageSystem.UnloadTextsFrom ( LanguageFiles file ) {
            switch ( file ) {
                case LanguageFiles.AUDIO_MENU_TEXTS:
                audioMenuTexts = null;
                break;

                case LanguageFiles.AVAILABLE_LANGUAGES:
                availableLanguages = null;
                break;

                case LanguageFiles.GRAPHICS_MENU_TEXTS:
                graphicsMenuTexts = null;
                break;

                case LanguageFiles.MENU:
                menuTexts = null;
                break;

                case LanguageFiles.NAMES_KEY:
                nameKeys = null;
                break;
            }

            return true;
        }

        bool ILanguageSystem.UnloadAll () {
            menuTexts = null;
            nameKeys = null;
            availableLanguages = null;
            graphicsMenuTexts = null;
            audioMenuTexts = null;

            return true;
    }
        
        /// <summary>
        /// Reload all initialized language files
        /// </summary>
        void ILanguageSystem.ReloadAll () {
            if ( menuTexts != null )
                menuTexts = serializer.LoadMainMenu ();
            if ( nameKeys != null )
                nameKeys = serializer.LoadNamesKeys ();
            if ( availableLanguages != null )
                availableLanguages = serializer.LoadLanguageKeys ();
            if ( graphicsMenuTexts != null )
                graphicsMenuTexts = serializer.LoadTextGraphicsMenu ();
            if ( audioMenuTexts != null )
                audioMenuTexts = serializer.LoadTextAudioMenu ();
        }

        ILanguageMenu ILanguageSystem.MenuLanguageSystem () {
            return (this as ILanguageMenu);
        }

        ILanguageAudioMenu ILanguageSystem.AudioMenuLanguageSystem () {
            return (this as ILanguageAudioMenu);
        }

        ILanguageGraphicsMenu ILanguageSystem.GraphicsMenuLanguageSystem () {
            return (this as ILanguageGraphicsMenu);
        }

        ILanguageNamesKey ILanguageSystem.LanguageNamesKey () {
            return (this as ILanguageNamesKey);
        }

        IAvailableLanguages ILanguageSystem.AvailableLanguages () {
            return (this as IAvailableLanguages);
        }
        #endregion

        #region IAvailableLanguages
        string IAvailableLanguages.GetNamePolish () {
            return availableLanguages[Language.Polish];
        }

        string IAvailableLanguages.GetNameEnglish () {
            return availableLanguages[Language.English];
        }
        #endregion

        #region ILanguageAudioMenu

        string ILanguageAudioMenu.GetSoundText () {
            return audioMenuTexts[AudioTextKeys.SOUNDS];
        }

        string ILanguageAudioMenu.GetMusicText () {
            return audioMenuTexts[AudioTextKeys.MUSIC];
        }

        string ILanguageAudioMenu.GetStatusOnText () {
            return audioMenuTexts[AudioTextKeys.ON];
        }

        string ILanguageAudioMenu.GetStatusOffText () {
            return audioMenuTexts[AudioTextKeys.OFF];
        }
        #endregion

        #region ILanguageGraphicsMenu
        string ILanguageGraphicsMenu.GetResolutionText () {
            return graphicsMenuTexts[GraphicsTextKeys.RESOLUTION];
        }

        string ILanguageGraphicsMenu.GetGraphicLevelText () {
            return graphicsMenuTexts[GraphicsTextKeys.GRAPHIC_LEVEL];
        }

        string ILanguageGraphicsMenu.GetVSyncText () {
            return graphicsMenuTexts[GraphicsTextKeys.VSYNC];
        }

        string ILanguageGraphicsMenu.GetTripleBufferingText () {
            return graphicsMenuTexts[GraphicsTextKeys.TRIPLE_BUFFERING];
        }

        string ILanguageGraphicsMenu.GetLevelOfDetailText () {
            return graphicsMenuTexts[GraphicsTextKeys.LEVEL_OF_DETAIL];
        }

        string ILanguageGraphicsMenu.GetTextureQualityText () {
            return graphicsMenuTexts[GraphicsTextKeys.TEXTURE_QUALITY];
        }

        string ILanguageGraphicsMenu.GetAdditionalEffectsText () {
            return graphicsMenuTexts[GraphicsTextKeys.ADDITIONAL_EFFECTS];
        }

        string ILanguageGraphicsMenu.GetAntialiasingText () {
            return graphicsMenuTexts[GraphicsTextKeys.ANTIALIASING];
        }

        string ILanguageGraphicsMenu.GetStatusLow () {
            return graphicsMenuTexts[GraphicsTextKeys.LOW];
        }

        string ILanguageGraphicsMenu.GetStatusMediumText () {
            return graphicsMenuTexts[GraphicsTextKeys.MEDIUM];
        }

        string ILanguageGraphicsMenu.GetStatusHighText () {
            return graphicsMenuTexts[GraphicsTextKeys.HIGH];
        }

        string ILanguageGraphicsMenu.GetStatusSimpleText () {
            return graphicsMenuTexts[GraphicsTextKeys.SIMPLE];
        }

        string ILanguageGraphicsMenu.GetStatusFastestText () {
            return graphicsMenuTexts[GraphicsTextKeys.FASTEST];
        }

        string ILanguageGraphicsMenu.GetStatusFastText () {
            return graphicsMenuTexts[GraphicsTextKeys.FAST];
        }

        string ILanguageGraphicsMenu.GetStatusGoodText () {
            return graphicsMenuTexts[GraphicsTextKeys.GOOD];
        }

        string ILanguageGraphicsMenu.GetStatusBeautifulText () {
            return graphicsMenuTexts[GraphicsTextKeys.BEAUTIFUL];
        }

        string ILanguageGraphicsMenu.GetStatusFantasticText () {
            return graphicsMenuTexts[GraphicsTextKeys.FANTASTIC];
        }

        string ILanguageGraphicsMenu.GetStatusDefaultText () {
            return graphicsMenuTexts[GraphicsTextKeys.DEFAULT];
        }

        string ILanguageGraphicsMenu.GetStatusOnText () {
            return graphicsMenuTexts[GraphicsTextKeys.ON];
        }

        string ILanguageGraphicsMenu.GetStatusOffText () {
            return graphicsMenuTexts[GraphicsTextKeys.OFF];
        }
        #endregion

        #region ILanguageMenu

        string ILanguageMenu.GetTextButtonCredits () {
            return menuTexts[MenuTextKeys.CREDITS];
        }

        string ILanguageMenu.GetTextButtonOptions () {
            return menuTexts[MenuTextKeys.OPTIONS];
        }

        string ILanguageMenu.GetTextButtonExit () {
            return menuTexts[MenuTextKeys.EXIT];
        }

        string ILanguageMenu.GetTextConfirmationExit () {
            return menuTexts[MenuTextKeys.CONFIRMATION_EXIT_MESSAGE];
        }

        string ILanguageMenu.GetTextButtonAcceptExit () {
            return menuTexts[MenuTextKeys.ACCEPT_EXIT];
        }

        string ILanguageMenu.GetTextButtonDeclineExit () {
            return menuTexts[MenuTextKeys.DECLINE_EXIT];
        }

        string ILanguageMenu.GetTextButtonAudio () {
            return menuTexts[MenuTextKeys.AUDIO];
        }

        string ILanguageMenu.GetTextButtonLanguage () {
            return menuTexts[MenuTextKeys.LANGUAGES];
        }

        string ILanguageMenu.GetTextButtonGraphics () {
            return menuTexts[MenuTextKeys.GRAPHICS];
        }

        string ILanguageMenu.GetTextButtonKeys () {
            return menuTexts[MenuTextKeys.KEYS];
        }

        string ILanguageMenu.GetTextButtonMulti () {
            return menuTexts[MenuTextKeys.MULTI];
        }

        string ILanguageMenu.GetTextButtonSingle () {
            return menuTexts[MenuTextKeys.SINGLE];
        }

        string ILanguageMenu.GetTextButtonSelectMap () {
            return menuTexts[MenuTextKeys.SELECT_MAP];
        }

        string ILanguageMenu.GetTextButtonCampaign () {
            return menuTexts[MenuTextKeys.CAMPAIGN];
        }

        string ILanguageMenu.GetTextButtonSelectCampaign () {
            return menuTexts[MenuTextKeys.SELECT_CAMPAIGN];
        }

        string ILanguageMenu.GetTextButtonLoadState () {
            return menuTexts[MenuTextKeys.LOAD_STATE];
        }

        string ILanguageMenu.GetTextButtonBack () {
            return menuTexts[MenuTextKeys.BACK];
        }

        string ILanguageMenu.GetTextButtonStart () {
            return menuTexts[MenuTextKeys.START];
        }
        #endregion

        #region ILanguageNamesKey
        // TODO : POPRAW TO - zależy czy będzie w ogóle pokazywane od 1 do 0 i od F1 do F12 wsio, czy tylko adnotacja, czy w ogóle tego nie będzie widać w konfigurowaniu, a może tylko tooltipy?

        string ILanguageNamesKey.GetNameBackKey () {
            return nameKeys[Keys.KeyName.BACK_KEY];
        }

        string ILanguageNamesKey.GetNameCameraUpKey () {
            return nameKeys[Keys.KeyName.CAMERA_UP];
        }

        string ILanguageNamesKey.GetNameCameraDownKey () {
            return nameKeys[Keys.KeyName.CAMERA_DOWN];
        }

        string ILanguageNamesKey.GetNameCameraLeftKey () {
            return nameKeys[Keys.KeyName.CAMERA_LEFT];
        }

        string ILanguageNamesKey.GetNameCameraRightKey () {
            return nameKeys[Keys.KeyName.CAMERA_RIGHT];
        }

        string ILanguageNamesKey.GetNameGoAndAttack () {
            return nameKeys[Keys.KeyName.GO_AND_ATTACK];
        }

        string ILanguageNamesKey.GetNameUseSpecialAttack () {
            return nameKeys[Keys.KeyName.USE_SPECIAL_ATTACK];
        }

        string ILanguageNamesKey.GetNamePatrol () {
            return nameKeys[Keys.KeyName.PATROL];
        }

        string ILanguageNamesKey.GetNamePause () {
            return nameKeys[Keys.KeyName.PAUSE];
        }
        
        string ILanguageNamesKey.GetNameSwitchHudState () {
            return nameKeys[Keys.KeyName.SWITCH_HUD_STATE];
        }

        string ILanguageNamesKey.GetNameGoToAlert () {
            return nameKeys[Keys.KeyName.GO_TO_ALERT];
        }
        #endregion
    }
}