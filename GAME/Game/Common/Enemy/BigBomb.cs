namespace Game.Common.Enemy
{
    public class BigBomb : Bomb
    {
        public new const string CollisionGroupString = "big bomb";

        public BigBomb(MatrixCoords topLeft,MatrixCoords speed) : base(topLeft, new char[,] { {'#', '#'},
                                                                                              {'#','#'}},speed) { }                                                                              

        public override string GetCollisionGroupString()
        {
            return SmallBomb.CollisionGroupString;
        }
    }
}
