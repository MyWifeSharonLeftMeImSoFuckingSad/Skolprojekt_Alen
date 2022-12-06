using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame_skolspel.lib;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Monogame_skolspel
{
   
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        

        private Texture2D background;
        //private Texture2D playerNormal;
        private Texture2D playerRight;
        //private Texture2D playerLeft;
        //private Texture2D playerBack;
        //private Texture2D currentTexture;
        sprite player;
        private Texture2D _player;
        sprite enemy;
        private Texture2D _enemy;
        bool isPLaying = false;
        private Rectangle Start;
        private Rectangle Start2;
        //private Rectangle mouseRect;
        private Texture2D Start_color;
        //private Texture2D Start_color2;
        //MouseState mouse;

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
        }

        protected override void Initialize()
        {

            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            background = Content.Load<Texture2D>("space_bg");
            Start = new Rectangle(10, 11, 35, 105);
            Start2 = new Rectangle(10, 11, 35, 105);
            Start_color = new Texture2D(GraphicsDevice, 1, 1);
            Start_color.SetData(new Color[] { Color.DarkGray });
            //Start_color2 = new Texture2D(GraphicsDevice, 1, 1);
            //Start_color2.SetData(new Color[] { Color.HotPink });

            //mouseRect = new Rectangle(mouse.X, mouse.Y, 1, 1);

            //currentTexture = playerNormal;
            //var ks = Keyboard.GetState();
            //if (ks.IsKeyDown(Keys.D))
            //{
            //    currentTexture = playerRight;
            //}

            _player = Content.Load<Texture2D>("playerSheet");
            _enemy = Content.Load<Texture2D>("slime_enemy");
           
            s = new player(_player);
            _sprites.Add(s);

            e = new enemy(_enemy);
            _sprites.Add(e);

           

            //int test = (int)s.position.X;

            //int s.x = 0 + player.width;

            //if (s.position.X >= 0)
            //{
            //    s.position.X += 100    ;
            //}
            //var ms = Mouse.GetState().Position;


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            _sprites.ForEach(e => e.Update());

            if (s.Rectangle.Intersects(e.Rectangle)){
                _spriteBatch.Begin();
                _spriteBatch.Draw(Start_color, Start, Color.White);
                _spriteBatch.End();
            }


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();


            if (s.Rectangle.Intersects(e.Rectangle))
            {
                
                _spriteBatch.Draw(Start_color, Start, Color.White);
              
            }
            //_spriteBatch.Draw(Start_color, Start, Color.White);
            //_spriteBatch.Draw(Start_color, mouseRect, Color.Black);
            _sprites.ForEach(e => e.Draw(_spriteBatch));
            //_spriteBatch.Draw(background, Vector2.Zero, Color.White);

            //_spriteBatch.Draw(p, p.position,Color.White);
            //_spriteBatch.Draw(playerCurrent, position, Color.White);

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