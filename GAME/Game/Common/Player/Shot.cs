﻿namespace Game.Common.Player
{
    using Game.Common;

    public class Shot : MovingObject
    {
        public new const string CollisionGroupString = "shot";

        public Shot(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft, new char[,] { { '|' } },speed) { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "enemy ship";
        }

        public override string GetCollisionGroupString()
        {
            return Shot.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)//kurshuma iz4ezva
        {
            //this.IsDestroyed = false;
        }
    }
}
