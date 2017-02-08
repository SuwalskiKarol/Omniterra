using System.Xml.Serialization;

namespace Scripts.Utility.Keys {
    /// <summary>
    /// Names of keys, that perform actions.
    /// </summary>
    public enum KeyName {
        /// <summary>
        /// Back to previous menu (in Menu) or Open Menu (in Game). Additionaly Cancel any action.
        /// </summary>
        [XmlEnum ( Name = "Key_to_Back" )]
        BACK_KEY,
        /// <summary>
        /// Move camera to up.
        /// </summary>
        [XmlEnum ( Name = "Camera_Up" )]
        CAMERA_UP,
        /// <summary>
        /// Move camera to down.
        /// </summary>
        [XmlEnum ( Name = "Camera_Down" )]
        CAMERA_DOWN,
        /// <summary>
        /// Move camera to left.
        /// </summary>
        [XmlEnum ( Name = "Camera_Left" )]
        CAMERA_LEFT,
        /// <summary>
        /// Move camera to right.
        /// </summary>
        [XmlEnum ( Name = "Camera_Right" )]
        CAMERA_RIGHT,
        /// <summary>
        /// Go to place, where User click and attack all enemy on own track.
        /// </summary>
        [XmlEnum ( Name = "Go_and_Attack" )]
        GO_AND_ATTACK,
        /// <summary>
        /// Use special attack selected unit.
        /// </summary>
        [XmlEnum ( Name = "Use_special_attack" )]
        USE_SPECIAL_ATTACK,
        /// <summary>
        /// Go to patrol.
        /// </summary>
        [XmlEnum ( Name = "Patrol" )]
        PATROL,
        /// <summary>
        /// Set pause in game (only single!).
        /// </summary>
        [XmlEnum ( Name = "Pause" )]
        PAUSE,
        /// <summary>
        /// Switch HUD state in game beetwen ON/OFF.
        /// </summary>
        [XmlEnum ( Name = "Switch_HUD_state" )]
        SWITCH_HUD_STATE,
        /// <summary>
        /// Go to latest in-game alert.
        /// </summary>
        [XmlEnum ( Name = "Go_to_alert" )]
        GO_TO_ALERT,
        /// <summary>
        /// Key 1.
        /// </summary>
        ONE,
        /// <summary>
        /// Key 2.
        /// </summary>
        TWO,
        /// <summary>
        /// Key 3.
        /// </summary>
        THREE,
        /// <summary>
        /// Key 4.
        /// </summary>
        FOUR,
        /// <summary>
        /// Key 5.
        /// </summary>
        FIVE,
        /// <summary>
        /// Key 6.
        /// </summary>
        SIX,
        /// <summary>
        /// Key 7.
        /// </summary>
        SEVEN,
        /// <summary>
        /// Key 8.
        /// </summary>
        EIGHT,
        /// <summary>
        /// Key 9.
        /// </summary>
        NINE,
        /// <summary>
        /// Key 0.
        /// </summary>
        ZERO,
        /// <summary>
        /// Key F1.
        /// </summary>
        F1,
        /// <summary>
        /// Key F2.
        /// </summary>
        F2,
        /// <summary>
        /// Key F3.
        /// </summary>
        F3,
        /// <summary>
        /// Key F4.
        /// </summary>
        F4,
        /// <summary>
        /// Key F5.
        /// </summary>
        F5,
        /// <summary>
        /// Key F6.
        /// </summary>
        F6,
        /// <summary>
        /// Key F7.
        /// </summary>
        F7,
        /// <summary>
        /// Key F8.
        /// </summary>
        F8,
        /// <summary>
        /// Key F9.
        /// </summary>
        F9,
        /// <summary>
        /// Key F10.
        /// </summary>
        F10,
        /// <summary>
        /// Key F11.
        /// </summary>
        F11,
        /// <summary>
        /// Key F12.
        /// </summary>
        F12
    }
}
