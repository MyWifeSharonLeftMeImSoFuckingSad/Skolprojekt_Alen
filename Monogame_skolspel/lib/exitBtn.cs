using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Microsoft.Xna.Framework.Rectangle;
using Color = Microsoft.Xna.Framework.Color;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_skolspel.lib
{
   


    public class exitBtn
    {
        Texture2D _exitText;
        Rectangle _exitRect;

        public exitBtn (Texture2D exitText, Rectangle exitRect)
        {
            _exitRect= exitRect;
            _exitText = exitText;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_exitText, _exitRect, Color.White);
        }
    }

}
