using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_skolspel.lib
{
    public class bulletTest : sprite_bullet
    {
        Dictionary<string, Rectangle> SpritePos = new Dictionary<string, Rectangle>();
        int direction;
        int bullet_delay = 1000;
        int bullet_time;

        public bulletTest(Game game) : base(game)
        {
            //SpritePos.Add("normal", new Rectangle((int)position_b.X, (int)position_b.Y, 250, 500));


            position_b = new Vector2(300, 300);
            texture = game.Content.Load<Texture2D>("bullet-tiny-sheet-color");
            //texture = _graphics;

            SpritePos.Add("normal", new Rectangle(262, 262, 21, 9));

            //bullRect = SpritePos["normal"];

            //var ks = Keyboard.GetState();
            //if (ks.IsKeyDown(Keys.D))
            //{
            //    texture = game.Content.Load<Texture2D>("bullet-tiny");
            //    //bullRect = SpritePos["normal"];
            //}
            //else if (ks.IsKeyDown(Keys.A))
            //{
            //    texture = game.Content.Load<Texture2D>("bullet-tiny-left");
            //}
            //else if (ks.IsKeyDown(Keys.W))
            //{
            //    texture = game.Content.Load<Texture2D>("bullet-tiny-up");
            //}
            //else if (ks.IsKeyDown(Keys.S))
            //{
            //    texture = game.Content.Load<Texture2D>("bullet-tiny-down");
            //}

            //bullRect = new Rectangle((int)position_b.X, (int)position_b.Y, texture.Height, texture.Width);

        }

        public override void Update()
        {
            //bullRect = new Rectangle((int)position_b.X, (int)position_b.Y, 300, 3);
            //bullRect = new Rectangle(0,0,500,500);

            bullet_time -= 10;
            if (bullet_time < 0)
            {
                bullet_time = 0;
            }

            var ks = Keyboard.GetState();

            if (ks.IsKeyDown(Keys.D))
            {
                bullRect = SpritePos["normal"];
            }

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

            //if (direction == 1)
            //{
            //    position_b.X += 15;
            //}
            //else if(direction == 2)
            //{
            //    position_b.X -= 15;
            //}
            //else if (direction == 3)
            //{
            //    position_b.Y -= 15;
            //}
            //else if (direction == 4)
            //{
            //    position_b.Y += 15;
            //}

            if (position_b.X <= -200) this.IsActive = false;
            if (position_b.X >= 935) this.IsActive = false;
            if (position_b.Y <= -200) this.IsActive = false;


        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position_b, bullRect, Color);/*spritebatch.Draw(texture, position_b, Color);*/

        }
    }
}
