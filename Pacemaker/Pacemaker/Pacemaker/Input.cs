using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pacemaker
{
    class Input : Microsoft.Xna.Framework.GameComponent
    {
        private KeyboardState PreviousKeyboardState;

        public override void Initialize()
        {
            base.Initialize();

            PreviousKeyboardState = Keyboard.GetState();
        }

        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            base.Update(gameTime);

            // Get Current State
            KeyboardState CurrentKeyboardState = Keyboard.GetState();

            // Caps Lock / Enter
            // Left Shift / Right Shift
            // Left Ctrl / Right Ctrl 
            // Left Alt / Right Alt
            // Left Arrow / Right Arrow
            // TODO:: Left Mouse Button / Right Mouse Button

            if ((CurrentKeyboardState.IsKeyDown(Keys.CapsLock) && PreviousKeyboardState.IsKeyUp(Keys.CapsLock))
                || (CurrentKeyboardState.IsKeyDown(Keys.LeftShift) && PreviousKeyboardState.IsKeyUp(Keys.LeftShift))
                || (CurrentKeyboardState.IsKeyDown(Keys.LeftControl) && PreviousKeyboardState.IsKeyUp(Keys.LeftControl))
                || (CurrentKeyboardState.IsKeyDown(Keys.LeftAlt) && PreviousKeyboardState.IsKeyUp(Keys.LeftAlt))
                || (CurrentKeyboardState.IsKeyDown(Keys.Left) && PreviousKeyboardState.IsKeyUp(Keys.Left))
                )
            {
                // TODO:: Event Left Pressed
            }

            if ((CurrentKeyboardState.IsKeyDown(Keys.Enter) && PreviousKeyboardState.IsKeyUp(Keys.Enter))
                || (CurrentKeyboardState.IsKeyDown(Keys.RightShift) && PreviousKeyboardState.IsKeyUp(Keys.RightShift))
                || (CurrentKeyboardState.IsKeyDown(Keys.RightControl) && PreviousKeyboardState.IsKeyUp(Keys.RightControl))
                || (CurrentKeyboardState.IsKeyDown(Keys.RightAlt) && PreviousKeyboardState.IsKeyUp(Keys.RightAlt))
                || (CurrentKeyboardState.IsKeyDown(Keys.Right) && PreviousKeyboardState.IsKeyUp(Keys.Right)))
            {
                // TODO:: Event Right Pressed
            }

            if ((CurrentKeyboardState.IsKeyUp(Keys.CapsLock) && PreviousKeyboardState.IsKeyDown(Keys.CapsLock))
                || (CurrentKeyboardState.IsKeyUp(Keys.LeftShift) && PreviousKeyboardState.IsKeyDown(Keys.LeftShift))
                || (CurrentKeyboardState.IsKeyUp(Keys.LeftControl) && PreviousKeyboardState.IsKeyDown(Keys.LeftControl))
                || (CurrentKeyboardState.IsKeyUp(Keys.LeftAlt) && PreviousKeyboardState.IsKeyDown(Keys.LeftAlt))
                || (CurrentKeyboardState.IsKeyUp(Keys.Left) && PreviousKeyboardState.IsKeyDown(Keys.Left)))
            {
                // TODO:: Event Left Release
            }

            if ((CurrentKeyboardState.IsKeyUp(Keys.Enter) && PreviousKeyboardState.IsKeyDown(Keys.Enter))
                || (CurrentKeyboardState.IsKeyUp(Keys.RightShift) && PreviousKeyboardState.IsKeyDown(Keys.RightShift))
                || (CurrentKeyboardState.IsKeyUp(Keys.RightControl) && PreviousKeyboardState.IsKeyDown(Keys.RightControl))
                || (CurrentKeyboardState.IsKeyUp(Keys.RightAlt) && PreviousKeyboardState.IsKeyDown(Keys.RightAlt))
                || (CurrentKeyboardState.IsKeyUp(Keys.Right) && PreviousKeyboardState.IsKeyDown(Keys.Right)))
            {
                // TODO:: Event Right Release
            }

            // Set Previous State
            PreviousKeyboardState = CurrentKeyboardState;
        }
    }
}
