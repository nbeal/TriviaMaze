using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *Team //noComment
 *Nathan Beal & Nathan Owens
 *Software Eng. Final
 *Trivia Maze
*/

namespace ConsoleApplication4
{
    static class Tester
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Game());
        }
    }
}