namespace Game.Common.Player
{
    public class Shot : GameObject
    {
        public new const string CollisionGroupString = "shot";

        public Shot(MatrixCoords topLeft,char[,] body) : base(topLeft, new char[,] { { '|' } }) { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "big bomb" || otherCollisionGroupString == "small bomb"||otherCollisionGroupString == "enemy ship";
        }

        public override string GetCollisionGroupString()
        {
            return Shot.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)//kurshuma iz4ezva
        {
            this.IsDestroyed = true;
        }

        public override void Move()
        {
            this.topLeft.Col--;
        }
    }
}
