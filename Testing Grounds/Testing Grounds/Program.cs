using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Grounds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Game.
            var g = new Game("Eat the Lukes", 600, 480);

            


            // Start the Game.
            g.Start(new gameScene());
            
        }
    }


    
}
