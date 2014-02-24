using System.Collections.Generic;
namespace Game.Common
{
    public class Engine
    {
        IRenderer renderer;
        IUserInput userInterface;//dava dostap do kontrolite
        List<GameObject> allObjects;

        public Engine(IRenderer renderer, IUserInput userInterface)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
        }

        private void AddObject(GameObject obj)
        {
            this.allObjects.Add(obj);
        }

        public virtual void Run()
        {
            while (true)
            {
                this.renderer.RenderAll();//narisuvai kadar

                System.Threading.Thread.Sleep(500);//iz4akai 0.5sec

                this.userInterface.ProcessInput();//proverqva dali e natisnata nqkoq strelka , strelba i ako e si svar6i rabotata

                this.renderer.ClearQueue();//za4isti bufera

                foreach (var obj in this.allObjects)
                {
                    obj.Move();//pridviji obekta na kadeto e tragnal
                    this.renderer.EnqueueForRendering(obj);//narisuvai obekta
                }

                //CollisionDispatcher.HandleCollisions(this.allObjects);

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);//iztriva obektite koito sa ubiti
            }
        }
    }
}
