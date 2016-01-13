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
            var game = new Game("Galaga Remix", 600, 480);
            // Set the background color of the game
            game.Color = Color.Black;

            // Create a Scene
            var scene = new Scene();

            // Add an Entity that will use Block.png as its Image
            
            scene.Add(new PlayerEntity(Game.Instance.HalfWidth, Game.Instance.HalfHeight));

            for (int i = 0; i < 50; i++)
            {
                // Check out the Rand class for random generation!
                var x = Rand.Float(game.Width);
                var y = Rand.Float(game.Height);
                // Add the Collectable at the randomized position.
                
            }

            // Start the Game using the Scene with the Entities in it
            game.Start(scene);
        }
    }

    enum Tags
    {
        PlayerEntity,
        Collectable
    }

    class PlayerEntity : Entity
    {

        /// <summary>
        /// The current move speed of the Entity.
        /// </summary>
        public float MoveSpeed;
        public static int Score = 0;
        /// <summary>
        /// The move speed for when the Entity is moving slowly.
        /// </summary>
        public const float MoveSpeedSlow = 5;
        /// <summary>
        /// The move speed for when the Entity is moving quickly.
        /// </summary>
        public const float MoveSpeedFast = 10;

      
      

            BoxCollider collider = new BoxCollider(30, 30, Tags.PlayerEntity);
            public PlayerEntity(float x, float y) : base(x, y)
        {
            // Create my Moving Spaceship
            Image player = new Image("GalagaSpaceship.png");
            AddGraphic(player);
            BoxCollider collider = new BoxCollider(30, 30, Tags.PlayerEntity);
            // Center the origin of the image.
            player.CenterOrigin();

            // Add the collider. Must be added or it cant check for collision!
            AddCollider(collider);
            // Center the origin of the collider so it aligns with the image.
            collider.CenterOrigin();
            MoveSpeed = MoveSpeedSlow;
        }


        // Assign the initial move speed to be the slow speed.

        
       
        public override void Update()
        {
            base.Update();
            // Every update check for input and react accordingly.
            X = Util.Clamp(X, 0, Game.Width - 30);
            Y = Util.Clamp(Y, 0, Game.Height - 30);
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
                
            }
        }

        class Collectable : Entity
        {
            Image Luke = new Image("Luke's Small Head.jpg");
            // Create a CircleCollider and tag it with the Collectable tag.
            CircleCollider collider = new CircleCollider(10, Tags.Collectable);
            public Collectable (float x, float y): base(x, y)
            {
                // Add the image for rendering.
                AddGraphic(Luke);
                // Center the origin of the image.
                Luke.CenterOrigin();
                // Create a CircleCollider and tag it with the Collectable tag.
                CircleCollider collider = new CircleCollider(10, Tags.Collectable);

            }
            public override void Update()
            {
                base.Update();
                if (collider. Overlap(X, Y, Tags.PlayerEntity))
                {
                    RemoveSelf();
                    PlayerEntity.Score++;
                }
            }
            public override void Render()
            {
                base.Render();
            }
        }
        





    }
}



