using KeyCode = UnityEngine.KeyCode;

namespace Scripts.Utility.Keys {
    /// <summary>
    /// Key additional class. Here we have two keys (normal + modificator), which will be used by user in game.
    /// </summary>
    public class Key {
        private const string KEY_MODIFICATOR_ERROR = "Sorry, but this key is modificator and can't be used like normal Key.";
        private const string KEY_NORMAL_ERROR = "Sorry, but i need here modificator key, not normal.";

        /// <summary>
        /// Main key. Can't be: 'Shift', 'Alt', 'Control'.
        /// </summary>
        public KeyCode myKey { get; set; }
        /// <summary>
        /// Modificator key. Only can be: 'Shift', 'Alt', 'Control'
        /// </summary>
        public KeyCode modificator { get; set; }

        /// <summary>
        /// Constructor with two parameteres.
        /// </summary>
        /// <param name="myKey">Normal key, wich user wanna be used.</param>
        /// <param name="modificator">Modificator key, wich user wanna be used.</param>
        public Key ( KeyCode myKey, KeyCode modificator ) {
            try {
                CheckMainKey ( myKey );
                this.myKey = myKey;
                CheckModificatorKey ( modificator );
                this.modificator = modificator;
            } catch ( Exceptions.InvalidKey err ) {
                Console.Message msg = new Console.Message ( err.Message );
                Console.Console.GetInstance ().AddLog ( msg );
            }
        }

        /// <summary>
        /// Constructor with one parameters.
        /// </summary>
        /// <param name="myKey">Normal key, wich user wanna be used.</param>
        public Key ( KeyCode myKey ) {
            try {
                CheckMainKey ( myKey );
                this.myKey = myKey;
            } catch ( Exceptions.InvalidKey err ) {
                Console.Message msg = new Console.Message ( err.Message );
                Console.Console.GetInstance ().AddLog ( msg );
            }
        }

        private bool isModificator ( KeyCode key ) {
            return ( key == KeyCode.LeftShift ||
                key == KeyCode.RightShift ||
                key == KeyCode.AltGr ||
                key == KeyCode.LeftAlt ||
                key == KeyCode.RightAlt ||
                key == KeyCode.LeftControl ||
                key == KeyCode.RightControl );
        }

        private void CheckMainKey ( KeyCode key ) {
            if ( isModificator ( key ) )
                throw new Exceptions.InvalidKey ( KEY_MODIFICATOR_ERROR );
        }

        private void CheckModificatorKey (KeyCode key) {
            if ( !isModificator ( key ) )
                throw new Exceptions.InvalidKey ( KEY_NORMAL_ERROR );
        }
    }
}
