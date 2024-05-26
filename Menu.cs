using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicTacToe
{
    /// <summary>
    /// Enum made in order to initialize the form.
    /// </summary>
    public enum menuType
    {
        info,
        score,
        nav,
        inst
    }

    public partial class Menu : Form
    {
        string clickedColor = "#F6F6F6";
        string text = string.Empty;
        private FileManager fileManager;

        /// <summary>
        /// Constructor to initliaze the form.
        /// </summary>
        /// <param name="type">Which element is the start one.</param>
        /// <param name="text">Text for score.</param>
        /// <param name="file">Path of the file.</param>
        public Menu(menuType type, string text, string file)
        {
            InitializeComponent();
            GUIinit();
            this.text = text;
            fileManager = new FileManager(file);

            if (type == menuType.info)
            {
                btnInfo();
            }
            else if (type == menuType.score)
            {
                btnScore();
            }
            else if (type == menuType.nav)
            {
                btnNav();
            }
            else
            {
                btnInst();
            }


        }

        /// <summary>
        /// Initalize GUI: form, labels, colours etc.
        /// </summary>
        private void GUIinit()
        {
            this.Text = "Tic Tac Toe (support)";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#E6E6E6");
            panel1.BackColor = ColorTranslator.FromHtml("#E6E6E6");
            panelb.BackColor = ColorTranslator.FromHtml(clickedColor);
            btn_exit.BackColor = ColorTranslator.FromHtml(clickedColor);
            btn_exit.Text = "Exit";
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_info.Text = "Information";
            btn_inst.Text = "Instructions";
            btn_nav.Text = "Navigation";
            btn_score.Text = "Score";

            btn_clear.Text = "clear";
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.FlatAppearance.BorderSize = 0;




        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Displays infomation about the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            btnInfo();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Displays instructions of the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_inst_Click(object sender, EventArgs e)
        {
            btnInst();
        }

        /// <summary>
        /// Displays navigation on the side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nav_Click(object sender, EventArgs e)
        {
            btnNav();
        }

        /// <summary>
        /// Form exits when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Gives functionality for ts button: text displayed, colour of the button clicked 
        /// and visibility of a button 'clear'.
        /// </summary>
        private void btnScore()
        {
            BTNinit();
            btn_score.BackColor = ColorTranslator.FromHtml(clickedColor);
            btn_clear.Visible = true;




            lbl_title.Text = "Scores:";
            lbl_text.Text = text;
            //open file
            //write file here
        }

        /// <summary>
        /// Gives functionality for ts button: text displayed, colour of the button clicked 
        /// and visibility of a button 'clear'.
        /// </summary>
        private void btnInfo()
        {
            BTNinit();
            btn_clear.Visible = false;
            lbl_text.Text = "Tic Tac Toe, also known as Noughts and Crosses\n" +
                "or Xs and Os, is a classic paper-and-pencil game enjoyed\n" +
                "by people of all ages worldwide. Players typically take\n" +
                "turns marking empty cells in a 3x3 grid with their respective\n" +
                "symbols, either \"X\" or \"O\", aiming to create a row,\n" +
                "column, or diagonal of their symbols to win the game. Despite\n" +
                "its simple rules, Tic Tac Toe offers strategic depth and has\n" +
                "been studied extensively in game theory. Its origins trace\n" +
                "back to ancient civilizations, with variations of the game\n" +
                "found in different cultures throughout history.\nToday, Tic Tac Toe " +
                "remains a popular pastime, often adapted into\ndigital formats" +
                "and included in educational curricula to teach\nlogical thinking" +
                " and problem-solving skills.\n\n";


            lbl_title.Text = "What is tic tac toe game?";
            btn_info.BackColor = ColorTranslator.FromHtml(clickedColor);


        }

        /// <summary>
        /// Gives functionality for ts button: text displayed, colour of the button clicked 
        /// and visibility of a button 'clear'.
        /// </summary>
        private void btnNav()
        {
            btn_clear.Visible = false;
            BTNinit();
            btn_nav.BackColor = ColorTranslator.FromHtml(clickedColor);
            lbl_text.Text =
                "Start a new game by clicking 'New game'.\n\n" +
                "Exit game by clicking 'Exit' and then OK.\n\n" +
                "See information about the game by clicking\n" +
                "About and then Information or choose 'Information'\n" +
                "from the panel above.\n\n" +
                "See instructions of the game by clicking\n" +
                "'About' and then 'Instructions' or choose 'Instructions'\n" +
                "from the panel above.\n\n" +
                "";
            lbl_title.Text = "Navigation";



        }

        /// <summary>
        /// Gives functionality for ts button: text displayed, colour of the button clicked 
        /// and visibility of a button 'clear'.
        /// </summary>
        private void btnInst()
        {
            BTNinit();
            btn_clear.Visible = false;
            btn_inst.BackColor = ColorTranslator.FromHtml(clickedColor);
            lbl_title.Text = "Instructions:";

            lbl_text.Text = "Tic Tac Toe is a classic game where two players take turns\n" +
                "marking empty cells in a 3x3 grid with x or o symbols,\n" +
                "aiming to create a row, column, or diagonal of their symbol\n" +
                "to win. The game ends in a draw if the\ngrid is filled without a winner.\n";


        }

        /// <summary>
        /// Initialize buttons and sets global font.
        /// </summary>
        private void BTNinit()
        {
            Extension.SetGlobalFont(this.Controls, new Font("Cascadia Code", 10, FontStyle.Regular));
            btn_nav.BackColor = ColorTranslator.FromHtml("#E6E6E6");
            btn_info.BackColor = ColorTranslator.FromHtml("#E6E6E6");
            btn_score.BackColor = ColorTranslator.FromHtml("#E6E6E6");
            btn_inst.BackColor = ColorTranslator.FromHtml("#E6E6E6");
            btn_info.FlatStyle = FlatStyle.Flat;
            btn_inst.FlatStyle = FlatStyle.Flat;
            btn_nav.FlatStyle = FlatStyle.Flat;
            btn_score.FlatStyle = FlatStyle.Flat;
            btn_score.FlatAppearance.BorderSize = 0;
            btn_nav.FlatAppearance.BorderSize = 0;
            btn_inst.FlatAppearance.BorderSize = 0;
            btn_info.FlatAppearance.BorderSize = 0;

        }

        /// <summary>
        /// Gives functionality for ts button: text displayed, colour of the button clicked 
        /// and visibility of a button 'clear'.
        /// </summary>
        private void btn_score_Click(object sender, EventArgs e)
        {
            btnScore();
        }

        /// <summary>
        /// Sets button 'clear' to the option of clearing files with provided to the class filepath.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            fileManager.Clear();
            lbl_text.Text = fileManager.Open();
            
            
            
            
        }
    }



}
