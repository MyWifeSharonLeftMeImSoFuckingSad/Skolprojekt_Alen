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
    public class player : sprite
    {

        public player(Texture2D _graphics)
        {
            texture = _graphics;
         
            position = new Vector2(200, 300);
            
        }

        public override void Update()
        {
            var ks = Keyboard.GetState();

            if (ks.IsKeyDown(Keys.A))
            {
                position.X -= _speed;
            }           
            
            if (ks.IsKeyDown(Keys.D))
            {
                position.X += _speed;
            }

            if (ks.IsKeyDown(Keys.W))
            {
                position.Y -= _speed;
            }

            if (ks.IsKeyDown(Keys.S))
            {
                position.Y += _speed;
            }




        }

        public override void Draw(SpriteBatch spritebatch)
        {
            //spritebatch.Begin();

            spritebatch.Draw(texture, position, Color.White);

            //spritebatch.End();
        }
    }

    

   








}
