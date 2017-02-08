using System;
namespace Scripts.Utility.Exceptions {
    /// <summary>
    /// Invalid positions exceptions. Use this, if You wanna.
    /// </summary>
    public class InvalidPositionException : Exception {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public InvalidPositionException () : base() {
        }

        /// <summary>
        /// Constructor with one param.
        /// </summary>
        /// <param name="message">Message to user with own errors text.</param>
        public InvalidPositionException ( string message )
        : base(message)
        {
        }

        /// <summary>
        /// Constructor with two param.
        /// </summary>
        /// <param name="message">Message to user with own errors text.</param>
        /// <param name="inner">Inner exception.</param>
        public InvalidPositionException ( string message, Exception inner )
        : base(message, inner)
        {
        }
    }
}
