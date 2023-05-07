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
        public arrow(Game1 game) : base(game)
        {

        }

        public override void Update()
        {
            
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position_b, /*arrowRect,*/ Color);
        }
    }
}
