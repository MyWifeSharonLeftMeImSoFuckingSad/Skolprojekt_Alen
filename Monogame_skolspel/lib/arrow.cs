using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_skolspel.lib
{

    public class arrow : sprite_bullet
    {
        Dictionary<string, Rectangle> SpritePos = new Dictionary<string, Rectangle>();
        List<sprite_bullet> _arrowList { get; set; } = new List<sprite_bullet>();
        int direction;
        int arrow_delay = 1000;
        int arrow_time;

        public arrow(Game1 game) : base(game)
        {
            texture = game.Content.Load<Texture2D>("arrow-tiny-sheet");
            SpritePos.Add("right", new Rectangle(260, 270, 45, 13));
            SpritePos.Add("down", new Rectangle(305, 270, 20, 45));
            SpritePos.Add("left", new Rectangle(337, 270, 45, 13));
            SpritePos.Add("up", new Rectangle(415, 270, 20, 45));

            position_b = new Vector2(300, 300);

            var ks = Keyboard.GetState();

            if (ks.IsKeyDown(Keys.D))
            {
                arrRect = SpritePos["right"];
            }
            else if (ks.IsKeyDown(Keys.S))
            { 
                arrRect = SpritePos["down"];
            } 
            else if(ks.IsKeyDown(Keys.A))
            {
                arrRect = SpritePos["left"];            
            } 
            else if (ks.IsKeyDown(Keys.W))
            {
                arrRect = SpritePos["up"];
            }

        }

        public override void Update()
        {
            arrow_time -= 10;
            if(arrow_time < 0 ) 
            {
                arrow_time = 0;
            }

            var ks = Keyboard.GetState();
           
                if (ks.IsKeyDown(Keys.D) && ks.IsKeyDown(Keys.Space) && arrow_time == 0)
            {
                arrow_time = arrow_delay;
                direction = 1;
            }
            else if(ks.IsKeyDown(Keys.S) && ks.IsKeyDown(Keys.Space) && arrow_time == 0)
            {
                arrow_time = arrow_delay;
                direction = 2;
            }
            else if(ks.IsKeyDown(Keys.A) && ks.IsKeyDown(Keys.Space) && arrow_time == 0)
            {
                arrow_time = arrow_delay;
                direction = 3;
            }
            else if(ks.IsKeyDown(Keys.W) && ks.IsKeyDown(Keys.Space) && arrow_time == 0) 
            {
                arrow_time = arrow_delay;
                direction = 4;
            }

           
                if (direction == 1)
                {
                    position_b.X += 15;
                }
                else if (direction == 2)
                {
                    position_b.Y += 15;
                }
                else if (direction == 3)
                {
                    position_b.X -= 15;
                }
                else if (direction == 4)
                {
                    position_b.Y -= 15;
                }

            if (position_b.X <= 100) this.IsActive = false;
            if (position_b.X >= 1135) this.IsActive = false;
            if (position_b.Y <= 70) this.IsActive = false;
            if (position_b.Y >= 680) this.IsActive = false;
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position_b, arrRect, Color) ;
        }
    }
}
