using System.Collections.Generic;

namespace Scripts.Utility.Keys {

    /// <summary>
    /// Key manager (is building at this moment, so here will be empty spaces).
    /// </summary>
    public class Keys {
        private static Keys instance;
        private Dictionary<KeyName, Key> availableKeys;
        private Serializer.ISerializerKey serializer;

        private Keys () {
            availableKeys = new Dictionary<KeyName, Key> ();
            // TODO : wczytanie z serializera zapisanych ustawień, w przeciwnym wypadku default;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Keys GetInstance () {
            return ( instance ?? ( instance = new Keys () ) );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool SetDefaultInitialization () {
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ChangeKey (KeyName key) {
            //Listener ();
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Key GetKeyFor (KeyName key) {
            return null;
        }

        private void ListenerKey (ref UnityEngine.KeyCode newKey, ref UnityEngine.KeyCode modificator) {
            //if (UnityEngine.Input.GetKeyDown)
                // później
        }



    }
}
