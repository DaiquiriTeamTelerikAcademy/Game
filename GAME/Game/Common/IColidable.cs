namespace Game.Common
{
    using System.Collections.Generic;

    public interface IColidable
    {
        List<MatrixCoords> GetCollisionProfile();

        void RespondToCollision(CollisionData collisionData);//mehanizam po koito engina kazva za koliziq na obektite i te
                                                             //kazvat kakvo da se pravi.Pr.IsDestroyed == true
    }
}
