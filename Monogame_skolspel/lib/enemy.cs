using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_skolspel.lib
{
    public class enemy : sprite
    {

        Dictionary<string, Rectangle> SpritePosEnemy = new Dictionary<string, Rectangle>();
        public enemy(Texture2D _graphics)
        {
            texture = _graphics;
            position = new Vector2(300, 300);

            SpritePosEnemy.Add("normal0", new Rectangle(215, 40, 60, 40));

        }

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, 60, 40);
            }
        }

        public override void Update()
        {
            
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position, SpritePosEnemy["normal0"] , Color.White);
        }
    }
}
