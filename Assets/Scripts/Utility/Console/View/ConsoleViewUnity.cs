using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Utility.Console {
    /// <summary>
    /// Specified console for Unity
    /// </summary>
    public class ConsoleViewUnity : ConsoleView {
        private const string INVALID_X_POSITION = "Sorry, but this position from x is too small or too high. Check it!";
        private const string INVALID_Y_POSITION = "Sorry, but this position from y is too small or too high. Check it!";

        private const string INVALID_WIDTH = "Sorry, but this width is too small or too high. Check it!";
        private const string INVALID_HEIGHT = "Sorry, but this height is too small or too high. Check it!";

        private const int MIN_VALUE = 0;
        private float heightFont = 0.03f;
        private int counterLogs = 0;

        private Rect myView;
        private Vector2 position;

        /// <summary>
        /// Initialize Console view (location and size)
        /// </summary>
        /// <param name="rect">Container with location and size</param>
        /// <returns></returns>
        /// <returns></returns>
        public override bool InitializeView ( Rect rect ) {
            bool result = true;

            try {
                CheckXPosition ( rect.x );
                CheckYPosition ( rect.y );
                CheckWidth ( rect.width, rect.x );
                CheckHeight ( rect.height, rect.y );

                float width = rect.width - 12;
                myView = rect;
                myView.width = width;
            } catch (Exceptions.InvalidPositionException e) {
                Message msg = new Message ( e.Message );
                Console.GetInstance ().AddLog ( msg );
            } finally {
                result = false;
            }

            return result;
        }

        private void CheckXPosition ( float x ) {
            if ( x < MIN_VALUE || x > Screen.width )
                throw new Exceptions.InvalidPositionException ( INVALID_X_POSITION );
        }
        private void CheckYPosition ( float y ) {
            if ( y < MIN_VALUE || y > Screen.height)
                throw new Exceptions.InvalidPositionException ( INVALID_Y_POSITION );
        }
        private void CheckWidth ( float width, float start ) {
            if ( width < MIN_VALUE || width > Screen.width || start + width > Screen.width )
                throw new Exceptions.InvalidPositionException ( INVALID_WIDTH );
        }
        private void CheckHeight ( float height, float start ) {
            if ( height < MIN_VALUE || height > Screen.height || start + height > Screen.height )
                throw new Exceptions.InvalidPositionException ( INVALID_HEIGHT );
        }

        /// <summary>
        /// Show all logs in console.
        /// </summary>
        /// <param name="messages">List of showing messages.</param>
        public override void ShowAllLogs ( List<Message> messages ) {
            try {
                GUISkinSetter ();

                GUILayout.BeginArea ( myView );

                if ( counterLogs != messages.Count ) {
                    position = new Vector2 ( position.x, counterLogs * myView.height );
                }
                position = GUILayout.BeginScrollView ( position );
                
                GUILayout.BeginVertical ();
                GUILayout.FlexibleSpace ();

                foreach ( Message message in messages ) {
                    GUILayout.BeginHorizontal ();
                    GUILayout.Button ( message.sender, GUILayout.Width (myView.width * 0.3f) );
                    GUILayout.Button ( message.content );
                    GUILayout.EndHorizontal ();
                }
                counterLogs = messages.Count;               
            } catch (NullReferenceException e) {
                Debug.Log ( e.Message );
            } finally {
                GUILayout.EndVertical ();
                GUILayout.EndScrollView ();
                GUILayout.EndArea ();
            }
        }
        private void GUISkinSetter () {
            GUI.skin.button.fontSize = ( int )( Screen.height * heightFont );
            GUI.skin.button.wordWrap = true;
        }
        
    }
}
