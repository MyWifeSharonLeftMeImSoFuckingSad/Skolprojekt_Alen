using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

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

        int Speed = 5;
        private bool isCurrentTexture = false;
        private Vector2 position = new Vector2(200, 300);



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
            playerNormal = Content.Load<Texture2D>("normalPlayer");
            playerRight = Content.Load<Texture2D>("rightPlayer");
            playerLeft = Content.Load<Texture2D>("leftplayer");
            playerBack = Content.Load<Texture2D>("backPlayer");

            
            

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

           
    

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            _spriteBatch.Draw(background, Vector2.Zero, Color.White);
            //_spriteBatch.Draw(playerCurrent, position, Color.White);

            var kb = Keyboard.GetState();

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

            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}