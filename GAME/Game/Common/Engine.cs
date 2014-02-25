namespace Game.Common
{
    using System.Collections.Generic;

    using Game.Common.Player;

    public class Engine
    {
        IRenderer renderer;
        IUserInput userInterface;//dava dostap do kontrolite
        List<GameObject> allObjects;
        List<MovingObject> movingObjects;
        List<GameObject> staticObjects;
        PlayerAircraft aircraft;

        public Engine(IRenderer renderer, IUserInput userInterface)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();
            this.staticObjects = new List<GameObject>();
        }

        private void AddStaticObject(GameObject obj)
        {
            this.staticObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        private void AddMovingObject(MovingObject obj)
        {
            this.movingObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        public virtual void AddObject(GameObject obj)
        {
            if (obj is MovingObject)
            {
                this.AddMovingObject(obj as MovingObject);
            }
            else
            {
                if (obj is PlayerAircraft)
                {
                    AddRacket(obj);

                }
                else
                {
                    this.AddStaticObject(obj);
                }
            }
        }

        private void AddRacket(GameObject obj)
        {
            //TODO: we should remove the previous racket from this.allObjects
            this.aircraft = obj as PlayerAircraft;
            this.AddStaticObject(obj);
        }

        public virtual void MovePlayerRacketLeft()
        {
            this.aircraft.MoveLeft();
        }

        public virtual void MovePlayerRacketRight()
        {
            this.aircraft.MoveRight();
        }

        public virtual void Run()
        {
            while (true)
            {
                this.renderer.RenderAll();//narisuvai kadar

                System.Threading.Thread.Sleep(100);//iz4akai 0.5sec

                this.userInterface.ProcessInput();//proverqva dali e natisnata nqkoq strelka , strelba i ako e si svar6i rabotata

                this.renderer.ClearQueue();//za4isti bufera

                foreach (var obj in this.allObjects)
                {
                    obj.Move();//pridviji obekta na kadeto e tragnal
                    this.renderer.EnqueueForRendering(obj);//narisuvai obekta
                }

                CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects);

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);//iztriva obektite koito sa ubiti
                this.movingObjects.RemoveAll(obj => obj.IsDestroyed);
                this.staticObjects.RemoveAll(obj => obj.IsDestroyed);
            }
        }
    }
}
