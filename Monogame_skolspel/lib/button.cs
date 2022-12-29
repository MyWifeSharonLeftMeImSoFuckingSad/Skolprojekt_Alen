using DocumentFormat.OpenXml.Drawing;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Rectangle = Microsoft.Xna.Framework.Rectangle;
using Color = Microsoft.Xna.Framework.Color;

namespace Monogame_skolspel.lib
{
  public class Button
    {
        private Rectangle bounds;
        private Texture2D texture;
        private SpriteFont font;
        private string text;

        public Button(Texture2D _texture, Rectangle _bounds, SpriteFont _font, string _text)
        {
            texture = _texture;
            bounds = _bounds;
            font = _font;
            text = _text;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, bounds, Color.White);
            spriteBatch.DrawString(font, text, new Vector2(bounds.X + 60, bounds.Y + 17), Color.White);
        }

        public void Update(GameTime gameTime)
        {
            
        }

    }
}
