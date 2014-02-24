namespace Game.Common.Enemy
{
    public class BigBomb : Bomb
    {
        public new const string CollisionGroupString = "big bomb";

        public BigBomb(MatrixCoords topLeft,char[,] body) : base(topLeft, new char[,] { { '*', '*', '*' } }) { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "aircraft";
        }

        public override string GetCollisionGroupString()
        {
            return SmallBomb.CollisionGroupString;
        }
    }
}
