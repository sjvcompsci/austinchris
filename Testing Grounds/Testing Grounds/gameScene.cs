using Otter;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing_Grounds
{
    class gameScene : Scene
    {
        Text scoreset = new Text(("The number of heads left is " + Player.Score), 16);
        public gameScene() : base()
        {

            // Add 50 collectables in random locations to the Scene.
            for (int i = 0; i < 50; i++)
            {
                // Check out the Rand class for random generation!
                var x = Rand.Int(1,550);
                var y = Rand.Int(1,430);
                // Add the Collectable at the randomized position.
                Add(new Collectible(x, y));
            }
            
            
            Add(new Player(100,100));
        }
        public override void Update()
        {
            base.Update();
            scoreset.String = "The number of heads left is " + (50 - Player.Score);
            AddGraphic(scoreset, 20, 20);

        }
    }
}
