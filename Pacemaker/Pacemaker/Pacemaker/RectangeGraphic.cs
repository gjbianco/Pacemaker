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
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class RectangeGraphic : Microsoft.Xna.Framework.DrawableGameComponent
    {
        Game Game;
        Texture2D Pixel;

        Rectangle Rectangle;
        public Color Color;
        public int BorderThinkness;

        public RectangeGraphic(int _Width, int _Height, Game _Game)
            : base(_Game)
        {
            Game = _Game;

            Rectangle.X = 0;
            Rectangle.Y = 0;
            Rectangle.Width = _Width;
            Rectangle.Height = _Height;

            Color = Color.White;
            BorderThinkness = 5;
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            Pixel = new Texture2D(Game.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            Pixel.SetData(new[] { Color.White });

        }

        public override void Initialize()
        {
            LoadContent();

            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            Game.SpriteBatch.Draw(Pixel, new Rectangle(Rectangle.X, Rectangle.Y, Rectangle.Width, BorderThinkness), Color);
            Game.SpriteBatch.Draw(Pixel, new Rectangle(Rectangle.X, Rectangle.Y, BorderThinkness, Rectangle.Height), Color);
            Game.SpriteBatch.Draw(Pixel, new Rectangle((Rectangle.X + Rectangle.Width - BorderThinkness), Rectangle.Y, BorderThinkness, Rectangle.Height), Color);
            Game.SpriteBatch.Draw(Pixel, new Rectangle(Rectangle.X, Rectangle.Y + Rectangle.Height - BorderThinkness, Rectangle.Width, BorderThinkness), Color);

            base.Draw(gameTime);
        }
    }
}
