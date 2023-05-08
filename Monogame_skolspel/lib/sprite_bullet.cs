using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monogame_skolspel.lib
    {
        public abstract class sprite_bullet
        {
            public Game game { get; set; }

        public sprite_bullet(Game _game) { game = _game; }

      
        public Texture2D texture { get; set; }
        public Vector2 position_b;
        public Color Color { get; set; } = Color.White;
        public int _speed { get; set; } = 5;
        public bool IsActive { get; set; } = true;
        public bool ActiveFlash { get; set; } = false;
        public Rectangle bullRect;
        public Rectangle arrRect;
        public double step = 0;
        public double delay = 0;



        
        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)position_b.X, (int)position_b.Y, 21, 9);
            }
        }

        public Rectangle RectangleEnemy
        {
            get
            {
                return new Rectangle((int)position_b.X, (int)position_b.Y,38, 27);
            }
        }

        public Rectangle RectangleBB
        {
            get
            {
                return new Rectangle((int)position_b.X, (int)position_b.Y, 102, 94);
            }
        }

       

      

        public virtual void Draw(SpriteBatch spritebatch)
            {
                spritebatch.Draw(texture,position_b ,bullRect, Color);
            }

        public abstract void Update();

        }

    }


