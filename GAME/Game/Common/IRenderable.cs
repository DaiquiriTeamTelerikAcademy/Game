namespace Game.Common
{
    public interface IRenderable
    {
        MatrixCoords GetTopLeft();//vzima koordinati na obekta   

        char[,] GetImage();//vra6ta kak izglejda obecta
    }
}
