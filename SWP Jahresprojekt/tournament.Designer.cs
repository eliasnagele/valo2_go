namespace SWP_Jahresprojekt
{
    partial class tournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tournament));
            bt_home = new Button();
            bt_exit = new Button();
            lb_headline = new Label();
            btn_newtournament1 = new Button();
            btn_newtournament2 = new Button();
            dtv_tournament = new DataGridView();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtv_tournament).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bt_home
            // 
            bt_home.BackColor = Color.Orange;
            bt_home.Location = new Point(16, 31);
            bt_home.Name = "bt_home";
            bt_home.Size = new Size(52, 23);
            bt_home.TabIndex = 0;
            bt_home.Text = "Home";
            bt_home.UseVisualStyleBackColor = false;
            bt_home.Click += bt_home_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.Red;
            bt_exit.ForeColor = SystemColors.ControlText;
            bt_exit.Location = new Point(16, 5);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(52, 23);
            bt_exit.TabIndex = 1;
            bt_exit.Text = "Exit";
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // lb_headline
            // 
            lb_headline.AutoSize = true;
            lb_headline.BackColor = Color.Transparent;
            lb_headline.Font = new Font("Segoe UI Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lb_headline.ForeColor = Color.White;
            lb_headline.Location = new Point(293, 6);
            lb_headline.Name = "lb_headline";
            lb_headline.Size = new Size(228, 45);
            lb_headline.TabIndex = 6;
            lb_headline.Text = "Tournaments";
            // 
            // btn_newtournament1
            // 
            btn_newtournament1.BackColor = Color.Snow;
            btn_newtournament1.Location = new Point(16, 69);
            btn_newtournament1.Name = "btn_newtournament1";
            btn_newtournament1.Size = new Size(366, 139);
            btn_newtournament1.TabIndex = 7;
            btn_newtournament1.UseVisualStyleBackColor = false;
            btn_newtournament1.Click += btn_newtournament1_Click;
            // 
            // btn_newtournament2
            // 
            btn_newtournament2.BackColor = Color.Snow;
            btn_newtournament2.Location = new Point(442, 69);
            btn_newtournament2.Name = "btn_newtournament2";
            btn_newtournament2.Size = new Size(380, 139);
            btn_newtournament2.TabIndex = 8;
            btn_newtournament2.UseVisualStyleBackColor = false;
            btn_newtournament2.Click += btn_newtournament2_Click;
            // 
            // dtv_tournament
            // 
            dtv_tournament.BackgroundColor = Color.Black;
            dtv_tournament.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtv_tournament.Location = new Point(16, 237);
            dtv_tournament.Name = "dtv_tournament";
            dtv_tournament.ReadOnly = true;
            dtv_tournament.RowTemplate.Height = 25;
            dtv_tournament.Size = new Size(806, 189);
            dtv_tournament.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(664, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 20);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(685, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 20);
            textBox1.TabIndex = 12;
            // 
            // tournament
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(834, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(dtv_tournament);
            Controls.Add(btn_newtournament2);
            Controls.Add(btn_newtournament1);
            Controls.Add(lb_headline);
            Controls.Add(bt_exit);
            Controls.Add(bt_home);
            MaximizeBox = false;
            MaximumSize = new Size(850, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "tournament";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tournament";
            ((System.ComponentModel.ISupportInitialize)dtv_tournament).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_home;
        private Button bt_exit;
        private Label lb_headline;
        private Button btn_newtournament1;
        private Button btn_newtournament2;
        private DataGridView dtv_tournament;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}