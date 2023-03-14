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
    public class backpack 
    {
        Dictionary<string, Rectangle> PosBB = new Dictionary<string, Rectangle>();

        MouseState mouseState = Mouse.GetState();
        Rectangle _backRect;
        Texture2D _backText;
        Vector2 _backPos;
        public backpack(Texture2D texture, Rectangle rectangle)
        {
            _backText = texture;
            //position = new Vector2(1151, 0);
            _backRect = rectangle;

            //PosBB.Add("normal", new Rectangle(1145, 0, 1280, 800));
            //PosBB.Add("normal", new Rectangle(0, 0, 1280, 800));
        }

        public  void Update()
        {

            



        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_backText, _backRect, Color.White);
        }



    }
}
