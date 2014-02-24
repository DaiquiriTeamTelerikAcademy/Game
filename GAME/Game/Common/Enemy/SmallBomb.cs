namespace Game.Common.Enemy
{

    public class SmallBomb : Bomb
    {
        public new const string CollisionGroupString = "small bomb";

        public SmallBomb(MatrixCoords topLeft,char[,] body) : base(topLeft, new char[,] { { '*' } }) { }

        public override string GetCollisionGroupString()
        {
            return SmallBomb.CollisionGroupString;
        }

    }
}
