using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicTacToe
{
    internal class Game
    {
        private Stopwatch gameTimer;
        int time;

        public int Time
        {
            get { return time; }
            set { time = value; }
        }


        /// <summary>
        /// Constructor that initializes game board and timer for counting points.
        /// </summary>
        public Game() 
        {
            
            InitializeBoard();
            gameTimer = new Stopwatch();
            gameTimer.Restart();
            gameTimer.Start();

        }


        int[,] board = new int[3, 3];


       
        /// <summary>
        /// Checks if there is a win in each column.
        /// </summary>
        /// <returns>True if there is win, false if no win.</returns>
        private bool CheckColumn() 
        {
            for (int col = 0; col < 3; col++)
            {
                if ((board[0, col] != 0) && (board[0, col] == board[1, col]) && (board[1, col] == board[2, col]))
                {
                    return true;
                }
            }
            return false;


        }

        /// <summary>
        /// Checks if there is a win in any of the rows.
        /// </summary>
        /// <returns>True if there is win, false if no win.</returns>
        private bool CheckRow() 
        {
            for (int row = 0; row < 3; row++)
            {
                if ((board[row, 0] != 0) && (board[row, 0] == board[row, 1]) && (board[row, 1] == board[row, 2]))
                {
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        /// Checks if there is a win diagonally.
        /// </summary>
        /// <returns>True if there is win, false if no win.</returns>
        private bool CheckDiagonal() 
        {
            if (board[0, 0] != 0 && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;

            // Check secondary diagonal
            if (board[0, 2] != 0 && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;

            return false;



        }

        /// <summary>
        /// Checks if there are any empty spaces. If so, it stops the timer.
        /// </summary>
        /// <returns>True if the board is full, false if there is at least one empty space.</returns>
        public bool CheckFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 0)
                    {
                        return false; // There is at least one empty cell
                    }
                }
            }
            

            gameTimer.Stop();
            time = (int)gameTimer.Elapsed.TotalSeconds;
            return true; // The board is completely filled with moves
        }




        /// <summary>
        /// Returns a win in any of the directions. 
        /// Also, stops the timer if there is a win.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="i"></param>
        /// <param name="n"></param>
        /// <returns>True if there is win, false if no win.</returns></returns>
        public bool CheckWin()
        {
            bool win = CheckDiagonal() || CheckColumn() || CheckRow();
           
            if (win)
            {
                gameTimer.Stop();
                time = (int)gameTimer.Elapsed.TotalSeconds;
            }

            return win;
            
        }

        /// <summary>
        /// Assigns a value 1 or 2 to the place chosen by a player.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="i">Num in a row.</param>
        /// <param name="n">Num in a column.</param>
        public char Move(Players player, int i, int n)
        {
            if (board[i, n] == 0)
            {
                board[i, n] = (player == Players.playerOne) ? 1 : 2;
            }
            if (board[i, n] == 1)
            {
                return 'x';
            }
            else if (board[i, n] == 2)
            {
                return 'o';
            }
            time = (int)gameTimer.Elapsed.TotalSeconds;
            return ' ';
        }



        /// <summary>
        /// Puts values of the board 
        /// </summary>
        public void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }
        }



        /// <summary>
        /// Calculates points based on time of the game and number of movements.
        /// </summary>
        /// <param name="winner"></param>
        /// <returns>Score</returns>
        public int CalculateScore(Players winner)
        {
            int score =6;

            //the fastest the better the less
            int k = (winner == Players.playerOne) ? 1 : 2;
            foreach(int place in board)
            {
                if(place == k)
                {
                    score--; 
                }
            }

            //divide by time
            if (time != 0)
            {
                score = 1000 * score / (int)gameTimer.Elapsed.TotalSeconds;
            }
            else score = score * 1000;
            if (score > 1)
            {
                return score;
            }
            else
            {
                return 1;
            }
        }

        
        


    }//class
}//namespace
