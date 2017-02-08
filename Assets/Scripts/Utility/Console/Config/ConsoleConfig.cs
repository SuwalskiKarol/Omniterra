using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Scripts.Utility.Console {
    /// <summary>
    /// Configuration file for in-game console
    /// </summary>
    public class ConsoleConfig {
        private const string SLASH = "/";
        private const string COLON = ":";
        private const string UNDERSCORE = "_";

        /// <summary>
        /// Name of file, where all actual logs will to be save.
        /// </summary>
        [XmlIgnore]
        public readonly string nameLogFile;
        /// <summary>
        /// Container with all logs for this season (normal commands and debugging).
        /// </summary>        
        [XmlIgnore]
        public readonly List<Message> logContainer;

        /// <summary>
        /// X-position console
        /// </summary>
        public float x { get; set; }
        /// <summary>
        /// Y-position console
        /// </summary>
        public float y { get; set; }

        /// <summary>
        /// Width console
        /// </summary>
        public float width { get; set; }
        /// <summary>
        /// Height console
        /// </summary>
        public float height { get; set; }

        /// <summary>
        /// Number of showing messages in console view.
        /// </summary>
        public int countMessages { get; set; }

        /// <summary>
        /// Is this console visible?
        /// </summary>
        public bool isVisible { get; set; }
        /// <summary>
        /// Is this console resizeable?
        /// </summary>
        public bool isResizeable { get; set; }
        /// <summary>
        /// Is this console in debug mode?
        /// </summary>
        public bool debugMode { get; set; }
        /// <summary>
        /// Can user write in this console?
        /// </summary>
        public bool canWrite{ get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ConsoleConfig () {
            nameLogFile = System.DateTime.Now.ToString ();
            nameLogFile = nameLogFile.Replace ( SLASH, UNDERSCORE );
            nameLogFile = nameLogFile.Replace ( COLON, UNDERSCORE );
            logContainer = new List<Message> ();
        }

        /// <summary>
        /// This is default initialization for ConsoleConfig
        /// </summary>
        public void DefaultInitialization () {
            x = 0;
            y = 0;
            width = 0.2f;
            height = 0.4f;
            countMessages = 50;
            isVisible = true;
            isResizeable = false;
            debugMode = true;
            canWrite = false;
        }
        
        /// <summary>
        /// This is container for console properties (positions and size)
        /// </summary>
        /// <returns>Rect with console properties</returns>
        public UnityEngine.Rect GetRect () {
            return new UnityEngine.Rect ( x * UnityEngine.Screen.width, 
                y * UnityEngine.Screen.height, 
                width * UnityEngine.Screen.width,
                height * UnityEngine.Screen.height );
        }

        /// <summary>
        /// Get messages list wit setting limit
        /// </summary>
        /// <returns>Messages list</returns>
        public List<Message> GetMessages () {
            List<Message> showingMessages = new List<Message> ();
            
            showingMessages = logContainer;

            if ( !debugMode ) {
                showingMessages = showingMessages.Where ( log => (log.debugMessage == false) ).ToList<Message> ();
            }

            int skip = ( countMessages == 0 ) ? 0 : showingMessages.Count - countMessages;
            skip = ( skip <= 0 ) ? 0 : skip;

            showingMessages = showingMessages.Skip ( skip ).ToList<Message> ();

            return showingMessages;
        }
    }
}
