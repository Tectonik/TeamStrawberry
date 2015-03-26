using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using LabyrinthRunner.UI;

namespace LabyrinthRunner.Common
{
    public abstract class Player : IMovable, IRenderable
    {
        private Position position;
        private char skin;

        protected Player(int colPosition, int rowPosition, char skin)
        {
            this.Skin = skin;
            this.PositionCol = colPosition;
            this.PositionRow = rowPosition;
        }

        public char Skin
        {
            get { return skin; }
            set { skin = value; }
        }

        public int PositionRow
        {
            get { return position.Row; }
            set { position.Row = value; }
        }

        public int PositionCol
        {
            get { return position.Col; }
            set { position.Col = value; }
        }

        protected void MakeMove(string direction)
        {
            int rowOffset = 0;
            int colOffest = 0;

            if (direction == "left") colOffest = -1;
            if (direction == "right") colOffest = 1;
            if (direction == "up") rowOffset = -1;
            if (direction == "down") rowOffset = 1;

            if (GameEngine.CurrentLabyrinth.LabyrinthArr[this.PositionRow + rowOffset, this.PositionCol + colOffest] != Labyrinth.WallSkin)
            {
                this.PositionCol += colOffest;
                this.PositionRow += rowOffset;
            }
        }

        public abstract void Move();        

        public void Render()
        {
            Console.SetCursorPosition(this.PositionCol, this.PositionRow);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(this.Skin);
        }
    }
}
