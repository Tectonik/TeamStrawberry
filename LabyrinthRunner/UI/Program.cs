using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using LabyrinthRunner.Common;

namespace LabyrinthRunner.UI
{
    class Program
    {
        static void Main()
        {
            // Initialize console
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            ConsoleModifiers.Resize(Settings.ConsoleHeight, Settings.ConsoleWidth);
            Console.OutputEncoding = Encoding.Unicode;

            Menus.WelcomeScreen();
            GameEngine.GameLoop();
        }
    }
}
