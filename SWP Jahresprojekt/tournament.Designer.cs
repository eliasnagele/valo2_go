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
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.lb_headline = new System.Windows.Forms.Label();
            this.btn_newtournament1 = new System.Windows.Forms.Button();
            this.btn_newtournament2 = new System.Windows.Forms.Button();
            this.dtv_tournament = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_tournament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.Color.Orange;
            this.bt_home.Location = new System.Drawing.Point(16, 31);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(52, 23);
            this.bt_home.TabIndex = 0;
            this.bt_home.Text = "Home";
            this.bt_home.UseVisualStyleBackColor = false;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.Red;
            this.bt_exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_exit.Location = new System.Drawing.Point(16, 5);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(52, 23);
            this.bt_exit.TabIndex = 1;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // lb_headline
            // 
            this.lb_headline.AutoSize = true;
            this.lb_headline.BackColor = System.Drawing.Color.Transparent;
            this.lb_headline.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_headline.ForeColor = System.Drawing.Color.White;
            this.lb_headline.Location = new System.Drawing.Point(291, 5);
            this.lb_headline.Name = "lb_headline";
            this.lb_headline.Size = new System.Drawing.Size(228, 45);
            this.lb_headline.TabIndex = 6;
            this.lb_headline.Text = "Tournaments";
            // 
            // btn_newtournament1
            // 
            this.btn_newtournament1.Location = new System.Drawing.Point(16, 69);
            this.btn_newtournament1.Name = "btn_newtournament1";
            this.btn_newtournament1.Size = new System.Drawing.Size(366, 139);
            this.btn_newtournament1.TabIndex = 7;
            this.btn_newtournament1.UseVisualStyleBackColor = true;
            this.btn_newtournament1.Click += new System.EventHandler(this.btn_newtournament1_Click);
            // 
            // btn_newtournament2
            // 
            this.btn_newtournament2.Location = new System.Drawing.Point(442, 69);
            this.btn_newtournament2.Name = "btn_newtournament2";
            this.btn_newtournament2.Size = new System.Drawing.Size(380, 139);
            this.btn_newtournament2.TabIndex = 8;
            this.btn_newtournament2.UseVisualStyleBackColor = true;
            this.btn_newtournament2.Click += new System.EventHandler(this.btn_newtournament2_Click);
            // 
            // dtv_tournament
            // 
            this.dtv_tournament.BackgroundColor = System.Drawing.Color.Black;
            this.dtv_tournament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_tournament.Location = new System.Drawing.Point(16, 237);
            this.dtv_tournament.Name = "dtv_tournament";
            this.dtv_tournament.RowTemplate.Height = 25;
            this.dtv_tournament.Size = new System.Drawing.Size(806, 189);
            this.dtv_tournament.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(685, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 12;
            // 
            // tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtv_tournament);
            this.Controls.Add(this.btn_newtournament2);
            this.Controls.Add(this.btn_newtournament1);
            this.Controls.Add(this.lb_headline);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_home);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "tournament";
            this.ShowIcon = false;
            this.Text = "tournament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtv_tournament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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