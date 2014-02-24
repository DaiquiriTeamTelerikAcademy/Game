namespace Game.Common.Enemy
{

    public class SmallBomb : MovingObject
    {
        public new const string CollisionGroupString = "small bomb";

        public SmallBomb(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft, new char[,] { { '*' } }, speed) { }

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
