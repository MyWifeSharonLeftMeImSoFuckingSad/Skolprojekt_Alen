using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_skolspel.lib
{
    public abstract class sprite {

        public Texture2D texture { get; set; }
        //public Texture2D textureRight { get; set; }
        public Vector2 position;
        public Vector2 position2;
        public virtual Color Color { get; set; } = Color.White;
        public int _speed { get; set;  } = 5;

        public virtual void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position, Color);
        }


        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
            }
        }
        public abstract void Update();

    }

}
