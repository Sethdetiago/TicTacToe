using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class GameLauncher
    {
        //class that creates first game object and starts single game
        public void FirstGame()
        {
            TicTacToe Game = new TicTacToe();

            Console.WriteLine("LET'S PLAY TIC TAC TOE!!!");

            Game.PlayGame();
        }

        //class that prompts rematch until player no longer wishes to play
        //creates new object for each rematch
        public void Rematch()
        {
            Console.WriteLine("Would you like to play again? (y/n)");
            string PlayAgain = Console.ReadLine();

            while ((PlayAgain != "y") && (PlayAgain != "Y") && (PlayAgain != "n") && (PlayAgain != "N"))
            {
                Console.WriteLine("Please enter \"y\" or \"n\"");
                PlayAgain = Console.ReadLine();
            }

            while ((PlayAgain == "y") || (PlayAgain == "Y"))
            {
                TicTacToe newGame = new TicTacToe();
                newGame.PlayGame();

                Console.WriteLine("Would you like to play again?(y/n)");

                PlayAgain = Console.ReadLine();
                while ((PlayAgain != "y") && (PlayAgain != "Y") && (PlayAgain != "n") && (PlayAgain != "N"))
                {
                    Console.WriteLine("Please enter \"y\" or \"n\"");
                    PlayAgain = Console.ReadLine();
                }
            }
        }
    }
}
