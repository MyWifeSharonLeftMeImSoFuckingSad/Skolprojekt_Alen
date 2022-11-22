using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame_skolspel.lib;
using System.Collections.Generic;
using System.Numerics;

namespace Monogame_skolspel
{
   
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        

        private Texture2D background;
        private Texture2D playerNormal;
        private Texture2D playerRight;
        private Texture2D playerLeft;
        private Texture2D playerBack;
        private Texture2D playerCurrent;
        //private sprite player;

        int Speed = 5;
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
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            background = Content.Load<Texture2D>("space_bg");
            playerNormal = Content.Load<Texture2D>("normalPLayer");
            playerLeft = Content.Load<Texture2D>("leftplayer");
            playerRight = Content.Load<Texture2D>("rightPlayer");


            /* playerNormal = Content.Load<Texture2D>("normalPlayer");
             playerRight = Content.Load<Texture2D>("rightPlayer");
             playerLeft = Content.Load<Texture2D>("leftplayer");
             playerBack = Content.Load<Texture2D>("backPlayer");*/

            //player a = new player(playerLeft);
            //_sprites.Add(a);


            //player s = new player(playerNormal);
            //_sprites.Add(s);

            player d = new player(playerRight);
            _sprites.Add(d);

            player n = new player(playerNormal);
            _sprites.Add(n);






            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            _sprites.ForEach(e => e.Update());


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
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