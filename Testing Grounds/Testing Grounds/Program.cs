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
            var g = new Game("Eat the Lukes", 600, 480);
            g.Color = Color.White;
            g.Start(new gameScene());
            
        }
    }


    
}
