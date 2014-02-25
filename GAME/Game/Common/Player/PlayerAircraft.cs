namespace Game.Common.Player
{
    public class PlayerAircraft : GameObject
    {
        public new const string CollisionGroupString = "aircraft";

        public PlayerAircraft(MatrixCoords topLeft) : base(topLeft, new char[,] { { '^', '^', '^', '^', '^', '^', '^', '^', } }) { }

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

        public void MoveLeft()
        {
            this.topLeft.Col--;
        }

        public void MoveRight()
        {
            this.topLeft.Col++;
        }

        public override void Move()
        {
        }
    }
}
