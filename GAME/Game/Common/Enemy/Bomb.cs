using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Common.Enemy
{
    public class Bomb : GameObject
    {
        public Bomb(MatrixCoords topLeft, char[,] body) : base(topLeft, body) { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "aircraft";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override void Move()
        {
            this.topLeft.Row++;
        }
    }
}
