using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pacemaker
{
    /// <summary>
    /// Draws a Debug mode Rectange
    /// </summary>
    class DebugRect : Microsoft.Xna.Framework.DrawableGameComponent
    {
        RectangeGraphic RectangeGraphic;

        public enum DebugType
        {
            View,       // Blue
            Physics,    // White
            Hostile,    // Red
            Trigger,    // Yellow
        }

        public DebugRect(Point _Center, int _Width, int _Height, DebugType _Type, Game _Game)
            : base(_Game)
        {
            Color Color = Color.HotPink;
            switch (_Type)
            {
                case DebugType.View:    { Color = Color.Blue;  } break;
                case DebugType.Physics: { Color = Color.White; } break;
                case DebugType.Hostile: { Color = Color.Red; } break;
                case DebugType.Trigger: { Color = Color.Yellow; } break;
            }

            RectangeGraphic = new RectangeGraphic(new Rectangle(_Center.X, _Center.Y, _Width, _Height), 3, Color, _Game);
        }

        public override void Initialize()
        {
            RectangeGraphic.Initialize();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }

        public void Move(Point _Point)
        {
            RectangeGraphic.Move(_Point);
        }

        public override void Update(GameTime _GameTime)
        {
            RectangeGraphic.Update(_GameTime);

            base.Update(_GameTime);
        }

        public override void Draw(GameTime _GameTime)
        {
            RectangeGraphic.Draw(_GameTime);

            base.Draw(_GameTime);
        }
    }
}
