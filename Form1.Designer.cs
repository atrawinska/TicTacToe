namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn00 = new Button();
            btn10 = new Button();
            btn20 = new Button();
            btn21 = new Button();
            btn11 = new Button();
            btn01 = new Button();
            btn22 = new Button();
            btn12 = new Button();
            btn02 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            btn_newGame = new Button();
            btn_exit = new Button();
            lbl_turn = new Label();
            menuStrip1 = new MenuStrip();
            menu_about = new ToolStripMenuItem();
            menu_info = new ToolStripMenuItem();
            menu_score = new ToolStripMenuItem();
            menu_help = new ToolStripMenuItem();
            menu_inst = new ToolStripMenuItem();
            menu_nav = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn00
            // 
            btn00.Location = new Point(161, 138);
            btn00.Name = "btn00";
            btn00.Size = new Size(145, 145);
            btn00.TabIndex = 0;
            btn00.Text = "button1";
            btn00.UseVisualStyleBackColor = true;
            btn00.Click += btn00_Click;
            // 
            // btn10
            // 
            btn10.Location = new Point(312, 138);
            btn10.Name = "btn10";
            btn10.Size = new Size(145, 145);
            btn10.TabIndex = 1;
            btn10.Text = "button2";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn10_Click;
            // 
            // btn20
            // 
            btn20.Location = new Point(463, 138);
            btn20.Name = "btn20";
            btn20.Size = new Size(145, 145);
            btn20.TabIndex = 2;
            btn20.Text = "button3";
            btn20.UseVisualStyleBackColor = true;
            btn20.Click += btn20_Click;
            // 
            // btn21
            // 
            btn21.Location = new Point(463, 289);
            btn21.Name = "btn21";
            btn21.Size = new Size(145, 145);
            btn21.TabIndex = 5;
            btn21.Text = "button4";
            btn21.UseVisualStyleBackColor = true;
            btn21.Click += btn21_Click;
            // 
            // btn11
            // 
            btn11.Location = new Point(312, 289);
            btn11.Name = "btn11";
            btn11.Size = new Size(145, 145);
            btn11.TabIndex = 4;
            btn11.Text = "button5";
            btn11.UseVisualStyleBackColor = true;
            btn11.Click += btn11_Click;
            // 
            // btn01
            // 
            btn01.Location = new Point(161, 289);
            btn01.Name = "btn01";
            btn01.Size = new Size(145, 145);
            btn01.TabIndex = 3;
            btn01.Text = "button6";
            btn01.UseVisualStyleBackColor = true;
            btn01.Click += btn01_Click;
            // 
            // btn22
            // 
            btn22.Location = new Point(463, 440);
            btn22.Name = "btn22";
            btn22.Size = new Size(145, 145);
            btn22.TabIndex = 8;
            btn22.Text = "button7";
            btn22.UseVisualStyleBackColor = true;
            btn22.Click += btn22_Click;
            // 
            // btn12
            // 
            btn12.Location = new Point(312, 440);
            btn12.Name = "btn12";
            btn12.Size = new Size(145, 145);
            btn12.TabIndex = 7;
            btn12.Text = "button8";
            btn12.UseVisualStyleBackColor = true;
            btn12.Click += btn12_Click;
            // 
            // btn02
            // 
            btn02.Location = new Point(161, 440);
            btn02.Name = "btn02";
            btn02.Size = new Size(145, 145);
            btn02.TabIndex = 6;
            btn02.Text = "button9";
            btn02.UseVisualStyleBackColor = true;
            btn02.Click += btn02_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(161, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 5);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(306, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 447);
            panel3.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.ForeColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(457, 138);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 447);
            panel5.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.ForeColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(161, 435);
            panel6.Name = "panel6";
            panel6.Size = new Size(447, 5);
            panel6.TabIndex = 10;
            // 
            // btn_newGame
            // 
            btn_newGame.Location = new Point(-8, 622);
            btn_newGame.Name = "btn_newGame";
            btn_newGame.Size = new Size(392, 93);
            btn_newGame.TabIndex = 11;
            btn_newGame.Text = "button9";
            btn_newGame.UseVisualStyleBackColor = true;
            btn_newGame.Click += btn_newGame_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Cascadia Code", 16F);
            btn_exit.Location = new Point(385, 622);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(422, 93);
            btn_exit.TabIndex = 12;
            btn_exit.Text = "button9";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_turn
            // 
            lbl_turn.AutoSize = true;
            lbl_turn.Location = new Point(216, 78);
            lbl_turn.Name = "lbl_turn";
            lbl_turn.Size = new Size(59, 25);
            lbl_turn.TabIndex = 14;
            lbl_turn.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_about, menu_help });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_about
            // 
            menu_about.DropDownItems.AddRange(new ToolStripItem[] { menu_info, menu_score });
            menu_about.Name = "menu_about";
            menu_about.Size = new Size(78, 29);
            menu_about.Text = "About";
            // 
            // menu_info
            // 
            menu_info.Name = "menu_info";
            menu_info.Size = new Size(270, 34);
            menu_info.Text = "Information";
            menu_info.Click += savedScoresToolStripMenuItem_Click;
            // 
            // menu_score
            // 
            menu_score.Name = "menu_score";
            menu_score.Size = new Size(270, 34);
            menu_score.Text = "Score";
            menu_score.Click += menu_score_Click;
            // 
            // menu_help
            // 
            menu_help.DropDownItems.AddRange(new ToolStripItem[] { menu_inst, menu_nav });
            menu_help.Name = "menu_help";
            menu_help.Size = new Size(65, 29);
            menu_help.Text = "Help";
            // 
            // menu_inst
            // 
            menu_inst.Name = "menu_inst";
            menu_inst.Size = new Size(206, 34);
            menu_inst.Text = "Instructions";
            menu_inst.Click += menu_inst_Click;
            // 
            // menu_nav
            // 
            menu_nav.Name = "menu_nav";
            menu_nav.Size = new Size(206, 34);
            menu_nav.Text = "Navigation";
            menu_nav.Click += menu_nav_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 727);
            Controls.Add(lbl_turn);
            Controls.Add(btn_exit);
            Controls.Add(btn_newGame);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btn22);
            Controls.Add(btn12);
            Controls.Add(btn02);
            Controls.Add(btn21);
            Controls.Add(btn11);
            Controls.Add(btn01);
            Controls.Add(btn20);
            Controls.Add(btn10);
            Controls.Add(btn00);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "p";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn00;
        private Button btn10;
        private Button btn20;
        private Button btn21;
        private Button btn11;
        private Button btn01;
        private Button btn22;
        private Button btn12;
        private Button button9;
        private Button btn02;
        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Button btn_newGame;
        private Button btn_exit;
        private Label lbl_turn;
        private MenuStrip menuStrip1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem menu_about;
        private ToolStripMenuItem menu_help;
        private ToolStripMenuItem menu_info;
        private ToolStripMenuItem menu_inst;
        private ToolStripMenuItem menu_nav;
        private ToolStripMenuItem menu_score;
    }
}
