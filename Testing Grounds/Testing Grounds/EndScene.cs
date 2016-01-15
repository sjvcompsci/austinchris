using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace Testing_Grounds
{
    class EndScene : Scene
    {
        public override void Update()
        {
            base.Update();
         
                Text celebratetext = new Text("Congratulations! You beat the game!", 20);
                celebratetext.Color = Color.Black;
                AddGraphic(celebratetext, 150, 240);
                
                
        }
    }
}
