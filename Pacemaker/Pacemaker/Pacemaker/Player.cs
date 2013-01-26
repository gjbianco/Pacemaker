using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Pacemaker
{
    public class Player : Microsoft.Xna.Framework.DrawableGameComponent
    {
        Point Position;
        DebugRect View;
        DebugRect Physics;

        public Player(Game game)
            : base(game)
        {
            Position = new Point();
            View = new DebugRect(Position, 50, 50, DebugRect.DebugType.View, game);
            Physics = new DebugRect(Position, 30, 40, DebugRect.DebugType.Physics, game);
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            View.Move(Position);
            Physics.Move(Position);

            base.Update(gameTime);
        }
    }
}
