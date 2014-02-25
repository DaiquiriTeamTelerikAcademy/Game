namespace Game
{
    using System;

    using Game.Common.Enemy;
    using Game.Common;
    using Game.Common.Player;

    public class Program
    {
        const int WorldRows = 20;
        const int WorldCols = 20;

        static void Initialize(Engine engine)
        {
            int startRow = 0;
            int startCol = 0;
            //int endCol = WorldCols - 2;

            EnemyShip ship = new EnemyShip(new MatrixCoords(startRow, startCol));
            engine.AddObject(ship);
            PlayerAircraft aircraft = new PlayerAircraft(new MatrixCoords(WorldRows - 1, WorldCols / 2));
            engine.AddObject(aircraft);
            Shot shot = new Shot(new MatrixCoords(15, 5), new MatrixCoords(-1, 0));
            shot.Move();
            engine.AddObject(shot);
        }

        static void Main()
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInput keyboard = new KeyboardInput();
            Engine gameEngine = new Engine(renderer, keyboard);
            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            
            Initialize(gameEngine);
            gameEngine.Run();
        }
    }
}
