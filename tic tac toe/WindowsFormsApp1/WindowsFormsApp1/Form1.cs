using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int scoreX;
        int scoreO;
        int draw=0;
        bool playerTypeX, playerTypeO;
        bool player = false;
        bool AI = false;
        public const string EMPTY = null;
        public const string X = "X";
        public const string O = "O";
        public string[][] board;

        public class Poz
        {
            public int row;
            public int col;
        };
           

        public void InitBoard()
        {
            board = new string[][] {new string[] { EMPTY, EMPTY, EMPTY },
            new string[] { EMPTY, EMPTY, EMPTY},
            new string[] { EMPTY, EMPTY, EMPTY }
        };
        }

        public void ButtonDissable()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        public void Score()
        {
            //partea cu X

            if(button1.Text=="X" && button2.Text=="X" && button3.Text == "X")
            {
                button1.BackColor = Color.AliceBlue;
                button2.BackColor = Color.AliceBlue;
                button3.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is X", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreX =int.Parse(label3.Text);
                scoreX++;
                label3.Text = scoreX.ToString();
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button6.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is X", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreX = int.Parse(label3.Text);
                scoreX++;
                label3.Text = scoreX.ToString();
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.AliceBlue;
                button8.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is X", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreX = int.Parse(label3.Text);
                scoreX++;
                label3.Text = scoreX.ToString();
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is X", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreX = int.Parse(label3.Text);
                scoreX++;
                label3.Text = scoreX.ToString();
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button7.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is X", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreX = int.Parse(label3.Text);
                scoreX++;
                label3.Text = scoreX.ToString();
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button8.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is X", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreX = int.Parse(label3.Text);
                scoreX++;
                label3.Text = scoreX.ToString();
            }
            else if (button6.Text == "X" && button9.Text == "X" && button3.Text == "X")
            {
                button6.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;
                button3.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is X", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreX = int.Parse(label3.Text);
                scoreX++;
                label3.Text = scoreX.ToString();
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button6.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;
                button3.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is X", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreX = int.Parse(label3.Text);
                scoreX++;
                label3.Text = scoreX.ToString();
            }

            //partea cu O

            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.AliceBlue;
                button2.BackColor = Color.AliceBlue;
                button3.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is O", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreO = int.Parse(label3.Text);
                scoreO++;
                label3.Text = scoreO.ToString();
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button6.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is O", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreO = int.Parse(label3.Text);
                scoreO++;
                label3.Text = scoreO.ToString();
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.AliceBlue;
                button8.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is O", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreO = int.Parse(label3.Text);
                scoreO++;
                label3.Text = scoreO.ToString();
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is O", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreO = int.Parse(label3.Text);
                scoreO++;
                label3.Text = scoreO.ToString();
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button7.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is O", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreO = int.Parse(label3.Text);
                scoreO++;
                label3.Text = scoreO.ToString();
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button8.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is O", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreO = int.Parse(label3.Text);
                scoreO++;
                label3.Text = scoreO.ToString();
            }
            else if (button6.Text == "O" && button9.Text == "O" && button3.Text == "O")
            {
                button6.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;
                button3.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is O", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreO = int.Parse(label3.Text);
                scoreO++;
                label3.Text = scoreO.ToString();
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button6.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;
                button3.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is O", "X si 0", MessageBoxButtons.OK);
                AI = false;
                player = false;
                ButtonDissable();

                scoreO = int.Parse(label3.Text);
                scoreO++;
                label3.Text = scoreO.ToString();
            }
            else if (draw==9)
            {
                MessageBox.Show("Draw", "X si 0", MessageBoxButtons.OK);
                ButtonDissable();
                AI = false;
                player = false;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=0, j=0;
            if (player && playerTypeX)
            {
                button1.Text = "X";
                player= false;
                button1.Enabled = false;
                board[i][j] = X;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
            else if (player && playerTypeO)
            {
                button1.Text = "O";
                player = false;
                button9.Enabled = false;
                board[i][j] = O;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
            //Score();
            turaAI();
           // Score();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i=0, j=1;
            if (player && playerTypeX)
            {
                button2.Text = "X";
                player = false;
                button2.Enabled = false;
                board[i][j] = X;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
            else if (player && playerTypeO)
            {
                button2.Text = "O";
                player = false;
                button9.Enabled = false;
                board[i][j] = O;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
           // Score();
            turaAI();
          //  Score();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i=0, j=2;
            if (player && playerTypeX)
            {
                button3.Text = "X";
                player=false;
                button3.Enabled = false;
                board[i][j] = X;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
            else if (player && playerTypeO)
            {
                button3.Text = "O";
                player = false;
                button9.Enabled = false;
                board[i][j] = O;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
           // Score();
            turaAI();
           // Score();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i=1, j=0;
            if (player && playerTypeX)
            {
                button4.Text = "X";
                player = false;
                button4.Enabled = false;
                board[i][j] = X;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
            else if (player && playerTypeO)
            {
                button4.Text = "O";
                player = false;
                button9.Enabled = false;
                board[i][j] = O;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
            //Score();
            turaAI();
           // Score();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i=1, j=1;
            if (player && playerTypeX)
            {
                button5.Text = "X";
                player = false;
                button5.Enabled = false;
                board[i][j] = X;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
            else if (player && playerTypeO)
            {
                button5.Text = "O";
                player = false;
                button9.Enabled = false;
                board[i][j] = O;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
           // Score();
            turaAI();
           // Score();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i=1, j=2;
            if (player && playerTypeX)
            {
                button6.Text = "X";
                player = false;
                button6.Enabled = false;
                board[i][j] = X;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
            else if (player && playerTypeO)
            {
                button6.Text = "O";
                player = false;
                button9.Enabled = false;
                board[i][j] = O;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
            //Score();
            turaAI();
           // Score();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i=2, j=0;
            if (player && playerTypeX)
            {
                button7.Text = "X";
                player = false;
                button7.Enabled = false;
                board[i][j] = X;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
            else if (player && playerTypeO)
            {
                button7.Text = "O";
                player = false;
                button9.Enabled = false;
                board[i][j] = O;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
           // Score();
            turaAI();
           // Score();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i=2, j=1;
            if (player && playerTypeX)
            {
                button8.Text = "X";
                player = false;
                button8.Enabled = false;
                board[i][j] = X;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
            else if (player && playerTypeO)
            {
                button8.Text = "O";
                player = false;
                button8.Enabled = false;
                board[i][j] = O;
                AI = true;
                label6.Text = "Tura AI";
                draw++;
            }
           // Score();
            turaAI();
           // Score();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i=2, j=2;
            if (player && playerTypeX)
            {
                button9.Text = "X";
                player = false;
                button9.Enabled = false;
                board[i][j] = X;
                AI = true;
                label6.Text = "tura AI";
                draw++;
            }
            else if(player && playerTypeO)
            {
                button9.Text = "O";
                player = false;
                button9.Enabled = false;
                board[i][j] = O;
                AI = true;
                label6.Text = "tura AI";
                draw++;
            }
           // Score();
            turaAI();
           // Score();
           
        }

        //new game
        private void button10_Click(object sender, EventArgs e)
        {
            InitBoard();
            draw = 0;
            playerTypeO = false;
            playerTypeX= false;
            var p = MessageBox.Show("Vrei sa joci cu X?", "X si O", MessageBoxButtons.YesNo);
            if(p == DialogResult.Yes)
            {
                playerTypeX = true;
                label5.Text = "jucatorul este X";
                label7.Text = "AI este O";
            }
            else
            {
                playerTypeO = true;
                label5.Text = "jucatorul este O";
                label7.Text = "AI este X";
            }
           
            
            int r=new Random().Next(1,10);
            if (r > 5)
            {
                player = true;
                label6.Text = "tura jucator";
            }
            else
            {
                AI = true;
                label6.Text = "tura AI";
            }
            if (AI)
            {
                label6.Text = "tura AI";
                turaAI();
                //Score();
            }

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            label3.Text = "0";
            label4.Text = "0";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Confirm if you want to exit", "X si O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"X si O",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //reset
        private void button11_Click(object sender, EventArgs e)
        {
            InitBoard();
            draw = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            int r = new Random().Next(1, 10);
            if (r > 5)
            {
                player = true;
                label6.Text = "tura jucator";
            }
            else
            {
                AI = true;
                label6.Text = "tura AI";
            }
            if (AI)
            {
                label6.Text = "tura AI";
                turaAI();
                Score();
            }

        }
        private void turaAI()
        {

            Score();

            Poz bestMove=MiniMax.FindBestMove(board);
            
            if (AI & playerTypeX)
            {
                if (bestMove.row == 0 && bestMove.col == 0)
                {
                    button1.Text = "O";
                    AI = false;
                    button1.Enabled = false;
                    board[bestMove.row][bestMove.col] = O;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 0 && bestMove.col == 1 )
                {
                    button2.Text = "O";
                    AI = false;
                    button2.Enabled = false;
                    board[bestMove.row][bestMove.col] = O;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 0 && bestMove.col == 2 )
                {
                    button3.Text = "O";
                    AI = false;
                    button3.Enabled = false;
                    board[bestMove.row][bestMove.col] = O;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 1 && bestMove.col == 0)
                {
                    button4.Text = "O";
                    AI = false;
                    button4.Enabled = false;
                    board[bestMove.row][bestMove.col] = O;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 1 && bestMove.col == 1 )
                {
                    button5.Text = "O";
                    AI = false;
                    button5.Enabled = false;
                    board[bestMove.row][bestMove.col] = O;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 1 && bestMove.col == 2 )
                {
                    button6.Text = "O";
                    AI = false;
                    button6.Enabled = false;
                    board[bestMove.row][bestMove.col] = O;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 2 && bestMove.col == 0 )
                {
                    button7.Text = "O";
                    AI = false;
                    button7.Enabled = false;
                    board[bestMove.row][bestMove.col] = O;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 2 && bestMove.col == 1 )
                {
                    button8.Text = "O";
                    AI = false;
                    button8.Enabled = false;
                    board[bestMove.row][bestMove.col] = O;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 2 && bestMove.col == 2 )
                {
                    button9.Text = "O";
                    AI = false;
                    button9.Enabled = false;
                    board[bestMove.row][bestMove.col] = O;
                    player = true;
                    label6.Text = "tura jucator";
                }

            }
            else if(AI & playerTypeO)
            {
                if (bestMove.row == 0 && bestMove.col == 0 )
                {
                    button1.Text = "X";
                    AI = false;
                    button1.Enabled = false;
                    board[bestMove.row][bestMove.col] = X;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 0 && bestMove.col == 1 )
                {
                    button2.Text = "X";
                    AI = false;
                    button2.Enabled = false;
                    board[bestMove.row][bestMove.col] = X;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 0 && bestMove.col == 2 )
                {
                    button3.Text = "X";
                    AI = false;
                    button3.Enabled = false;
                    board[bestMove.row][bestMove.col] = X;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 1 && bestMove.col == 0 )
                {
                    button4.Text = "X";
                    AI = false;
                    button4.Enabled = false;
                    board[bestMove.row][bestMove.col] = X;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 1 && bestMove.col == 1 )
                {
                    button5.Text = "X";
                    AI = false;
                    button5.Enabled = false;
                    board[bestMove.row][bestMove.col] = X;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 1 && bestMove.col == 2 )
                {
                    button6.Text = "X";
                    AI = false;
                    button6.Enabled = false;
                    board[bestMove.row][bestMove.col] = X;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 2 && bestMove.col == 0 )
                {
                    button7.Text = "X";
                    AI = false;
                    button7.Enabled = false;
                    board[bestMove.row][bestMove.col] = X;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 2 && bestMove.col == 1)
                {
                    button8.Text = "X";
                    AI = false;
                    button8.Enabled = false;
                    board[bestMove.row][bestMove.col] = X;
                    player = true;
                    label6.Text = "tura jucator";
                }
                if (bestMove.row == 2 && bestMove.col == 2)
                {
                    button9.Text = "X";
                    AI = false;
                    button9.Enabled = false;
                    board[bestMove.row][bestMove.col] = X;
                    player = true;
                    label6.Text = "tura jucator";
                }
            }
            draw++;
        }

        

       
    }
}
