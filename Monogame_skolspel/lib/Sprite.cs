using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_skolspel.lib
{
    internal class Sprite
    {
        public abstract class SpriteO

        {

            public Game game { get; set; }

            protected Texture2D Texture { get; set; }

            public Vector2 Position;

            public virtual Color Color { get; set; } = Color.White;

            public float Speed { get; set; }

            public bool IsActive { get; set; } = true;



            public SpriteO(Game _game) { game = _game; }



            //För kollisions koll

            public Rectangle Rectangle

            {

                get

                {

                    return new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height);

                }

            }

            public virtual void Update(GameTime gameTime)

            {

            }



            public virtual void Draw(SpriteBatch spriteBatch)
            {

                spriteBatch.Draw(Texture, Position, Color);

            }

        }
    }
}
