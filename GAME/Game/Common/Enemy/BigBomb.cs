namespace Game.Common.Enemy
{
    public class BigBomb : MovingObject
    {
        public new const string CollisionGroupString = "big bomb";

        public BigBomb(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft, new char[,] { { '*','*','*' } }, speed) { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "aircraft";
        }

        public override string GetCollisionGroupString()
        {
            return SmallBomb.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
