using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace Monogame_skolspel.lib
{
   
    public class bullet : sprite_bullet
    {
        Dictionary<string, Rectangle> SpritePos = new Dictionary<string, Rectangle>();
        int direction;
        int bullet_delay = 1000;
        int bullet_time;
      
        public bullet(Game game) : base(game)
        {
            texture = game.Content.Load<Texture2D>("bullet-tiny-sheet");
            SpritePos.Add("left", new Rectangle(262, 262, 21, 9));
            SpritePos.Add("right", new Rectangle(360, 263, 21, 9));
            SpritePos.Add("up", new Rectangle(425, 250, 11, 22));
            SpritePos.Add("down", new Rectangle(313, 250, 11, 22));

            position_b = new Vector2(300, 300);

            var ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.D))
            {
                bullRect = SpritePos["left"];
            }
            else if (ks.IsKeyDown(Keys.A))
            {
                bullRect = SpritePos["right"];
            }
            else if (ks.IsKeyDown(Keys.W))
            {
                bullRect = SpritePos["up"];
            }
            else if (ks.IsKeyDown(Keys.S))
            {
                bullRect = SpritePos["down"];
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
            else if (direction == 2)
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

            if (position_b.X <= 100) this.IsActive = false;
            if (position_b.X >= 1135) this.IsActive = false;
            if (position_b.Y <= 70) this.IsActive = false;
            if (position_b.Y >= 680) this.IsActive = false;
        


        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position_b, bullRect, Color);
        }
    }
}
