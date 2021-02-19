using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PhysicsExampleA
{
    /// <summary>
    /// A game demonstrating linear dynamics
    /// </summary>
    public class PhysicsExampleAGame : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private LanderSprite lander;

        /// <summary>
        /// Constructs the game
        /// </summary>
        public PhysicsExampleAGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        /// <summary>
        /// Initializes the game
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            lander = new LanderSprite();

            base.Initialize();
        }

        /// <summary>
        /// Loads content for the game
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            lander.LoadContent(Content);
        }

        /// <summary>
        /// Updates the game
        /// </summary>
        /// <param name="gameTime">An object representing game time</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            lander.Update(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// Draws the game
        /// </summary>
        /// <param name="gameTime">An object representing game time</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            lander.Draw(gameTime, spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
