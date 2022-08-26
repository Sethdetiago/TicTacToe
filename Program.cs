using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GameLauncher LetsPlay = new GameLauncher();

            LetsPlay.FirstGame();

            LetsPlay.Rematch();


            
        }
    }
}
