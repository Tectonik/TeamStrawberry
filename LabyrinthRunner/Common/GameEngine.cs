using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabyrinthRunner.UI;
using LabyrinthRunner.AI;
using System.Threading;


namespace LabyrinthRunner.Common
{
    public static class GameEngine
    {
        //private static bool isGameOver;
        //private static List<IMovable> movables = new List<IMovable>();
        //private static List<IRenderable> renderables = new List<IRenderable>();

        private static List<IRenderable> Renderables {get;set;}

        private static List<IMovable> Movables { get;set;}

        public static Labyrinth CurrentLabyrinth {get;set;}

        public static bool IsGameOver { get; set; }

        public static void GameLoop()
        {
            IsGameOver = false;
            Movables = new List<IMovable>();
            Renderables = new List<IRenderable>();
            var hero = new HumanPlayer(10,10);
            CurrentLabyrinth = new Labyrinth();
            CurrentLabyrinth.LoadLevel(1);

            Movables.Add(hero);
            Renderables.Add(hero);
            //movables.Add(new CpuPlayer());    // needs to be implemented with simple AI        

            while (true)
            {
                GamePhysics();

                GameRenderer();

                if (IsGameOver)
                    break;
            }
        }

        public static void GamePhysics()
        {
            foreach (var movable in Movables)
            {
                movable.Move();
            }
        }

        public static void GameRenderer()
        {
            Console.Clear();

            CurrentLabyrinth.Render();

            foreach (var renderable in Renderables)
            {
                renderable.Render();
            }

            GameSpeed();
        }

        private static void GameSpeed()
        {
            Thread.Sleep(150);
        }
    }
}
