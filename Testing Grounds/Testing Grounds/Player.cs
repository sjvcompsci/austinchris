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
        public static int Score = 0;
        //Luke Head Counter
        BoxCollider collider = new BoxCollider(30, 30, TAAG.Player);
        Spritemap<Animation> s = new Spritemap<Animation>("Pacman.png", 50, 60);

        public Player(float x, float y) : base(x, y)
        {
            s.Add(Animation.Right, "0", 3);
            s.Add(Animation.Left, "1", 3);
            s.Add(Animation.Up, "2", 3);
            s.Add(Animation.Down, "3", 3);
          
            AddGraphic(s);
            s.CenterOrigin();
            AddCollider(collider);
            collider.CenterOrigin();
        }

        public override void Update()
        {
            base.Update();
            X = Util.Clamp(X, 0, Game.Width - 30);
            Y = Util.Clamp(Y, 0, Game.Height - 30);
            if (Input.KeyDown(Key.W))
            {
                s.Play(Animation.Up);
                Y -= 5;
            }
            if (Input.KeyDown(Key.S))
            {
                s.Play(Animation.Down);
                Y += 5;
            }
            if (Input.KeyDown(Key.A))
            {
                s.Play(Animation.Left);
                X -= 5;
            }
            if (Input.KeyDown(Key.D))
            {
                s.Play(Animation.Right);
                X += 5;
            }
        }
    }
}
