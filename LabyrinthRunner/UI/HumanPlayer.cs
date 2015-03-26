using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabyrinthRunner.Common;

namespace LabyrinthRunner.UI
{
    class HumanPlayer : Player, IMovable, IRenderable
    {
        public HumanPlayer(int rowPosition, int colPosition)
            : base(colPosition, rowPosition, (char)9787)
        { }

        public override void Move()
        {
            while (Console.KeyAvailable)
            {
                // we assign the pressed key value to a variable pressedKey
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                // next we start checking the value of the pressed key and take action if neccessary
                if (pressedKey.Key == ConsoleKey.LeftArrow) // if left arrow is pressed then
                {
                    this.MakeMove("left");
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    this.MakeMove("right");

                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    this.MakeMove("up");

                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    this.MakeMove("down");

                }

            }
        }

    }
}
