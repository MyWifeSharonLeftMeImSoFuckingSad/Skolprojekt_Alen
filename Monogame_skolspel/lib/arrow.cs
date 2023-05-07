using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
        int direction;
        int arrow_delay;
        int arrow_time;

        public arrow(Game1 game) : base(game)
        {
            texture = game.Content.Load<Texture2D>("arrow-tiny-sheet");
            SpritePos.Add("right", new Rectangle(260, 270, 45, 13));
            SpritePos.Add("down", new Rectangle(305, 270, 20, 45));
            SpritePos.Add("left", new Rectangle(337, 270, 45, 13));
            SpritePos.Add("up", new Rectangle(415, 270, 20, 45));

            position_b = new Vector2(300, 300);
        }

        public override void Update()
        {
            
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position_b, SpritePos["up"], Color);
        }
    }
}
