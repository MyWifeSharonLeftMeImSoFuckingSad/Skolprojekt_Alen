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

        int step = 0;
        int delay = 0;
        
        //private Rectangle Health_red;
      
        //private Texture2D Health_texture;
        
        public player(Texture2D _graphics, GraphicsDevice graphics)
        {
            texture = _graphics;
            position = new Vector2(200, 300);
           
            //Health = 400;

            SpritePos.Add("normal0", new Rectangle(10, 11, 60, 50));
            SpritePos.Add("normal1", new Rectangle(75, 11, 60, 50));
            SpritePos.Add("normal2", new Rectangle(140, 11, 60, 50));
            SpritePos.Add("normal3", new Rectangle(200, 11, 60, 50));


            SpritePos.Add("normalUp0", new Rectangle(10, 200, 60, 305));
            SpritePos.Add("normalUp1", new Rectangle(75, 200, 60, 305));
            SpritePos.Add("normalUp2", new Rectangle(140, 200, 60, 305));
            SpritePos.Add("normalUp3", new Rectangle(200, 200, 60, 305));
                
                
            SpritePos.Add("normalLeft0", new Rectangle(10, 77, 60, 50));
            SpritePos.Add("normalLeft1", new Rectangle(75, 77, 60, 50));
            SpritePos.Add("normalLeft2", new Rectangle(140, 77, 60, 50));
            SpritePos.Add("normalLeft3", new Rectangle(200, 77, 60, 50));


            SpritePos.Add("normalRight0", new Rectangle(10, 140, 60, 50));
            SpritePos.Add("normalRight1", new Rectangle(75, 140, 60, 50));
            SpritePos.Add("normalRight2", new Rectangle(140, 140, 60, 50));
            SpritePos.Add("normalRight3", new Rectangle(200, 140, 63, 50));

            //Health_red = new Rectangle(50, 11, 400, 25);
            //Health_green = new Rectangle(50, 11, Health, 25);
            
        }

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, 60, 50);
            }
        }

        public override void Update()
        {

           

            //Movement
            var ks = Keyboard.GetState();

            if(step == 3)
            {
                step = 0;
            }

            if (delay < 0)
            {
                delay = 7;
            }

            if (ks.IsKeyDown(Keys.A))
            {
                position.X -= _speed;

                if (delay == 0)
                {
                   
                    step += 1;
                }
                delay--;

            }           
            
            if (ks.IsKeyDown(Keys.D))
            {
                position.X += _speed;

                if (delay == 0)
                {

                    step += 1;
                }
                delay--;

            }

            if (ks.IsKeyDown(Keys.W))
            {
                position.Y -= _speed;
              
                if (delay == 0)
                {

                    step += 1;
                }
                delay--;
            }

            if (ks.IsKeyDown(Keys.S))
            {
                position.Y += _speed;

                if (delay == 0)
                {

                    step += 1;
                }
                delay--;
            }

            if(position.X <= 100)
            {
                position.X = 100;
            }

            if (position.X >= 1180 - 45)
            {
                position.X = 1180 - 45;
            }

            if (position.Y >= 700 - 45)
            {
                position.Y = 700 - 50;
            }

            if (position.Y <= 100)
            {
                position.Y = 100;
            }

            //screen-jail
            //if()

            //if (SpritePos.Intersect(SpritePosEnemy))
            //{

            //}
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            //spritebatch.Begin();
            var ks = Keyboard.GetState();

            //if (ks.IsKeyDown(Keys.W))
            //{
            //    spritebatch.Draw(texture, position, SpritePos["normalUp" + step], Color.Blue);
            //}
            //else
            //{
            //    spritebatch.Draw(texture, position, SpritePos["normal0" + step], Color.White);
            //}

            //spritebatch.Draw(Health_texture, Health_red, Color.Red);

            if (ks.IsKeyDown(Keys.W))
            {
                spritebatch.Draw(texture, position, SpritePos["normalUp" + step], Color.White);
            }
            else if (ks.IsKeyDown(Keys.A))
            {
                spritebatch.Draw(texture, position, SpritePos["normalLeft" + step], Color.White);
            }
            else if (ks.IsKeyDown(Keys.D))
            {
                spritebatch.Draw(texture, position, SpritePos["normalRight" + step], Color.White);
            }
            else
            {
                spritebatch.Draw(texture, position, SpritePos["normal" + step], Color.White);
            }




            //spritebatch.Draw(texture, position, SpritePos["normal0"], Color.White);
            //spritebatch.Draw(texture, position2, SpritePos["normal1"], Color.White);

            //spritebatch.End();
        }
    }












}
