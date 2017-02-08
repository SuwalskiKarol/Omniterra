using System;
using System.Collections.Generic;
using Scripts.Utility.Keys;
using Scripts.Utility.LanguageSystem;
using System.Xml.Serialization;
using System.IO;
using Scripts.Utility.Console;
using Scripts.Utility.Configuration;

namespace Scripts.Utility.Serializer {
    /// <summary>
    /// This clas represents serializer by XML specifics.
    /// </summary>
    public class SerializerByXML : Serializer {
        private XmlSerializer serializer;
        private TextWriter writer;
        private TextReader reader;

        private SerializerByXML () : base () {
            myConfig = new ConfigurationSerializerXML ();
        }
        /// <summary>
        /// Get serializer instance by XML specifics.
        /// </summary>
        /// <returns>Instance serializer by XML specifics.</returns>
        public static SerializerByXML GetInstance() {
            if ( instance == null )
                instance = new SerializerByXML ();

            return ( instance as SerializerByXML );
        }

        private void ClearData () {
            serializer = null;

            if ( writer != null )
                writer.Close ();
            writer = null;

            if ( reader != null )
                reader.Close ();
            reader = null;
        }

        private ConfigurationSerializerXML MyConfiguration () {
            return ( myConfig as ConfigurationSerializerXML );
        }

        #region ISerializerTexts
        /// <summary>
        /// Load available language names
        /// </summary>
        /// <returns>All language names</returns>
        public override Dictionary<Language, string> LoadLanguageKeys () {
            Dictionary<Language, string> result = new Dictionary<Language, string> ();
            try {
                List<KeyValuePair <Language, string> > loadList = new List<KeyValuePair<Language, string>> ();
                serializer = new XmlSerializer ( typeof ( List<KeyValuePair<Language, string>> ) );

                reader = new StreamReader ( MyConfiguration ().PathToAvailableLanguagesFile () );


                loadList = ( List<KeyValuePair<Language, string>> )serializer.Deserialize ( reader );

                foreach ( KeyValuePair<Language, string> element in loadList ) {
                    result.Add ( element.Key, element.Value );
                }

            } catch ( Exception err ) {
                UnityEngine.Debug.Log ( err );
            } finally {
                ClearData ();
            }
            return result;
        }

        /// <summary>
        /// Load available texts to Menu
        /// </summary>
        /// <returns>All texts to Menu</returns>
        public override Dictionary<MenuTextKeys, string> LoadMainMenu () {
            Dictionary<MenuTextKeys, string> result = new Dictionary<MenuTextKeys, string> ();
            try {
                List<KeyValuePair <MenuTextKeys, string> > loadList = new List<KeyValuePair<MenuTextKeys, string>> ();
                serializer = new XmlSerializer ( typeof ( List<KeyValuePair<MenuTextKeys, string>> ) );
                
                reader = new StreamReader ( MyConfiguration ().PathToMenuTextsFile () );


                loadList = ( List<KeyValuePair<MenuTextKeys, string>> )serializer.Deserialize ( reader );

                foreach ( KeyValuePair<MenuTextKeys, string> element in loadList ) {
                    result.Add ( element.Key, element.Value );
                }

            } catch ( Exception err ) {
                UnityEngine.Debug.Log ( err );
            } finally {
                ClearData ();
            }
            return result;
        }

        /// <summary>
        /// Load available key action names
        /// </summary>
        /// <returns>All key action names</returns>
        public override Dictionary<KeyName, string> LoadNamesKeys () {
            Dictionary<KeyName, string> result = new Dictionary<KeyName, string> ();
            try {
                List<KeyValuePair <KeyName, string> > loadList = new List<KeyValuePair<KeyName, string>> ();
                serializer = new XmlSerializer ( typeof ( List<KeyValuePair<KeyName, string>> ) );

                reader = new StreamReader ( MyConfiguration ().PathToKeysTextFile () );


                loadList = ( List<KeyValuePair<KeyName, string>> )serializer.Deserialize ( reader );

                foreach ( KeyValuePair<KeyName, string> element in loadList ) {
                    result.Add ( element.Key, element.Value );
                }

            } catch ( Exception err ) {
                UnityEngine.Debug.Log ( err );
            } finally {
                ClearData ();
            }
            return result;
        }

        /// <summary>
        /// Load available texts to audio menu
        /// </summary>
        /// <returns>All texts to audio menu</returns>
        public override Dictionary<AudioTextKeys, string> LoadTextAudioMenu () {
            Dictionary<AudioTextKeys, string> result = new Dictionary<AudioTextKeys, string> ();
            try {
                List<KeyValuePair <AudioTextKeys, string> > loadList = new List<KeyValuePair<AudioTextKeys, string>> ();
                serializer = new XmlSerializer ( typeof ( List<KeyValuePair<AudioTextKeys, string>> ) );

                reader = new StreamReader ( MyConfiguration ().PathToAudioTextsFile () );


                loadList = ( List<KeyValuePair<AudioTextKeys, string>> )serializer.Deserialize ( reader );

                foreach ( KeyValuePair<AudioTextKeys, string> element in loadList ) {
                    result.Add ( element.Key, element.Value );
                }

            } catch ( Exception err) {
                UnityEngine.Debug.Log ( err );
            } finally {
                ClearData ();
            }
            return result;
        }

        /// <summary>
        /// Load available texts to graphics menu
        /// </summary>
        /// <returns>All texts to graphics menu</returns>
        public override Dictionary<GraphicsTextKeys, string> LoadTextGraphicsMenu () {
            Dictionary<GraphicsTextKeys, string> result = new Dictionary<GraphicsTextKeys, string> ();
            try {
                List<KeyValuePair <GraphicsTextKeys, string> > loadList = new List<KeyValuePair<GraphicsTextKeys, string>> ();
                serializer = new XmlSerializer ( typeof ( List<KeyValuePair<GraphicsTextKeys, string>> ) );

                reader = new StreamReader ( MyConfiguration ().PathToGraphicTextsFile () );


                loadList = ( List<KeyValuePair<GraphicsTextKeys, string>> )serializer.Deserialize ( reader );

                foreach ( KeyValuePair<GraphicsTextKeys, string> element in loadList ) {
                    result.Add ( element.Key, element.Value );
                }

            } catch ( Exception err ) {
                UnityEngine.Debug.Log ( err );
            } finally {
                ClearData ();
            }
            return result;
        }
        #endregion

        #region ISerializerConsole
        /// <summary>
        /// This function will save a consoles configuration.
        /// </summary>
        /// <param name="myConsole">Console configuration file</param>
        /// <returns>If all operations going without errors: TRUE.
        /// If any operation going with any errors: FALSE.</returns>
        public override bool SaveConsoleConfig ( ConsoleConfig myConsole ) {
            bool result = true;
            try {
                serializer = new XmlSerializer ( typeof ( ConsoleConfig ) );

                writer = new StreamWriter ( MyConfiguration ().PathToConsoleFile () );

                serializer.Serialize ( writer, myConsole );
            } catch ( Exception err ) {
                UnityEngine.Debug.Log ( err );
                result = false;
            } finally {
                ClearData ();
            }
            return result;
        }

        /// <summary>
        /// Load existing configuration for console.
        /// </summary>
        /// <returns>Console Configuration</returns>
        public override ConsoleConfig LoadConsoleConfig () {
            ConsoleConfig cfg = null;
            
            try {
                serializer = new XmlSerializer ( typeof ( ConsoleConfig ) );

                reader = new StreamReader ( MyConfiguration ().PathToConsoleFile () );
                
                cfg = ( ConsoleConfig )serializer.Deserialize ( reader );
            } catch ( FileNotFoundException err ) {
                UnityEngine.Debug.Log ( err );
            } finally {
                ClearData ();
            }
            return cfg;
        }

        /// <summary>
        /// Save all logs from this session.
        /// </summary>
        /// <param name="name">Log file name</param>
        /// <param name="logs">List of all logs</param>
        /// <returns>If all operations going without errors: TRUE.
        /// If any operation going with any errors: FALSE.</returns>
        public override bool SaveLogFile ( string name, List<Message> logs ) {
            bool result = true;
            try {
                serializer = new XmlSerializer ( typeof ( List<Message> ) );

                writer = new StreamWriter ( MyConfiguration ().PathToLogFiles (name) );

                serializer.Serialize ( writer, logs );
            } catch ( Exception err ) {
                UnityEngine.Debug.Log ( err );
                result = false;
            } finally {
                ClearData ();
            }
            return result;
        }

        public override Config LoadConfigFile () {
            Config cfg = null;

            try {
                serializer = new XmlSerializer ( typeof ( Config ) );

                reader = new StreamReader ( MyConfiguration ().PathToConfigFile () );

                cfg = ( Config )serializer.Deserialize ( reader );
            } catch ( FileNotFoundException err ) {
                UnityEngine.Debug.Log ( err );
            } finally {
                ClearData ();
            }
            return cfg;
        }

        public override bool SaveConfigFile ( Config myConfig ) {
            bool result = true;
            try {
                serializer = new XmlSerializer ( typeof ( Config ) );

                writer = new StreamWriter ( MyConfiguration ().PathToConfigFile () );

                serializer.Serialize ( writer, myConfig );
            } catch ( Exception err ) {
                UnityEngine.Debug.Log ( err );
                result = false;
            } finally {
                ClearData ();
            }
            return result;
        }
        #endregion
    }
}