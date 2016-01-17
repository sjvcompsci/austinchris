using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace Testing_Grounds
{
    class GameLoser : Scene
    {
        public override void Update()
        {
            base.Update();

            Text youlost = new Text("You lost. Better luck next time. Press space to play again!", 16);
            youlost.Color = Color.Black;
            AddGraphic(youlost, 50, 200);

            if (Input.KeyDown(Key.Space))
            {
                Game.SwitchScene(new gameScene());
                Player.Score = 0;
            }


        }
        
}
}
