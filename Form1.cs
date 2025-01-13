using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Diagnostics;
using System.IO;
using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Button[,] buttons;
        private Game game;
        private Players currentPlayer;
        private ToolTip toolTip;
        private FileManager fileManager;
        private string scoreText = string.Empty;
        private int score;

        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ScoreTicTacToe.txt");

       // string path = Application.StartupPath + "\\ScoreTicTacToe.txt";
        public Form1()
        {
            InitializeComponent();
            
            GUIinit();
      
            game = new Game();
            fileManager = new FileManager(path);
            
            ResetGame();
            ReadFile();




        }


        private void ToolTipInnit()
        {

            toolTip = new ToolTip();
            // properties for the tooltip
            toolTip.AutoPopDelay = 2000; // 2 seconds
            toolTip.InitialDelay = 2000; // 1 second
            toolTip.ReshowDelay = 3000; // 3 second
        }

        /// <summary>
        /// Initializes GUI.
        /// </summary>
        private void GUIinit()
        {

            initBTN();

            ClearButtons();
            // Assuming you have a PictureBox control named pictureBox1

            this.Text = "Tic Tac Toe";
            //btn00.Image = Properties.Resources.kotek;
            // Cascadia Code, 16pt
            Extension.SetGlobalFont(this.Controls, new Font("Cascadia Code", 16, FontStyle.Regular));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormBorderStyle = FormBorderStyle.None;

            lbl_turn.Text = currentPlayer.ToString() + "'s turn!";

            ToolTipInnit();

       



        }


        /// <summary>
        /// Initalizes buttons (appearance) and events (mouse hover and click of any of them).
        /// Also, sets them as an array of buttons.
        /// </summary>
        private void initBTN()
        {
            buttons = new Button[,]
           {
                { btn00, btn01, btn02 },
                { btn10, btn11, btn12 },
                { btn20, btn21, btn22 }
           };

            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Click += Button_Click;
                button.MouseHover += button_MouseHover;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }

            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_newGame.FlatStyle = FlatStyle.Flat;
            btn_newGame.FlatAppearance.BorderSize = 0;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_newGame.Text = "Start again";
            btn_exit.Text = "Exit";



        }






        /// <summary>
        /// Clears all of the buttons: enables them after being disabled while playing,
        /// resets their text to "".
        /// </summary>
        private void ClearButtons()
        {
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;


            }


        }


        /// <summary>
        /// Disables all buttons. Needed when there is a win and there are still empty spaces.
        /// </summary>
        private void DisableButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false;


            }


        }


        /// <summary>
        /// Event handler for hovering with a mouse over buttons of the board.
        /// It says small instructions what to do.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_MouseHover(object sender, EventArgs e)
        {

            Button hoveredButton = sender as Button;
            if (hoveredButton.Enabled == true)
            {
                toolTip.Show("Click to put yout sign.", hoveredButton);

            }
            else if (hoveredButton.Enabled == false)
            {
                toolTip.Show("Choose an empty place.", hoveredButton);
            }


        }

        private void btn00_Click(object sender, EventArgs e)
        {

        }
        private void btn10_Click(object sender, EventArgs e)
        {

        }
        private void btn20_Click(object sender, EventArgs e)
        {

        }
        private void btn21_Click(object sender, EventArgs e)
        {

        }
        private void btn11_Click(object sender, EventArgs e)
        {

        }
        private void btn01_Click(object sender, EventArgs e)
        {

        }
        private void btn22_Click(object sender, EventArgs e)
        {

        }
        private void btn12_Click(object sender, EventArgs e)
        {

        }
        private void btn02_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Event handler while clicking any of the buttons of the board.
        /// Checks for win or full board, passes information to a file and to game class.
        /// Gives the proper message to the players uing message boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Players donePlayer = currentPlayer;
            currentPlayer = (currentPlayer == Players.playerOne) ? Players.playerTwo : Players.playerOne;



            //finds a clicked button
            if (clickedButton != null)
            {
                int row = -1, col = -1;
                for (int i = 0; i < 3; i++)
                {
                    for (int n = 0; n < 3; n++)
                    {
                        if (buttons[i, n] == clickedButton)
                        {
                            row = i;
                            col = n;
                            break; //goes out when founf
                        }
                    }
                    //if (row != -1) break;
                }

                if (row >= 0 && col >= 0)
                {
                    //marks a button with the proper sign
                    buttons[row, col].Text = game.Move(donePlayer, row, col).ToString();//(currentPlayer == Players.playerOne) ? "x":"o";
                    //disables the button from choice
                    buttons[row, col].Enabled = false;
                    //game.Move(currentPlayer, row, col); //makes the move

                    //check for win or full board
                    if (game.CheckWin())
                    {
                        WriteToFile(donePlayer);
                        ReadFile();

                        MessageBox.Show("Player " + donePlayer.ToString() + " won\n Score: " + game.CalculateScore(donePlayer), "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisableButtons();

                        //change text 
                        lbl_turn.Text = "Player " + donePlayer.ToString() + " won!";
                        return;


                    }
                    else if (game.CheckFull())
                    {
                        MessageBox.Show("Game over!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisableButtons();
                        //change text 
                        lbl_turn.Text = "No empty places.";
                        return;

                    }

                    //change text to the other player
                    lbl_turn.Text = currentPlayer.ToString() + "'s turn!";




                }

            }


        }//method









        /// <summary>
        /// Clears game for the new round. Sets player to Players.playerOne,
        /// initalize new game.
        /// </summary>
        private void ResetGame()
        {
   
            ClearButtons();
            currentPlayer = Players.playerOne;
            lbl_turn.Text = currentPlayer.ToString() + "'s turn!";
            game = new Game();
            ReadFile();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button app exit yes/no.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
            }



        }

        /// <summary>
        /// Button initializes a new game calling ResetGame() method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_newGame_Click(object sender, EventArgs e)
        {

            ResetGame();

        }

        /// <summary>
        /// Opens menu form on information tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savedScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(menuType.info, scoreText, path);
            menu.Show();
            
        }

        /// <summary>
        /// Opens menu form on score tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_score_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(menuType.score, scoreText, path);
            menu.Show();
            
        }

        /// <summary>
        /// Opens menu form on instructions tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_inst_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(menuType.inst, scoreText, path);
            menu.Show();
            
        }

        /// <summary>
        /// Opens menu form on navigation tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_nav_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(menuType.nav, scoreText, path);
            menu.Show();
            
        }


        /// <summary>
        /// Reads/opens the file.
        /// </summary>
        private void ReadFile()
        {
            scoreText = fileManager.Open();
        }
        
        /// <summary>
        /// Writes to file generated score with the winner .
        /// </summary>
        /// <param name="winner">Type Players</param>
        private void WriteToFile(Players winner)
        {
            int score = game.CalculateScore(winner);
            string line = score.ToString() + " - " + winner.ToString();
            fileManager.WriteLine(line);
            
        }


    }//class
}//namespace
