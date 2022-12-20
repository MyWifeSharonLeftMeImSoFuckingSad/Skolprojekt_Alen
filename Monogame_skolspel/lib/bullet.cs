using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_skolspel.lib
{
    public class bullet : sprite
    {
        public bullet(Texture2D _graphics)
        {
            position = new Vector2(0, 0);
            texture = _graphics;

        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
