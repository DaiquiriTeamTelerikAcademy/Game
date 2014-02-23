using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Common
{
    public abstract class GameObject : IRenderable,IColidable
    {
        protected MatrixCoords topLeft;
        public MatrixCoords TopLeft//poziciq
        {
            get
            {
                return new MatrixCoords(topLeft.Row, topLeft.Col);
            }

            protected set
            {
                this.topLeft = new MatrixCoords(value.Row, value.Col);//vra6ta nov obekt za da se zapazi enkapsulaciqta
            }
        }

        protected char[,] body;//risunka na obekta

        public bool IsDestroyed { get; protected set; }//dali obekta e udaren

        protected GameObject(MatrixCoords topLeft, char[,] body)
        {
            this.TopLeft = topLeft;

            int imageRows = body.GetLength(0);
            int imageCols = body.GetLength(1);

            this.body = this.CopyBodyMatrix(body);

            this.IsDestroyed = false;
        }

        char[,] CopyBodyMatrix(char[,] matrixToCopy)
        {
            int rows = matrixToCopy.GetLength(0);
            int cols = matrixToCopy.GetLength(1);

            char[,] result = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    result[row, col] = matrixToCopy[row, col];
                }
            }

            return result;
        }

        public MatrixCoords GetTopLeft()
        {
            throw new NotImplementedException();
        }

        public char[,] GetImage()
        {
            throw new NotImplementedException();
        }

        public List<MatrixCoords> GetCollisionProfile()
        {
            throw new NotImplementedException();
        }

        public void RespondToCollision(CollisionData collisionData)
        {
            throw new NotImplementedException();
        }
    }
}
