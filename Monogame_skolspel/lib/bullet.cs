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
        int direction;
        int bullet_delay = 1000;
        int bullet_time;
        public bullet(Game game) : base(game)
        {
            position_b = new Vector2(0, 0);
            _speed = 0;
            var ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.D))
            {
                texture = game.Content.Load<Texture2D>("bullet-tiny");
            }
            else if (ks.IsKeyDown(Keys.A))
            {
                texture = game.Content.Load<Texture2D>("bullet-tiny-left");
            }
            else if (ks.IsKeyDown(Keys.W))
            {
                texture = game.Content.Load<Texture2D>("bullet-tiny-up");
            }
            else if (ks.IsKeyDown(Keys.S))
            {
                texture = game.Content.Load<Texture2D>("bullet-tiny-down");
            }

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
            bullet_time -= 10;
            if (bullet_time < 0)
            {
                bullet_time = 0;
            }

            var ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.D) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
            {
                bullet_time = bullet_delay;
                direction = 1;          
            }
            else if (ks.IsKeyDown(Keys.A) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
            {
                bullet_time = bullet_delay;
                direction = 2;
            }
            else if (ks.IsKeyDown(Keys.W) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
            {
                bullet_time = bullet_delay;
                direction = 3;
            }
            else if (ks.IsKeyDown(Keys.S) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
            {
                bullet_time = bullet_delay;
                direction = 4;
            }

            if (direction == 1)
            {
                position_b.X += 15;
            }
            else if(direction == 2)
            {
                position_b.X -= 15;
            }
            else if (direction == 3)
            {
                position_b.Y -= 15;
            }
            else if (direction == 4)
            {
                position_b.Y += 15;
            }

           

            if (position_b.X <= -200) this.IsActive = false;
            if (position_b.X >= 935) this.IsActive = false;
            if (position_b.Y <= -200) this.IsActive = false;

        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position_b, Color.White);
          
        }
    }
}
