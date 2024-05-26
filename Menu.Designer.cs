namespace TicTacToe
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            btn_inst = new Button();
            btn_score = new Button();
            btn_nav = new Button();
            btn_info = new Button();
            btn_exit = new Button();
            lbl_text = new Label();
            lbl_title = new Label();
            panelb = new Panel();
            btn_clear = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_inst);
            panel1.Controls.Add(btn_score);
            panel1.Controls.Add(btn_nav);
            panel1.Controls.Add(btn_info);
            panel1.Location = new Point(0, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btn_inst
            // 
            btn_inst.Location = new Point(400, 0);
            btn_inst.Name = "btn_inst";
            btn_inst.Size = new Size(200, 39);
            btn_inst.TabIndex = 7;
            btn_inst.Text = "btn_inst";
            btn_inst.UseVisualStyleBackColor = true;
            btn_inst.Click += btn_inst_Click;
            // 
            // btn_score
            // 
            btn_score.Location = new Point(200, 0);
            btn_score.Name = "btn_score";
            btn_score.Size = new Size(200, 39);
            btn_score.TabIndex = 7;
            btn_score.Text = "button6";
            btn_score.UseVisualStyleBackColor = true;
            btn_score.Click += btn_score_Click;
            // 
            // btn_nav
            // 
            btn_nav.Location = new Point(600, 0);
            btn_nav.Name = "btn_nav";
            btn_nav.Size = new Size(200, 39);
            btn_nav.TabIndex = 6;
            btn_nav.Text = "btn_nav";
            btn_nav.UseVisualStyleBackColor = true;
            btn_nav.Click += btn_nav_Click;
            // 
            // btn_info
            // 
            btn_info.Location = new Point(0, 0);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(200, 39);
            btn_info.TabIndex = 1;
            btn_info.Text = "button1";
            btn_info.UseVisualStyleBackColor = true;
            btn_info.Click += button1_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(678, 1);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(120, 39);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "button5";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_text
            // 
            lbl_text.AutoSize = true;
            lbl_text.Location = new Point(12, 152);
            lbl_text.Name = "lbl_text";
            lbl_text.Size = new Size(59, 25);
            lbl_text.TabIndex = 6;
            lbl_text.Text = "label1";
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(12, 105);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(59, 25);
            lbl_title.TabIndex = 7;
            lbl_title.Text = "label1";
            // 
            // panelb
            // 
            panelb.Location = new Point(0, 0);
            panelb.Name = "panelb";
            panelb.Size = new Size(800, 80);
            panelb.TabIndex = 8;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(667, 88);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(131, 629);
            btn_clear.TabIndex = 9;
            btn_clear.Text = "btn_clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += button1_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 727);
            Controls.Add(btn_clear);
            Controls.Add(lbl_title);
            Controls.Add(lbl_text);
            Controls.Add(btn_exit);
            Controls.Add(panel1);
            Controls.Add(panelb);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_info;
        private Button btn_exit;
        private Button btn_inst;
        private Button btn_score;
        private Button btn_nav;
        private Label lbl_text;
        private Label lbl_title;
        private Panel panelb;
        private Button btn_clear;
    }
}