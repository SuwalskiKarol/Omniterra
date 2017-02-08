using UnityEngine;

namespace Scripts.Utility.Console {
    /// <summary>
    /// Console manager
    /// </summary>
    public class ConsoleManager : MonoBehaviour {
        private IConsole myConsole;
        /// <summary>
        /// Horizontal position (in percentage). Range: &lt; 0; 1 &gt;
        /// </summary>
        [Header ( "Console position" )]
        [Tooltip ( "Horizontal position (in percentage)" )]
        [Range ( 0, 1 )]
        public float x;
        /// <summary>
        /// Vertical position (in percentage). Range: &lt; 0; 1 &gt;
        /// </summary>
        [Tooltip ("Vertical position (in percentage) ")]
        [Range (0,1)]
        public float y;
        /// <summary>
        /// Console width (in percentage). Range: &lt; 0; 1 &gt;
        /// </summary>
        [Header ("Console size")]
        [Range (0, 1)]
        [Tooltip ("Console width (in percentage)")]
        public float width;
        /// <summary>
        /// Console height (in percentage). Range: &lt; 0; 1 &gt;
        /// </summary>
        [Range (0, 1)]
        [Tooltip ("Console height (in percentage)")]
        public float height;
        /// <summary>
        /// Limit of showing messages. Must be greater than 0. If 0, then console don't have limit.
        /// </summary>
        [Header ("Message options")]
        [Tooltip ( "Max number of logs (0 - no limits)")]
        public int messageLimit;
        /// <summary>
        /// This able/enable input in console for user.
        /// </summary>
        [Tooltip ("Is eneable input for user?")]
        public bool canWrite;
        /// <summary>
        /// Set consoles visible
        /// </summary>
        [Header ("Other options")]
        [Tooltip ("Console will to be visible?")]
        public bool isVisible;
        /// <summary>
        /// Gives possibility user to change console size (may be deleted)
        /// </summary>
        [Tooltip ( "User can resize console? (MAY BE DELETE!)" )]
        public bool isResizeable;
        /// <summary>
        /// Set visible debug message in console
        /// </summary>
        [Tooltip ("Show in console debug messages? (Options for testers)")]
        public bool debugMode; 
    
        /// <summary>
        /// Initialize console
        /// </summary>
        public void Awake () {
            myConsole = Console.GetInstance ();
            myConsole.SetVisible ( true );
        }

        /// <summary>
        /// Show console
        /// </summary>
        public void OnGUI () {
            myConsole.Show ();
        }

        /// <summary>
        /// This is for level designer. Now level designer can change calues in Unity Inspector
        /// </summary>
        public void Update () {
            myConsole.SetCanWrite ( canWrite );
            myConsole.SetDebugMode ( debugMode );
            myConsole.SetHeight ( height );
            myConsole.SetIsResizeable ( isResizeable );
            myConsole.SetMessageLimit ( messageLimit );
            myConsole.SetVisible ( isVisible );
            myConsole.SetWidth ( width );
            myConsole.SetXPosition ( x );
            myConsole.SetYPosition ( y );
            myConsole.ReinitializeView ();
        } 
    }
}
