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
    }
}
