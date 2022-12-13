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
        private Rectangle Start;
        private Rectangle Start2;
        private Texture2D Start_color;
        private Vector2 position = new Vector2(10, 20);
        private int count = 0;
        private SpriteFont counter;

        player s;
        enemy e;

        //int Speed = 5;
        //private Vector2 position = new Vector2(200, 300);


        List<sprite> _sprites { get; set; } = new List<sprite>();

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

            Start = new Rectangle(10, 11, 35, 105);
            Start2 = new Rectangle(10, 11, 35, 105);
            Start_color = new Texture2D(GraphicsDevice, 1, 1);
            Start_color.SetData(new Color[] { Color.DarkGray });
      
            _player = Content.Load<Texture2D>("playerSheet");
            _enemy = Content.Load<Texture2D>("slime_enemy");
           
            s = new player(_player);
            _sprites.Add(s);

            e = new enemy(_enemy);
            _sprites.Add(e);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            _sprites.ForEach(e => e.Update());

            if (s.Rectangle.Intersects(e.Rectangle)){
                count++;
                
            }
           //((int)gameTime.TotalGameTime.TotalSeconds).ToString()

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(background_1, Vector2.Zero, Color.White);
            _spriteBatch.Draw(background_2, Vector2.Zero, Color.White);
            _spriteBatch.DrawString(counter, count.ToString(),
              position, Color.Black);
            //_spriteBatch.Draw(Start_color, Start, Color.White);
            //_spriteBatch.Draw(Start_color, mouseRect, Color.Black);
            _sprites.ForEach(e => e.Draw(_spriteBatch));
            

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