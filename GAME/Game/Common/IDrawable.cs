namespace Game.Common
{
    public interface IDrawable
    {
        void Update();
        Coordinates GetCoordinates();
        char[,] GetBody();
    }
}
