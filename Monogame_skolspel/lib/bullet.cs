using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_skolspel.lib
{
    public class bullet : sprite_bullet
    {
        
        public bullet(Game game) : base(game)
        {
            position_b = new Vector2(0, 0);
            texture = game.Content.Load<Texture2D>("bullet");
            _speed = 0;

        }

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)position_b.X, (int)position_b.Y, 60, 50);
            }
        }

        public override void Update()
        {
            

        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position_b, Color);
          
        }
    }
}
