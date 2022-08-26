using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToe
    {
        private int playerNumber = 1;
        private string[,] board =
        {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"} 
        };
        bool flag1 = false;
        bool flag2 = false;
        bool flag3 = false;
        bool flag4 = false;
        bool flag5 = false;
        bool flag6 = false;
        bool flag7 = false;
        bool flag8 = false;
        bool flag9 = false;


        //Method to get input from Alternating players

        private string getInput(int player)
        {
            Console.WriteLine("Player {0} select a box", player);
            string selection = Console.ReadLine();
            return selection;
        }
        //Prints the tic tac toe board to the console
        private void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("_____________");
            for (int row=0; row<=2; row++)
            {
               // for(int col=0; col<=2; col++)
                //{
                    Console.WriteLine("| {0} | {1} | {2} |",board[row,0], board[row,1], board[row,2]);
                //}

               // Console.WriteLine("   |   |");
                Console.WriteLine("|___|___|___|");
            }
        }

        //Method to Parse input into matrix element
        //if not parseable or outside of the limit 
        //of 1 to 9 (boxes on the board
        private int[] parseInput(string playerSelection)
        {
            int[] input = new int[2];   //setting up an array to contain posistion of selection
                                        //within the 2D array board
            if (int.TryParse(playerSelection, out int boardselection))  // Parses selection and sets it to int boardselction
            {
                
                switch (boardselection) //depending on selection sets up array to select matrix element
                {
                    case 1:
                        if (flag1== true)
                        {
                            Console.WriteLine("Space taken, select another space");
                            input[0] = 3;
                            input[1] = 3;
                            return input;
                            break;
                        }
                        else
                        {
                            input[0] = 0;
                            input[1] = 0;
                            flag1 = true;
                            return input;
                            break;
                        }
                    case 2:
                        if (flag2== true)
                        {
                            Console.WriteLine("Space taken, select another space");
                            input[0] = 3;
                            input[1] = 3;
                            return input;
                            break;
                        }
                        else
                        {
                            input[0] = 0;
                            input[1] = 1;
                            flag2 = true;
                            return input;
                            break;
                        }

                    case 3:
                        if (flag3== true)
                        {
                            Console.WriteLine("Space taken, select another space");
                            input[0] = 3;
                            input[1] = 3;
                            return input;
                            break;
                        }
                        else
                        {
                            input[0] = 0;
                            input[1] = 2;
                            flag3 = true;
                            return input;
                            break;
                        }

                    case 4:
                        if (flag4== true)
                        {
                            Console.WriteLine("Space taken, select another space");
                            input[0] = 3;
                            input[1] = 3;
                            return input;
                            break;
                        }
                        else
                        {
                            input[0] = 1;
                            input[1] = 0;
                            flag4 = true;
                            return input;
                            break;
                        }

                    case 5:
                        if (flag5== true)
                        {
                            Console.WriteLine("Space taken, select another space");
                            input[0] = 3;
                            input[1] = 3;
                            return input;
                            break;
                        }
                        else
                        {
                            input[0] = 1;
                            input[1] = 1;
                            flag5 = true;
                            return input;
                            break;
                        }

                    case 6:
                        if (flag6== true)
                        {
                            Console.WriteLine("Space taken, select another space");
                            input[0] = 3;
                            input[1] = 3;
                            return input;
                            break;
                        }
                        else
                        {
                            input[0] = 1;
                            input[1] = 2;
                            flag6 = true;
                            return input;
                            break;
                        }

                    case 7:
                        if (flag7== true)
                        {
                            Console.WriteLine("Space taken, select another space");
                            input[0] = 3;
                            input[1] = 3;
                            return input;
                            break;
                        }
                        else
                        {
                            input[0] = 2;
                            input[1] = 0;
                            flag7 = true;
                            return input;
                            break;
                        }

                    case 8:
                        if (flag8== true)
                        {
                            Console.WriteLine("Space taken, select another space");
                            input[0] = 3;
                            input[1] = 3;
                            return input;
                            break;
                        }
                        else
                        {
                            input[0] = 2;
                            input[1] = 1;
                            flag8 = true;
                            return input;
                            break;
                        }

                    case 9:
                        if (flag9== true)
                        {
                            Console.WriteLine("Space taken, select another space");
                            input[0] = 3;
                            input[1] = 3;
                            return input;
                            break;
                        }
                        else
                        {
                            input[0] = 2;
                            input[1] = 2;
                            flag9 = true;
                            return input;
                            break;
                        }


                    default:            //if selection is  a number out of the range 1-9
                        Console.WriteLine("Invalid Response. Please enter a value between 1 and 9");
                        input[0] = 3;
                        input[1] = 3;
                        return input;
                        break;
                }

            }
            else      //if selection does not parse
            {       Console.WriteLine("Invalid response. Please enter a value between 1 and 9");
                input[0] = 3;
                input[1] = 3;
            return input;
        }
        }
        
        
        //Method to write to an element of the board
        private void WriteElement(int[] matrixElement, int playerNum)
            {
            if (playerNum == 1)
            {
                if (int.TryParse(board[matrixElement[0], matrixElement[1]], out int result))
                    board[matrixElement[0], matrixElement[1]] = "X";
            }
            else if(playerNum == 2)
            {
                if (int.TryParse(board[matrixElement[0], matrixElement[1]], out int result))
                    board[matrixElement[0], matrixElement[1]] = "O";
            }
            }
        //Method that checks to see if there is a winner
        private string winnerChecker(string[,] board)
        {
            for (int row = 0; row <= 2; row++)
            {
                if (board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                    if (board[row, 0] == "X")
                        {
                        return "Player 1 Wins!";
                    }
                    else
                        return "Player 2 Wins!";

            }

            for (int column = 0; column <= 2; column++)
            {
                if (board[0, column] == board[1, column] && board[1, column] == board[2, column])
                {
                    if (board[0, column] == "X")
                        {
                        return "Player 1 Wins!";
                    }
                    else
                        return "Player 2 Wins!";
                }
            }
            if (board[0, 0] == board[1, 1] && board[1,1] == board[2, 2])
            {
                if (board[0, 0] == "X")
                {
                    return "Player 1 Wins!";
                }
                else
                    return "Player 2 Wins!";
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                if (board[0, 2] == "X")
                {
                    return "Player 1 Wins!";
                }
                else
                    return "Player 2 Wins!";
            }
            else
                return null;
        }
 

        //High level Method to call for input from player, parse it and if not null write to the board
        private int performTurn(int playernum)
        {
            DisplayBoard();
            if (playernum == 0)
            { playernum = 1; }

           
            int[] parsedInput = {3,3};
            while (parsedInput[0] == 3)
            {
                string input = getInput(playernum);
                parsedInput = parseInput(input);
                
               
            }
            WriteElement(parsedInput, playernum);

            if (playernum == 1)
                { playernum = 2; }
            else if(playernum == 2)
                { playernum = 1; }

            return playernum;

        }

        //Plays a single game of tic tac toe
        public void PlayGame()
        {
            for (int i = 0; i < 9; i++)
            {


                int nextPlayer = performTurn(playerNumber);
                playerNumber = nextPlayer;

                string Winner = winnerChecker(board);
                if (Winner != null)
                {
                    DisplayBoard();
                    Console.WriteLine("{0}", Winner);
                    i = i + 10;
                }
                else if(i ==8)
                {
                    Console.WriteLine("Tie!");
                }

            }
        }

       


    }
 }

    

