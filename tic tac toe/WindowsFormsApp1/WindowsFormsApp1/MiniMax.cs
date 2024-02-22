using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class MiniMax
    {
        //functia returneaza true daca mai exista mutari disponibile
        //returneaza false daca nu mai exista mutari
        static Boolean IsMovesLeft(string[][] board)
        {
            
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (board[i][j] == Form1.EMPTY)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //functia de evaluare
        static int Evaluate(string[][] board)
        {
            //verificam liniile pentru a vedea daca X sau O castiga
            for (int i = 0; i < 3; ++i)
            {
                if (board[i][0] == board[i][1] && board[i][1] == board[i][2])
                {
                    if (board[i][0] == Form1.X)
                    {
                        return +10;
                    }
                    else
                    {
                        return -10;
                    }
                }
            }
            //verificam coloanele
            for (int j = 0; j < 3; ++j)
            {
                if (board[0][j] == board[1][j] && board[1][j] == board[2][j])
                {
                    if (board[0][j] == Form1.X)
                    {
                        return +10;
                    }
                    else
                    {
                        return -10;
                    }
                }

            }
            //verificam diagonalele
            if (board[0][0] == board[1][1] && board[1][1] == board[2][2])
            {
                if (board[0][0] == Form1.X)
                {
                    return +10;
                }
                else
                {
                    return -10;
                }
            }
            if (board[0][2] == board[1][1] && board[1][1] == board[2][0])
            {
                if (board[0][2] == Form1.X)
                {
                    return 10;
                }
                else
                {
                    return -10;
                }
            }
            //daca este remiza
            return 0;
        }

        //minmax
        static int Minimax(string[][] board, int depth, Boolean isMax, int alpha, int beta)
        {
            int score = Evaluate(board);

            // If Maximizer has won the game
            // return his/her evaluated score
            if (score == 10)
                return score;

            // If Minimizer has won the game
            // return his/her evaluated score
            if (score == -10)
                return score;

            // If there are no more moves and
            // no winner then it is a tie
            if (IsMovesLeft(board) == false)
                return 0;

            // If this maximizer's move
            if (isMax)
            {
                int best = -1000;

                // Traverse all cells
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Check if cell is empty
                        if (board[i][j] == Form1.EMPTY)
                        {
                            // Make the move
                            board[i][j] = Form1.X;

                            // Call minimax recursively and choose
                            // the maximum value
                            best = Math.Max(best, Minimax(board,
                                            depth + 1, !isMax, alpha, beta));
                            alpha = Math.Max(alpha, best);
                            if (beta <= alpha)
                            {
                                break;
                            }

                            // Undo the move
                            board[i][j] = Form1.EMPTY;
                        }
                    }
                }
                return best;
            }

            // If this minimizer's move
            else
            {
                int best = 1000;

                // Traverse all cells
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Check if cell is empty
                        if (board[i][j] == Form1.EMPTY)
                        {
                            // Make the move
                            board[i][j] = Form1.O;

                            // Call minimax recursively and choose
                            // the minimum value
                            best = Math.Min(best, Minimax(board,
                                            depth + 1, !isMax, alpha, beta));
                            beta = Math.Min(beta, best);
                            if (beta <= alpha)
                            {
                                break;
                            }

                            // Undo the move
                            board[i][j] = Form1.EMPTY;
                        }
                    }
                }
                return best;
            }
        }
        //gaseste cea mai buna mutare
        public static Form1.Poz FindBestMove(string[][] board)
        {
            int bestVal = -1000;
            Form1.Poz bestMove = new Form1.Poz();
            bestMove.col = -1;
            bestMove.row = -1;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] == Form1.EMPTY)
                    {
                        board[i][j] = Form1.X;
                        int moveVal = Minimax(board, 0, false, -1000, 1000);
                        board[i][j] = Form1.EMPTY;
                        if (moveVal > bestVal)
                        {
                            bestMove.row = i;
                            bestMove.col = j;
                            bestVal = moveVal;
                        }
                    }
                }
            }
            return bestMove;
        }
    }
}
