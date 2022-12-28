using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame_skolspel.lib;
using System;
using System.Collections.Generic;
using System.Numerics;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace Monogame_skolspel
{
   
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        

        private Texture2D background_1;
        private Texture2D background_2;

        sprite player;
        private Texture2D _player;
        sprite enemy;
        private Texture2D _enemy;
        bool isPLaying = false;
        sprite_bullet bullet;
        private Texture2D _bullet;

        sprite_bullet bulletTest;
        private Texture2D _bulletTest;

        private Rectangle Start;
        private Rectangle Start2;
        private Texture2D Start_color;
        private Vector2 position = new Vector2(10, 20);

        private int count = 0;
        private SpriteFont counter;

        private Rectangle life_red;
        private Rectangle life_green;
        private Texture2D Healht_green;
        int Health = 400;

        player s;
        enemy e;
        //bullet bullet;
        //bulletTest b;

        int bullet_delay = 1000;
        int bullet_time;


        //int Speed = 5;
        //private Vector2 position = new Vector2(200, 300);


        List<sprite> _sprites { get; set; } = new List<sprite>();
        List<sprite_bullet> _sprites2 { get; set; } = new List<sprite_bullet>();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.IsFullScreen = true;
        }

        protected override void Initialize()
        {

            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.ApplyChanges();
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            background_1 = Content.Load<Texture2D>("background");
            background_2 = Content.Load<Texture2D>("bg_2_final");
            counter = Content.Load<SpriteFont>("font");

            //Start = new Rectangle(10, 11, 35, 105);
            //Start2 = new Rectangle(10, 11, 35, 105);
            Start_color = new Texture2D(GraphicsDevice, 1, 1);
            Start_color.SetData(new Color[] { Color.DarkGray });

            life_red = new Rectangle(50, 11, 400, 25);
            Healht_green = Content.Load<Texture2D>("health_green");

            _player = Content.Load<Texture2D>("playerSheet");
            _enemy = Content.Load<Texture2D>("slime_enemy");
            //_bullet = Content.Load<Texture2D>("bullet-tiny");

            _bulletTest = Content.Load<Texture2D>("bullet-tiny-sheet-color");
           
            //skapar spelare
            s = new player(_player, GraphicsDevice);
            _sprites.Add(s);

            e = new enemy(_enemy);
            _sprites.Add(e);

            //b = new bullet(this);
            //_sprites2.Add(b);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //skapar en loop/timer för skoten så man kan ha delay 
            bullet_time -= gameTime.ElapsedGameTime.Milliseconds;
            if (bullet_time < 0)
            {
                bullet_time = 0;
            }
            
            //uppdaterar varje objekt i _sprites listan
            _sprites.ForEach(e => e.Update());
            
            //om spelarens rectangle nuddar en fiendes rectangle så sker detta
            life_green = new Rectangle(50, 11, Health, 25);
            if (s.Rectangle.Intersects(e.Rectangle)){
                //count++;
                Health -= 1;
            }

            //if (s.Rectangle.Intersects(b.Rectangle))
            //{
            //    count++;
            //    Health -= 1;
            //}


            var ks = Keyboard.GetState();

            //om man håller ner D och space så skapas ett skott, bullet_time måste också vara 0
            //för att detta ska ske. Efter skottet blir bullet_time = 1000 och börjar räkna ner
            //för att man ska kunna skjuta igen (alltså en delay på skotten)

            if (ks.IsKeyDown(Keys.D) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
            {
                bullet_time = bullet_delay;
                _sprites2.Add(new bullet(this)
                {

                    position_b = new Vector2(s.position.X + 20, s.position.Y + 20)

                });

            }
            else if (ks.IsKeyDown(Keys.A) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
            {
                bullet_time = bullet_delay;
                _sprites2.Add(new bullet(this)
                {

                    position_b = new Vector2(s.position.X /*- 240*/, s.position.Y /*- 245*/)

                });
            }
            else if (ks.IsKeyDown(Keys.W) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
            {
                bullet_time = bullet_delay;
                _sprites2.Add(new bullet(this)
                {

                    position_b = new Vector2(s.position.X /*- 213*/, s.position.Y /*- 275*/)

                });
            }
            else if (ks.IsKeyDown(Keys.S) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
            {
                bullet_time = bullet_delay;
                _sprites2.Add(new bullet(this)
                {

                    position_b = new Vector2(s.position.X /*- 213*/, s.position.Y /*- 255*/)

                });
            }



            //kod för att varje skott ska åka åt ett visst håll.
            foreach (sprite_bullet bullet in _sprites2)
            {
                ks = Keyboard.GetState();
                if (ks.IsKeyDown(Keys.D))
                {
                    if (bullet.Rectangle.Intersects(s.Rectangle))
                    {
                        count++;
                    }
                }
                else if (ks.IsKeyDown(Keys.S))
                {
                    if (bullet.RectangleDown.Intersects(s.Rectangle))
                    {
                        count++;
                    }
                }


                bullet.Update();
            }

            //uppdatera varje objekt i lisan _sprites2
            //_sprites2.ForEach(e => e.Update());
            _sprites2.RemoveAll(e => !e.IsActive);


            base.Update(gameTime);
        }

     

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(background_1, Vector2.Zero, Color.White);
            _spriteBatch.Draw(background_2, Vector2.Zero, Color.White);
            _spriteBatch.DrawString(counter, count.ToString(),
             position, Color.WhiteSmoke);
            //_spriteBatch.Draw(Start_color, Start, Color.White);
            //_spriteBatch.Draw(Start_color, mouseRect, Color.Black);
            _sprites.ForEach(e => e.Draw(_spriteBatch));
            _sprites2.ForEach(e => e.Draw(_spriteBatch));
            _spriteBatch.Draw(Start_color, life_red, Color.Red);
            _spriteBatch.Draw(Healht_green, life_green, Color.White);

            /*var kb = Keyboard.GetState();

            if (kb.IsKeyDown(Keys.W))
            {
                position.Y -= Speed;
                //playerCurrent = playerBack;
                _spriteBatch.Draw(playerBack, position, Color.White);


            }
            else
            {
                //playerCurrent = playerNormal;
                _spriteBatch.Draw(playerNormal, position, Color.White);

            };

            if (kb.IsKeyDown(Keys.S))
            {
                position.Y += Speed;
                _spriteBatch.Draw(playerNormal, position, Color.White);
            }

            

            if (kb.IsKeyDown(Keys.A))
            {
                position.X -= Speed;
                _spriteBatch.Draw(playerLeft, position, Color.White);
            }

            if (kb.IsKeyDown(Keys.D))
            {
                position.X += Speed;
                _spriteBatch.Draw(playerRight, position, Color.White);
            }
            */
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}