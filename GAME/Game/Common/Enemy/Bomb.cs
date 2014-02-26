namespace Game.Common.Enemy
{
    using Game.Common.Player;
    public class Bomb : MovingObject
    {
        public Bomb(MatrixCoords topLeft, char[,] body, MatrixCoords speed) : base(topLeft, body,speed) { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "aircraft";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
