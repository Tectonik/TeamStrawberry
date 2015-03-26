using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthRunner.UI
{
    public static class Menus
    {
        public static void WelcomeScreen()
        {
            ConsoleModifiers.PrintText("Welcome", ConsoleCoords.CenterScreen, -3);
            ConsoleModifiers.PrintText("Press a key to begin", ConsoleCoords.CenterScreen, -9, 1);

            Console.Read();
            Console.Clear();

        }
    }
}
