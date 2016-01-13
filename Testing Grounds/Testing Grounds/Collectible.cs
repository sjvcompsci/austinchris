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
        // Create a basic yellow circle.
        Image image = new Image("Luke's Head.png");
        // Create a CircleCollider and tag it with the Collectable tag.
        CircleCollider collider = new CircleCollider(10, TAAG.Collectable);

        public Collectible(float x, float y) : base(x, y)
        {
            // Add the image for rendering.
            AddGraphic(image);
            // Center the origin of the image.
            image.CenterOrigin();

            // Add the collider so that it can check for collisions.
            AddCollider(collider);
            // Center the origin of the collider so it aligns with the image.
            collider.CenterOrigin();
        }

        public override void Update()
        {
            base.Update();

            // Use the collider to check for an overlap with anything tagged as a Player.
            if (collider.Overlap(X, Y, TAAG.Player))
            {
                // Remove itself from the scene when collected.
                RemoveSelf();
                // Increase the player score, yahoo!
                Player.Score++;
            }
        }

        public override void Render()
        {
            base.Render();

            // Uncomment the following line to see the collider.
            //collider.Render();
        }
    }
}
