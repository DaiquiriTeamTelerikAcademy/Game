namespace Game.Common.Enemy
{
    using Game.Common;

    public class EnemyShip : GameObject
    {
        public new const string CollisionGroupString = "enemy ship";

        public EnemyShip(MatrixCoords topLeft) : base(topLeft, new char[,] { { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', } }) { }

        public override bool CanCollideWith(string otherCollisionGroupString)// s kogo moga da se sblaskam
        {
            return otherCollisionGroupString == "shot";
        }

        public override void RespondToCollision(CollisionData collisionData)//kakvo pravq kato se sblaskam
        {
            this.IsDestroyed = false;
        }

        public override string GetCollisionGroupString()
        {
            return EnemyShip.CollisionGroupString;
        }

        public override void Move()// TODO: da vra6ta prazen spisak
        {
        }
    }
}
