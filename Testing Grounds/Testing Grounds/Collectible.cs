using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Grounds
{

    enum TAAG
    {
        Player,
        Collectable
    }
    class Collectible : Entity
    {
        Image image = new Image("Luke's Head.png");
        CircleCollider collider = new CircleCollider(10, TAAG.Collectable);

        public Collectible(float x, float y) : base(x, y)
        {
            AddGraphic(image);
            image.CenterOrigin();
            AddCollider(collider);
            collider.CenterOrigin();
        }

        public override void Update()
        {
            base.Update();
            
            if (collider.Overlap(X, Y, TAAG.Player))
            {
                RemoveSelf();
                Player.Score++;
            }
        }

        public override void Render()
        {
            base.Render();
        }
    }
}
