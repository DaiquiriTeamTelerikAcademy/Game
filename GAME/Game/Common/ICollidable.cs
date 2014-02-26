namespace Game.Common
{
    using System.Collections.Generic;

    public interface ICollidable
    {
        bool CanCollideWith(string objectType);

        List<MatrixCoords> GetCollisionProfile();

        string GetCollisionGroupString();

        void RespondToCollision(CollisionData collisionData);//mehanizam po koito engina kazva za koliziq na obektite i te
                                                             //kazvat kakvo da se pravi.Pr.IsDestroyed == true
    }
}
