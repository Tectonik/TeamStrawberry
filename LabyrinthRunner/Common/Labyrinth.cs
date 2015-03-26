using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabyrinthRunner.Common
{
    public class Labyrinth : IRenderable
    {
        public static char WallSkin = '\u2588';

        private char[,] labyrinth = new char[20, 20];

        public char[,] LabyrinthArr
        {
            get { return labyrinth; }
            set { labyrinth = value; }
        }

        public char this[int row, int col]
        {
            get
            {
                return this.LabyrinthArr[row, col];
            }
        }

        public void Render()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(this);
        }

        public void LoadLevel(int level)
        {
            using (StreamReader source = new StreamReader(@"..\..\..\Levels.txt"))
            {
                string currentLine = "";
                currentLine = source.ReadLine();
                int j = 0;
                while (currentLine != null)
                {
                    for (int i = 0; i < this.LabyrinthArr.GetLength(1); i++)
                    {
                        this.LabyrinthArr[j, i] = currentLine[i];
                    }

                    j++;
                    currentLine = source.ReadLine();
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.LabyrinthArr.GetLength(0); i++)
            {
                for (int j = 0; j < this.LabyrinthArr.GetLength(1); j++)
                {
                    sb.Append(this.LabyrinthArr[i, j]);
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
