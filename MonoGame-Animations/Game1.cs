using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace MonoGame_Animations
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Random generator = new Random();


        Texture2D starShipTexture;
        Rectangle starShipRect;

        Texture2D tribbleGreyTexture;
        Rectangle tribbleGreyRect;
        Vector2 tribbleGreySpeed;

        Texture2D tribbleBrownTexture;
        Rectangle tribbleBrownRect;
        Vector2 tribbleBrownSpeed;

        Texture2D tribbleCreamTexture;
        Rectangle tribbleCreamRect;
        Vector2 tribbleCreamSpeed;

        Texture2D tribbleOrangeTexture;
        Rectangle tribbleOrangeRect;
        Vector2 tribbleOrangeSpeed;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {

            this.Window.Title = "Tribble's Fun Time";
            tribbleGreySpeed = new Vector2(10, 10);
            tribbleBrownSpeed = new Vector2(3, 0);
            tribbleCreamSpeed = new Vector2(0, 7);
            tribbleOrangeSpeed = new Vector2(10, 1);
            base.Initialize();
            tribbleGreyRect.X = generator.Next(0, _graphics.PreferredBackBufferWidth - tribbleGreyRect.Width);
            tribbleGreyRect.Y = generator.Next(0, _graphics.PreferredBackBufferHeight - tribbleGreyRect.Height);
            tribbleCreamRect.X = generator.Next(0, _graphics.PreferredBackBufferWidth - tribbleCreamRect.Width);
            tribbleCreamRect.Y = generator.Next(0, _graphics.PreferredBackBufferHeight - tribbleCreamRect.Height);
            tribbleOrangeRect.X = generator.Next(0, _graphics.PreferredBackBufferWidth - tribbleOrangeRect.Width);
            tribbleOrangeRect.Y = generator.Next(0, _graphics.PreferredBackBufferHeight - tribbleOrangeRect.Height);
            tribbleBrownRect.X = generator.Next(0, _graphics.PreferredBackBufferWidth - tribbleBrownRect.Width);
            tribbleBrownRect.Y = generator.Next(0, _graphics.PreferredBackBufferHeight - tribbleBrownRect.Height);


        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            starShipTexture = Content.Load<Texture2D>("inside");
            starShipRect = new Rectangle(0, 0, 800, 500);

            tribbleGreyTexture = Content.Load<Texture2D>("tribbleGrey");
            tribbleGreyRect = new Rectangle(0, 0, 100, 100);

            tribbleBrownTexture = Content.Load<Texture2D>("tribbleBrown");
            tribbleBrownRect = new Rectangle(0, 0, 100, 100);

            tribbleCreamTexture = Content.Load<Texture2D>("tribbleCream");
            tribbleCreamRect = new Rectangle(0, 0, 100, 100);

            tribbleOrangeTexture = Content.Load<Texture2D>("tribbleOrange");
            tribbleOrangeRect = new Rectangle(0, 0, 100, 100);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            tribbleGreyRect.X += (int)tribbleGreySpeed.X;
            tribbleGreyRect.Y += (int)tribbleGreySpeed.Y;

            tribbleBrownRect.X += (int)tribbleBrownSpeed.X;
            tribbleBrownRect.Y += (int)tribbleBrownSpeed.Y;

            tribbleCreamRect.X += (int)tribbleCreamSpeed.X;
            tribbleCreamRect.Y += (int)tribbleCreamSpeed.Y;

            tribbleOrangeRect.X += (int)tribbleOrangeSpeed.X;
            tribbleOrangeRect.Y += (int)tribbleOrangeSpeed.Y;

            if (tribbleGreyRect.Right > _graphics.PreferredBackBufferWidth || tribbleGreyRect.Left < 0)
                tribbleGreySpeed.X *= -1;
            if (tribbleGreyRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleGreyRect.Top < 0)
                tribbleGreySpeed.Y *= -1;

            if (tribbleBrownRect.Right > _graphics.PreferredBackBufferWidth || tribbleBrownRect.Left < 0)
                tribbleBrownSpeed.X *= -1;
            if (tribbleBrownRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleBrownRect.Top < 0)
                tribbleBrownSpeed.Y *= -1;

            if (tribbleCreamRect.Right > _graphics.PreferredBackBufferWidth || tribbleCreamRect.Left < 0)
                tribbleCreamSpeed.X *= -1;
            if (tribbleCreamRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleCreamRect.Top < 0)
                tribbleCreamSpeed.Y *= -1;

            if (tribbleOrangeRect.Right > _graphics.PreferredBackBufferWidth || tribbleOrangeRect.Left < 0)
                tribbleOrangeSpeed.X *= -1;
            if (tribbleOrangeRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleOrangeRect.Top < 0)
                tribbleOrangeSpeed.Y *= -1;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(starShipTexture, starShipRect, Color.White);

            _spriteBatch.Draw(tribbleGreyTexture, tribbleGreyRect, Color.White);
            _spriteBatch.Draw(tribbleBrownTexture, tribbleBrownRect, Color.White);
            _spriteBatch.Draw(tribbleOrangeTexture, tribbleOrangeRect, Color.White);
            _spriteBatch.Draw(tribbleCreamTexture, tribbleCreamRect, Color.White);


            _spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
