using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Presentation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame_skolspel.lib;
using System;
using System.Collections.Generic;
using System.Numerics;
using Vector2 = Microsoft.Xna.Framework.Vector2;
using Microsoft.Xna.Framework.Media;
using DocumentFormat.OpenXml.Office2013.Word.Drawing;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System.Text.Json.Nodes;

namespace Monogame_skolspel
{
    public enum GameState
    {
        MainMenu,
        Highscore,
        InGame,
        PauseGame
    }
   
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private GameState ActiveState = GameState.MainMenu;

        private Texture2D background_1;
        private Texture2D background_2;

        sprite_bullet player;
        private Texture2D _player;
        //sprite enemy;
        private Texture2D _enemy;

        sprite_bullet enemy;

        private Texture2D scoreBG;
        private SpriteFont scoreOne;
        private SpriteFont scoreTwo;
        private SpriteFont scoreThree;
        
        private DateTime DateAdded;

        private new highscore test;
        

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
        int Health = 1310;
        double Health_pos_x = -3;

        private Texture2D buttText;
        private Texture2D buttTextHov;
        private Texture2D currentButt;
        private Rectangle buttRect;
        private Rectangle scoreRect;
        private SpriteFont buttFont;
        private Button button;
        private Button highscore;
        private Texture2D currentTextScore;
        private Texture2D UI_bar;

        private backpack backpack;
        private Texture2D backText;
        private Texture2D backText_hover;
        private Rectangle backRect;
        private Texture2D backcurrentText;

        private bool backpackUI = false;

        private Texture2D backBG;
        private exitBtn exitBtn;
        private Texture2D exit_main;
        private Texture2D exit_hover;
        private Texture2D exitcurrent_text;
        private Rectangle exitRect;
        


        private Rectangle mouseRect;

        int direction = 0;

        private Texture2D main_menu;

        player s;
        enemy e;
        backpack g;
        

        int bullet_delay = 1000;
        int bullet_time;

        int enemy_delay = 1000;
        int enemyTime;

        Random rnd = new Random();

        int Rando;

        int Bomb_delay = 300;
        int BombTime;

        int Flash;


        double step = 0;
        double delay = 0;

        List<sprite_bullet> _sprites { get; set; } = new List<sprite_bullet>();
        List<sprite_bullet> _enemyList { get; set; } = new List<sprite_bullet>();
        List<sprite_bullet> _bulletList { get; set; } = new List<sprite_bullet>();

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
            main_menu = Content.Load<Texture2D>("main-menu-bg");
            counter = Content.Load<SpriteFont>("font");

            //backpack = Content.Load<Texture2D>("backpack-ss");
            //backpack_hover = Content.Load<Texture2D>("backpack-ss");

            //Start = new Rectangle(10, 11, 35, 105);
            //Start2 = new Rectangle(10, 11, 35, 105);
            Start_color = new Texture2D(GraphicsDevice, 1, 1);
            Start_color.SetData(new Color[] { Color.DarkGray });

            UI_bar = Content.Load<Texture2D>("UI-healthbar-scorebar");

            life_red = new Rectangle(50, 11, 400, 25);
            Healht_green = Content.Load<Texture2D>("healthbar");

            _player = Content.Load<Texture2D>("playerSheet");
            _enemy = Content.Load<Texture2D>("slime_enemy");
            //_bullet = Content.Load<Texture2D>("bullet-tiny");

            _bulletTest = Content.Load<Texture2D>("bullet-tiny-sheet-color");

            buttText = Content.Load<Texture2D>("button-normal");
            buttTextHov = Content.Load<Texture2D>("button-hover");
            buttFont = Content.Load<SpriteFont>("font");
            buttRect = new Rectangle(_graphics.PreferredBackBufferWidth / 2 - 100, _graphics.PreferredBackBufferHeight / 2, 200, 50);
            scoreRect = new Rectangle(_graphics.PreferredBackBufferWidth / 2 - 100, _graphics.PreferredBackBufferHeight / 2 + 100, 200, 50);

            backText = Content.Load<Texture2D>("backpack-main");
            backText_hover = Content.Load<Texture2D>("backpack-hover");
            backRect = new Rectangle(1151, 20, 100, 96);
            backcurrentText = Content.Load<Texture2D>("backpack-main");

            backBG = Content.Load<Texture2D>("backpack-bg");
            scoreBG = Content.Load<Texture2D>("scoreBG");
            scoreOne = Content.Load<SpriteFont>("font");
            scoreTwo = Content.Load<SpriteFont>("font");
            scoreThree = Content.Load<SpriteFont>("font");

            exitcurrent_text = Content.Load<Texture2D>("exit-main");
            exit_main = Content.Load<Texture2D>("exit-main");
            exit_hover = Content.Load<Texture2D>("exit-hover");
            exitRect = new Rectangle(1050, 20, 100, 96);

            MouseState mouseState = Mouse.GetState();
            mouseRect = new Rectangle(mouseState.X, mouseState.Y, 100, 100);


            //skapar spelare
            s = new player(this);
            _sprites.Add(s);

            //e = new enemy(this);
            //_enemyList.Add(e);

           

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (ActiveState == GameState.MainMenu)
            {
                // kod som skapar en knapp
                button = new Button(currentButt, buttRect, buttFont, "Start Game");

                highscore = new Button(currentTextScore, scoreRect, buttFont, "Highscore");

                //kod för att först kontrollera musens "stadie" vilket sedan används för att se om
                //musen position är inne i knappens area för att byta texture på knappen. Samt en kod för när
                //trycker på knappen så att spelet börjar.
                MouseState mouseState = Mouse.GetState();
                //Start button
                if (buttRect.Contains(mouseState.Position))
                {
                    currentButt = buttTextHov;
                }
                else
                {
                    currentButt = buttText;
                }

                if (backRect.Contains(mouseState.Position))
                {
                    backpackUI = true;
                }

                if (buttRect.Contains(mouseState.Position) & mouseState.LeftButton == ButtonState.Pressed)
                {
                    ActiveState = GameState.InGame;
                }

                if (scoreRect.Contains(mouseState.Position))
                {
                    currentTextScore = buttTextHov;
                }
                else
                {
                    currentTextScore = buttText;
                }

                //Score button
                if (scoreRect.Contains(mouseState.Position))
                {
                    currentTextScore = buttTextHov;
                }
                else
                {
                    currentTextScore = buttText;
                }

                if(scoreRect.Contains(mouseState.Position) && mouseState.LeftButton == ButtonState.Pressed)
                {
                    ActiveState = GameState.Highscore;
                }

                button.Update(gameTime);
            }

            //if (ActiveState == GameState.InGame) 
            //{ 

            if(ActiveState == GameState.Highscore)
            {
                backpack = new backpack(backcurrentText, backRect);


                exitBtn = new exitBtn(exitcurrent_text, exitRect);
                exitBtn.Update();

                MouseState mouseState = Mouse.GetState();
                mouseRect = new Rectangle(mouseState.X, mouseState.Y, 100, 100);

                if (exitRect.Contains(mouseState.Position))
                {
                    exitcurrent_text = exit_hover;
                }
                else
                {
                    exitcurrent_text = exit_main;
                }

                if(exitRect.Contains(mouseState.Position) && mouseState.LeftButton == ButtonState.Pressed)
                {
                    ActiveState = GameState.MainMenu;
                }
            }

            if (ActiveState == GameState.InGame)
            {
                backpack = new backpack(backcurrentText, backRect);

                exitBtn = new exitBtn(exitcurrent_text, exitRect);
                exitBtn.Update();

                MouseState mouseState = Mouse.GetState();
                mouseRect = new Rectangle(mouseState.X, mouseState.Y, 100, 100);

                if (backRect.Contains(mouseState.Position))
                {
                    backcurrentText = backText_hover;
                    
                }
                else
                {
                    backcurrentText = backText;
                }
                
                if(backRect.Contains(mouseState.Position) && mouseState.LeftButton == ButtonState.Pressed)
                {
                    backpackUI = true;
                    ActiveState = GameState.PauseGame;
                }

                exitBtn.Update();

                if (exitRect.Contains(mouseState.Position))
                {
                    exitcurrent_text = exit_hover;
                    
                }
                else
                {
                    exitcurrent_text = exit_main;
                }
    
                if(exitRect.Contains(mouseState.Position) && mouseState.LeftButton == ButtonState.Pressed)
                {
                    backpackUI = false;
                }

                //if (backRect.Contains(mouseState))
                //{

                //}

                var ks = Keyboard.GetState();
                if (ks.IsKeyDown(Keys.D) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
                {
                    direction = 1;
                }

                BombTime -= gameTime.ElapsedGameTime.Milliseconds;
                if (BombTime < 0)
                {
                    BombTime = 0;
                }

                enemyTime -= gameTime.ElapsedGameTime.Milliseconds;
                if (enemyTime < 0)
                {
                    enemyTime = 0;
                }


                step += gameTime.ElapsedGameTime.Milliseconds;
                if(step > 4000)
                {
                    _enemyList.Add(new enemy(this));
                    step = 0;
                    _enemyList.ForEach(e => e.Update());
                }


                foreach (enemy e in _enemyList)
                {
                    if (s.position_b.X > e.position_b.X)
                    {
                        e.position_b.X += 2;
                    }
                    else if (s.position_b.X < e.position_b.X)
                    {
                        e.position_b.X -= 2;
                    }

                    if (s.position_b.Y > e.position_b.Y)
                    {
                        e.position_b.Y += 2;
                    }
                    else if (s.position_b.Y < e.position_b.Y)
                    {
                        e.position_b.Y -= 2;
                    }
                    


                    if (e.step == 3)
                    {
                        e.step = 0;
                    }

                    if (e.delay > 15)
                    {
                        e.delay = 0;
                    }

                    if (e.delay == 0)
                    {

                        e.step += 1;
                    }
                    e.delay++;

                    if (s.Rectangle.Intersects(e.RectangleEnemy))
                    {
                        Health -= 10;
                        Health_pos_x += 1;
                    }

                   

                    foreach (bullet b in _bulletList)
                    {

                        if (b.Rectangle.Intersects(e.RectangleEnemy))
                        {
                            count++;
                            e.Color = Color.Red;

                            //Flash++;

                            //if(Flash == 10)
                            //{
                            //    e.IsActive = false;
                            //    Flash = 0;
                            //}


                           
                           
                            b.IsActive = false;
                            

                        }

                        //if (hitTime == 0)
                        //{
                        //    e.IsActive = false;
                        //}

                        if (b.Rectangle.Intersects(e.RectangleEnemy))
                        {
                            e.ActiveFlash = true;
                        }

                    }

                }
                _enemyList.ForEach(e => e.Update());
                _enemyList.RemoveAll(e => !e.IsActive);

                if (Health == 0)
                {
                    ActiveState = GameState.MainMenu;
                    test.Points = count ;

                }
             
                if (BombTime == 0)
                {
                    int x = rnd.Next(0, GraphicsDevice.Viewport.Width - 60);
                    //Rando = rnd.Next(1, 2);

                    BombTime = Bomb_delay;
                 


                    if (/*Rando == 1 &&*/ BombTime == 0)
                    {
                        //BombTime = Bomb_delay;
                        //_bulletList.Add(new enemy(this

                        //}
                        //    //else if(Rando == 2)
                        //    //{
                        //    //    _sprites.Add(new enemy(_enemy)
                        //    //    {
                        //    //        position = new Vector2(500, rnd.Next(1, 301))
                        //    //    });
                        //    //}
                        //    //else if(Rando == 3)
                        //    //{
                        //    //    _sprites.Add(new enemy(_enemy)
                        //    //    {
                        //    //        position = new Vector2(0, rnd.Next(1, 301))
                        //    //    });
                        //    //}
                        //    //else if(Rando == 4)
                        //    //{
                        //    //    _sprites.Add(new enemy(_enemy)
                        //    //    {
                        //    //        position = new Vector2(800, rnd.Next(1, 301))
                        //    //    });
                        //    //}

                        //    //}

                        //if (s.position.X > e.position_b.X)
                        //{
                        //    e.position_b.X += 1;
                        //}
                        //else if (s.position.X < e.position_b.X)
                        //{
                        //    e.position_b.X -= 1;
                        //}

                        //if (s.position.Y > e.position_b.Y)
                        //{
                        //    e.position_b.Y += 1;
                        //}
                        //else if (s.position.Y < e.position_b.Y)
                        //{
                        //    e.position_b.Y -= 1;
                        //}



                        //if (s.position.X > enemy.position_b.X)
                        //{
                        //    enemy.position_b.X += 100;
                        //}
                        //else if (s.position.X < enemy.position_b.X)
                        //{
                        //    enemy.position_b.X -= 100;
                        //}

                        //if (s.position.Y > enemy.position_b.Y)
                        //{
                        //    enemy.position_b.Y += 100;
                        //}
                        //else if (s.position.Y < enemy.position_b.Y)
                        //{
                        //    enemy.position_b.Y -= 100;
                        //}


                        //_bulletList.ForEach(e => e.Update());




                    }

                }

             

                //skapar en loop/timer för skoten så man kan ha delay 
                bullet_time -= gameTime.ElapsedGameTime.Milliseconds;
                if (bullet_time < 0)
                {
                    bullet_time = 0;
                }

                //uppdaterar varje objekt i _sprites listan
                _sprites.ForEach(e => e.Update());

                //om spelarens rectangle nuddar en fiendes rectangle så sker detta
                life_green = new Rectangle(0, 0, Health, 25);
                //if (s.Rectangle.Intersects(e.Rectangle))
                //{
                //    //count++;
                //    Health -= 1;
                //}

                //if (s.Rectangle.Intersects(b.Rectangle))
                //{
                //    count++;
                //    Health -= 1;
                //}


                //var ks = Keyboard.GetState();

                //om man håller ner D och space så skapas ett skott, bullet_time måste också vara 0
                //för att detta ska ske. Efter skottet blir bullet_time = 1000 och börjar räkna ner
                //för att man ska kunna skjuta igen (alltså en delay på skotten)

                if (ks.IsKeyDown(Keys.D) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
                {
                    bullet_time = bullet_delay;
                    _bulletList.Add(new bullet(this)
                    {

                        position_b = new Vector2(s.position_b.X + 20, s.position_b.Y + 20)

                    });

                }
                else if (ks.IsKeyDown(Keys.A) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
                {
                    bullet_time = bullet_delay;
                    _bulletList.Add(new bullet(this)
                    {

                        position_b = new Vector2(s.position_b.X  - 20 /*- 240*/, s.position_b.Y + 20 /*- 245*/)

                    });
                }
                else if (ks.IsKeyDown(Keys.W) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
                {
                    bullet_time = bullet_delay;
                    _bulletList.Add(new bullet(this)
                    {

                        position_b = new Vector2(s.position_b.X + 15 /*- 213*/, s.position_b.Y /*- 275*/)

                    });
                }
                else if (ks.IsKeyDown(Keys.S) && ks.IsKeyDown(Keys.Space) && bullet_time == 0)
                {
                    bullet_time = bullet_delay;
                    _bulletList.Add(new bullet(this)
                    {

                        position_b = new Vector2(s.position_b.X + 15 /*- 213*/, s.position_b.Y /*- 255*/)

                    });
                }

              

                //foreach (enemy e in _enemyList)
                //{
                //    if (enemy.RectangleEnemy.Intersects(bullet.Rectangle))
                //    {
                //        count++;
                //    }
                //}

                //if(direction == 1)
                //{
                //    foreach (sprite_bullet enemy in _enemyList)
                //    {
                //        if (enemy.RectangleEnemy.Intersects(bullet.Rectangle))
                //        {
                //            count++;
                //        }
                //    }
                //}

                //kod för att varje skott ska åka åt ett visst håll.


                //uppdatera varje objekt i lisan _bulletList
                _bulletList.ForEach(e => e.Update());
                _bulletList.RemoveAll(e => !e.IsActive);
                _enemyList.RemoveAll(e => !e.IsActive);




                base.Update(gameTime);


            }


            if (ActiveState == GameState.PauseGame)
            {
                backpack = new backpack(backcurrentText, backRect);
                backpack.Update();

                exitBtn = new exitBtn(exitcurrent_text, exitRect);
                exitBtn.Update();

                MouseState mouseState = Mouse.GetState();
                mouseRect = new Rectangle(mouseState.X, mouseState.Y, 100, 100);

                //backpackUI = true;

                if (exitRect.Contains(mouseState.Position))
                {
                    exitcurrent_text = exit_hover;
                }
                else
                {
                    exitcurrent_text = exit_main;
                }

                if (exitRect.Contains(mouseState.Position) && mouseState.LeftButton == ButtonState.Pressed)
                {
                    //backpackUI = false;
                    ActiveState = GameState.InGame;
                }
            }
        }

     

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            if(ActiveState == GameState.InGame)
            {
                _spriteBatch.Draw(background_1, Vector2.Zero, Color.White);
                _spriteBatch.Draw(background_2, Vector2.Zero, Color.White);
                _sprites.ForEach(e => e.Draw(_spriteBatch));
                _bulletList.ForEach(e => e.Draw(_spriteBatch));
                _enemyList.ForEach(e => e.Draw(_spriteBatch));
                backpack.Draw(_spriteBatch);
                //_spriteBatch.Draw(Start_color, life_red, Color.Red);
                _spriteBatch.Draw(UI_bar, new Vector2(0, 0), Color.White);
                _spriteBatch.Draw(Healht_green, new Rectangle((int)Health_pos_x, -5, Health, 900), Color.White);
                _spriteBatch.DrawString(counter, count.ToString(), new Vector2(155, 85), Color.WhiteSmoke);

                if (backpackUI == true)
                {
                    _spriteBatch.Draw(backBG, new Vector2(0, - 50), Color.White);
                    exitBtn.Draw(_spriteBatch);
                    _spriteBatch.DrawString(scoreOne, count.ToString(), new Vector2(0, 0), Color.White);
                }
                
            }
            else if (ActiveState == GameState.MainMenu)
            {
                _spriteBatch.Draw(main_menu, Vector2.Zero, Color.White);
                button.Draw(_spriteBatch);
                highscore.Draw(_spriteBatch);
            }
            else if(ActiveState == GameState.PauseGame)
            {
                _spriteBatch.Draw(background_1, Vector2.Zero, Color.White);
                _spriteBatch.Draw(background_2, Vector2.Zero, Color.White);
                _sprites.ForEach(e => e.Draw(_spriteBatch));
                _bulletList.ForEach(e => e.Draw(_spriteBatch));
                _enemyList.ForEach(e => e.Draw(_spriteBatch));
                backpack.Draw(_spriteBatch);
                //_spriteBatch.Draw(Start_color, life_red, Color.Red);
                _spriteBatch.Draw(UI_bar, new Vector2(0, 0), Color.White);
                _spriteBatch.Draw(Healht_green, new Rectangle((int)Health_pos_x, -5, Health, 900), Color.White);
                _spriteBatch.DrawString(counter, count.ToString(), new Vector2(155, 85), Color.WhiteSmoke);

                if (backpackUI == true)
                {
                    _spriteBatch.Draw(backBG, new Vector2(0, -50), Color.White);
                    exitBtn.Draw(_spriteBatch);
                }
            }
            else if(ActiveState == GameState.Highscore)
            {
                _spriteBatch.Draw(scoreBG, Vector2.Zero, Color.White);
                exitBtn.Draw(_spriteBatch);
                _spriteBatch.DrawString(scoreOne, test.Points.ToString(), new Vector2(100, 100), Color.WhiteSmoke);
            }

           
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}