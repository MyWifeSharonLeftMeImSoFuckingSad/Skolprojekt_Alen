using DocumentFormat.OpenXml.Drawing;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace Monogame_skolspel.lib
{
    public class enemy : sprite_bullet
    {

        Dictionary<string, Rectangle> SpritePosEnemy = new Dictionary<string, Rectangle>();
       
        Random rnd = new Random();

        int Flash;
        
        public enemy(Game game) : base(game)
        {
            texture = texture = game.Content.Load<Texture2D>("slime_enemy");
            //position_b = new Vector2(-40, rnd.Next(1, 301));
            position_b = new Vector2(0, 100);
            //origin = new Vector2(texture.Width / 2, texture.Height / 2);
            IsActive = true;
            Color = Color.White;


            SpritePosEnemy.Add("normal0", new Rectangle(215, 40, 60, 40));
            SpritePosEnemy.Add("normal1", new Rectangle(315, 40, 55, 40));
            SpritePosEnemy.Add("normal2", new Rectangle(415, 40, 55, 40));
            SpritePosEnemy.Add("normal3", new Rectangle(515, 40, 55, 40));

        }

        //public Rectangle Rectangle
        //{
        //    get
        //    {
        //        return new Rectangle((int)position_b.X, (int)position_b.Y, 60, 40);
        //    }
        //}

        public override void Update()
        {
            //Color = Color.White; 

            if(ActiveFlash == true)
            {
                Flash++;

                if (Flash == 11)
                {
                    Color = Color.White;

                }

                if (Flash == 12)
                {
                    IsActive = false;
                    
                }
                
                if(Flash == 12)
                {
                    ActiveFlash = false;
                    Flash = 0;
                }
                position_b.X -= 5;
            }
           






            //position.X += 10;
            //if (position.X == 100)
            //{
            //    position.X += 10;
            //}
            //position.X += 10;


        }

        public override void Draw(SpriteBatch spritebatch)
        {
          
            spritebatch.Draw(texture, position_b, SpritePosEnemy["normal" + step] , Color);
            
        }
    }
}
