namespace Game.Common.Player
{
    public class PlayerAircraft : MovingObject
    {
        public new const string CollisionGroupString = "aircraft";

        public PlayerAircraft(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft, new char[,] { { '^', '^', '^', '^', '^', '^', '^', '^', } }, speed) { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "big bomb" || otherCollisionGroupString == "small bomb";
        }

        public override string GetCollisionGroupString()
        {
            return PlayerAircraft.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
