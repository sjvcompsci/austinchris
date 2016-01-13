using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Grounds
{
    class Player : Entity
    {
        // Keep track of how many Collectables are picked up by the Player.
        public static int Score = 0;
        //Luke Head Counter
        Text scoreset = new Text("The number of heads left is " + Score, 16);

        // Create a simple white rectangle to use for the image.
        
        // Create a BoxCollider to pick up collectables with (and give it the Player tag)
        BoxCollider collider = new BoxCollider(30, 30, TAAG.Player);
        Spritemap<Animation> s = new Spritemap<Animation>("Pacman.png", 51, 60);

        public Player(float x, float y) : base(x, y)
        {
            s.Add(Animation.Right, "0", 3);
            s.Add(Animation.Left, "1", 3);
            s.Add(Animation.Up, "2", 3);
            s.Add(Animation.Down, "3", 3);
          
            AddGraphic(s);
            s.CenterOrigin();
            // Add the collider. Must be added or it cant check for collision!
            AddCollider(collider);
            // Center the origin of the collider so it aligns with the image.
            collider.CenterOrigin();
        }

        public override void Update()
        {
            base.Update();
            X = Util.Clamp(X, 0, Game.Width - 30);
            Y = Util.Clamp(Y, 0, Game.Height - 30);
            // Basic movement with WASD.
            if (Input.KeyDown(Key.W))
            {
                s.Play(Animation.Up);
                Y -= 3;
            }
            if (Input.KeyDown(Key.S))
            {
                s.Play(Animation.Down);
                Y += 3;
            }
            if (Input.KeyDown(Key.A))
            {
                s.Play(Animation.Left);
                X -= 3;
            }
            if (Input.KeyDown(Key.D))
            {
                s.Play(Animation.Right);
                X += 3;
            }
        }
    }
}
