using System;

namespace Scripts.Utility.Console {
    /// <summary>
    /// Helping struct, to containts consoles messages
    /// </summary>
    public struct Message {
        private const string DEBUG = "DEBUG:";
        /// <summary>
        /// Time creation this message.
        /// </summary>
        public string time { get; private set; }
        /// <summary>
        /// Sender name.
        /// </summary>
        public string sender { get; private set; }
        /// <summary>
        /// Content message
        /// </summary>
        public string content { get; private set; }
        /// <summary>
        /// Flag for debug message
        /// </summary>
        public bool debugMessage { get; private set; }

        /// <summary>
        /// Constructor for normal messages
        /// </summary>
        /// <param name="sender">Sender name</param>
        /// <param name="content">New message content</param>
        public Message (string sender, string content) {
            this.time = DateTime.Now.ToString ();
            this.sender = sender;
            this.content = content;
            this.debugMessage = false;
        }

        /// <summary>
        /// Constructor for debug messages
        /// </summary>
        /// <param name="content">New message content</param>
        public Message (string content) {
            this.time = DateTime.Now.ToString ();
            this.sender = DEBUG;
            this.content = content;
            this.debugMessage = true;
        }
    }
}
