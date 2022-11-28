using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_skolspel.lib
{
    public class player : sprite
    {

        Dictionary<string, Rectangle> SpritePos = new Dictionary<string, Rectangle>();

        
        public player(Texture2D _graphics)
        {
            texture = _graphics;
            position = new Vector2(200, 300);
            position2 = new Vector2(300, 300);

            SpritePos.Add("normal", new Rectangle(10, 11, 60, 50));
            SpritePos.Add("normal2", new Rectangle(70, 11, 60, 50));
            SpritePos.Add("normal3", new Rectangle(120, 11, 60, 50));
            SpritePos.Add("normal4", new Rectangle(180, 11, 60, 50));

            SpritePos.Add("normalUp", new Rectangle(10, 200, 60, 305));
            SpritePos.Add("normalUp2", new Rectangle(70, 200, 60, 305));
            SpritePos.Add("normalUp3", new Rectangle(120, 200, 60, 305));
            SpritePos.Add("normalUp4", new Rectangle(180, 200, 60, 305));
                
                
            SpritePos.Add("normalLeft", new Rectangle(10, 77, 60, 50));
            SpritePos.Add("normalLeft2", new Rectangle(70, 77, 60, 50));
            SpritePos.Add("normalLeft3", new Rectangle(120, 77, 60, 50));
            SpritePos.Add("normalLeft4", new Rectangle(180, 77, 60, 50));


            SpritePos.Add("normalRight", new Rectangle(10, 140, 60, 50));
            SpritePos.Add("normalRight2", new Rectangle(70, 140, 60, 50));
            SpritePos.Add("normalRight3", new Rectangle(120, 140, 60, 50));
            SpritePos.Add("normalRight4", new Rectangle(180, 140, 63, 50));
        }

        

        public override void Update()
        {
            //Movement
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
            var ks = Keyboard.GetState();

            if (ks.IsKeyDown(Keys.W))
            {
                spritebatch.Draw(texture, position, SpritePos["normalUp"], Color.White);
            }
            else if (ks.IsKeyDown(Keys.A))
            {
                spritebatch.Draw(texture, position, SpritePos["normalLeft"], Color.White);
            }
            else if (ks.IsKeyDown(Keys.D))
            {
                spritebatch.Draw(texture, position, SpritePos["normalRight"], Color.White);
            }
            else
            {
                spritebatch.Draw(texture, position, SpritePos["normal"], Color.White);
            }



            //spritebatch.Draw(texture, position, SpritePos["normalRight"], Color.White);
            //spritebatch.Draw(texture, position2, SpritePos["normalRight4"], Color.White);

            //spritebatch.End();
        }
    }

    

   








}
