namespace SWP_Jahresprojekt
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
            this.bt_tournament = new System.Windows.Forms.Button();
            this.bt_news = new System.Windows.Forms.Button();
            this.bt_skins = new System.Windows.Forms.Button();
            this.bt_bundles = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.lb_headline = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.bt_EditTables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_tournament
            // 
            this.bt_tournament.BackColor = System.Drawing.Color.Snow;
            this.bt_tournament.FlatAppearance.BorderSize = 0;
            this.bt_tournament.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_tournament.Location = new System.Drawing.Point(32, 165);
            this.bt_tournament.Name = "bt_tournament";
            this.bt_tournament.Size = new System.Drawing.Size(149, 125);
            this.bt_tournament.TabIndex = 0;
            this.bt_tournament.Text = "Turniere";
            this.bt_tournament.UseVisualStyleBackColor = false;
            this.bt_tournament.Click += new System.EventHandler(this.bt_tournament_Click);
            // 
            // bt_news
            // 
            this.bt_news.BackColor = System.Drawing.Color.Snow;
            this.bt_news.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_news.Location = new System.Drawing.Point(226, 165);
            this.bt_news.Name = "bt_news";
            this.bt_news.Size = new System.Drawing.Size(149, 125);
            this.bt_news.TabIndex = 1;
            this.bt_news.Text = "News";
            this.bt_news.UseVisualStyleBackColor = false;
            this.bt_news.Click += new System.EventHandler(this.bt_news_Click);
            // 
            // bt_skins
            // 
            this.bt_skins.BackColor = System.Drawing.Color.Snow;
            this.bt_skins.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_skins.Location = new System.Drawing.Point(615, 165);
            this.bt_skins.Name = "bt_skins";
            this.bt_skins.Size = new System.Drawing.Size(149, 125);
            this.bt_skins.TabIndex = 2;
            this.bt_skins.Text = "Skins";
            this.bt_skins.UseVisualStyleBackColor = false;
            this.bt_skins.Click += new System.EventHandler(this.bt_skins_Click);
            // 
            // bt_bundles
            // 
            this.bt_bundles.BackColor = System.Drawing.Color.Snow;
            this.bt_bundles.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_bundles.Location = new System.Drawing.Point(422, 165);
            this.bt_bundles.Name = "bt_bundles";
            this.bt_bundles.Size = new System.Drawing.Size(149, 125);
            this.bt_bundles.TabIndex = 3;
            this.bt_bundles.Text = "Bundles";
            this.bt_bundles.UseVisualStyleBackColor = false;
            this.bt_bundles.Click += new System.EventHandler(this.bt_bundles_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.Red;
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.Location = new System.Drawing.Point(12, 12);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(46, 23);
            this.bt_exit.TabIndex = 4;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // lb_headline
            // 
            this.lb_headline.AutoSize = true;
            this.lb_headline.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_headline.ForeColor = System.Drawing.Color.White;
            this.lb_headline.Location = new System.Drawing.Point(321, -7);
            this.lb_headline.Name = "lb_headline";
            this.lb_headline.Size = new System.Drawing.Size(159, 47);
            this.lb_headline.TabIndex = 5;
            this.lb_headline.Text = "valo2go";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Snow;
            this.btn_Login.Location = new System.Drawing.Point(713, 12);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(84, 23);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // bt_EditTables
            // 
            this.bt_EditTables.Location = new System.Drawing.Point(713, 411);
            this.bt_EditTables.Name = "bt_EditTables";
            this.bt_EditTables.Size = new System.Drawing.Size(80, 27);
            this.bt_EditTables.TabIndex = 7;
            this.bt_EditTables.Text = "Edit Tables";
            this.bt_EditTables.UseVisualStyleBackColor = true;
            this.bt_EditTables.Click += new System.EventHandler(this.bt_EditTables_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_EditTables);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lb_headline);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_bundles);
            this.Controls.Add(this.bt_skins);
            this.Controls.Add(this.bt_news);
            this.Controls.Add(this.bt_tournament);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.HotPink;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_tournament;
        private Button bt_news;
        private Button bt_skins;
        private Button bt_bundles;
        private Button bt_exit;
        private Label lb_headline;
        private Button btn_Login;
        private Button bt_EditTables;
    }
}