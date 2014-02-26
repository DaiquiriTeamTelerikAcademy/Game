namespace Game.Common.Enemy
{
    using Game.Common;
    using System.Collections.Generic;

    public class EnemyShip : GameObject
    {
        public new const string CollisionGroupString = "enemy ship";

       private static char[,] enemyShipBody = 
        {
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', }
        };
        public EnemyShip(MatrixCoords topLeft) : base(topLeft, enemyShipBody) { }

        public override bool CanCollideWith(string otherCollisionGroupString)// s kogo moga da se sblaskam
        {
            return otherCollisionGroupString == "shot";
        }

        public override void RespondToCollision(CollisionData collisionData)//kakvo pravq kato se sblaskam
        {
            this.IsDestroyed = true;
        }

        public override string GetCollisionGroupString()
        {
            return EnemyShip.CollisionGroupString;
        }

        public override void Move()// TODO: da vra6ta prazen spisak
        {
        }

        public override List<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            int randomSmallBomb = RandomGenerator.Generator.Next(0, 200);
            int randomBigBomb = RandomGenerator.Generator.Next(0, 100);
            int randomPositionSmallBomb = RandomGenerator.Generator.Next(0, 20);
            int randomPositionBigBomb = RandomGenerator.Generator.Next(0, 20);
            if (randomSmallBomb % 10 == 0 && randomSmallBomb % 2 == 0)
            {
                producedObjects.Add(new SmallBomb(new MatrixCoords(this.TopLeft.Row + 1, randomPositionSmallBomb),new MatrixCoords(1,0)));
            }
            if (randomSmallBomb % 3 == 0 && randomSmallBomb % 5 == 0)
            {
                producedObjects.Add(new BigBomb(new MatrixCoords(this.TopLeft.Row + 1, randomPositionBigBomb), new MatrixCoords(1, 0)));
            }
            return producedObjects;
        }
    }
}
