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
        Text scoreset = new Text(("The number of heads left is " + Player.Score), 14);
        public gameScene() : base()
        {

            // Add 50 collectables in random locations to the Scene.
            for (int i = 0; i < 50; i++)
            {
                var x = Rand.Int(1, 550);
                var y = Rand.Int(1, 430);
                Add(new Collectible(x, y));
            }
            Add(new Player(100, 100));
            AddGraphic(timer, 380, 10);
        }

        private RichText timer = new RichText(16);
        private RichText timer2 = new RichText(16);
        private DateTime timerstart = DateTime.Now;
        public override void Update()
        {
            base.Update();
            TimeSpan diff = timerstart - DateTime.Now;
            int countdown = 60 + (int)diff.TotalSeconds;

            timer.String = "Countdown: " + countdown;
            timer.Color = Color.Black;
            

            if (Input.KeyDown(Key.Space))
            {
                timerstart = DateTime.Now;
            }

            if (Player.Score == 50)
            {
                //MAKE TIMER STOP WHEN ALL HEADS COLLECTED
                //RemoveGraphic(timer);
            }

            scoreset.Color = Color.Black;
            scoreset.String = "The number of heads left is " + (50 - Player.Score);

            AddGraphic(scoreset, 20, 5);

            if (Player.Score == 50)
            {
                Game.SwitchScene(new EndScene());
                /*Text gameover = new Text(("Congratulations! You collected all of the Luke heads!"), 16);
                gameover.Color = Color.Black;
                gameover.String = "Congratulations! You collected all of the Luke heads!";
                AddGraphic(gameover, 20, 40);
                //RemoveGraphic(scoreset);*/
            }


        }

    }   
}
