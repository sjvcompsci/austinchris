using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game("Loading Image", 600, 480);
            // Set the background color of the game
            game.Color = Color.Black;

            // Create a Scene
            var scene = new Scene();

            // Add an Entity that will use Block.png as its Image
            
            scene.Add(new PlayerEntity(Game.Instance.HalfWidth, Game.Instance.HalfHeight));

            // Start the Game using the Scene with the Entities in it
            game.Start(scene);
        }
    }

    class PlayerEntity : Entity
    {

        /// <summary>
        /// The current move speed of the Entity.
        /// </summary>
        public float MoveSpeed;

        /// <summary>
        /// The move speed for when the Entity is moving slowly.
        /// </summary>
        public const float MoveSpeedSlow = 5;
        /// <summary>
        /// The move speed for when the Entity is moving quickly.
        /// </summary>
        public const float MoveSpeedFast = 10;

        public PlayerEntity(float x, float y) : base(x, y)
        {
            // Create my Moving Spaceship
            Image player = new Image("GalagaSpaceship.png");
            AddGraphic(player);
            // this seems to easy.

            // Assign the initial move speed to be the slow speed.
            MoveSpeed = MoveSpeedSlow;
        }
       
        public override void Update()
        {
            base.Update();
            // Every update check for input and react accordingly.

            // If the W key is down,
            if (Input.KeyDown(Key.W))
            {
                // Move up by the move speed.
                Y -= MoveSpeed;
            }
            // If the S key is down,
            if (Input.KeyDown(Key.S))
            {
                // Move down by the move speed.
                Y += MoveSpeed;
            }
            // If the A key is down,
            if (Input.KeyDown(Key.A))
            {
                // Move left by the move speed.
                X -= MoveSpeed;
            }
            // If the D key is down,
            if (Input.KeyDown(Key.D))
            {
                // Move right by the move speed.
                X += MoveSpeed;
            }

            // If the space bar key is pressed,
            if (Input.KeyPressed(Key.Space))
            {
                // If the Entity is currently slow,
                if (MoveSpeed == MoveSpeedSlow)
                {
                    // Set the Entity to fast,
                    MoveSpeed = MoveSpeedFast;
                    // And make its Color red.
                    Graphic.Color = Color.Red;
                }
                // If the Entity is currently fast,
                else {
                    // Set the Entity to slow,
                    MoveSpeed = MoveSpeedSlow;
                    // And make its Color white.
                    Graphic.Color = Color.White;
                }
            }
        }




    }
}



