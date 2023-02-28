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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_home
            // 
            this.bt_home.Location = new System.Drawing.Point(16, 31);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(75, 23);
            this.bt_home.TabIndex = 0;
            this.bt_home.Text = "Home";
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(16, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 1;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // lb_headline
            // 
            this.lb_headline.AutoSize = true;
            this.lb_headline.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_headline.Location = new System.Drawing.Point(330, 22);
            this.lb_headline.Name = "lb_headline";
            this.lb_headline.Size = new System.Drawing.Size(153, 32);
            this.lb_headline.TabIndex = 6;
            this.lb_headline.Text = "Tournaments";
            // 
            // btn_newtournament1
            // 
            this.btn_newtournament1.Location = new System.Drawing.Point(16, 69);
            this.btn_newtournament1.Name = "btn_newtournament1";
            this.btn_newtournament1.Size = new System.Drawing.Size(355, 139);
            this.btn_newtournament1.TabIndex = 7;
            this.btn_newtournament1.UseVisualStyleBackColor = true;
            this.btn_newtournament1.Click += new System.EventHandler(this.btn_newtournament1_Click);
            // 
            // btn_newtournament2
            // 
            this.btn_newtournament2.Location = new System.Drawing.Point(433, 69);
            this.btn_newtournament2.Name = "btn_newtournament2";
            this.btn_newtournament2.Size = new System.Drawing.Size(355, 139);
            this.btn_newtournament2.TabIndex = 8;
            this.btn_newtournament2.UseVisualStyleBackColor = true;
            this.btn_newtournament2.Click += new System.EventHandler(this.btn_newtournament2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(772, 189);
            this.dataGridView1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(651, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 12;
            // 
            // tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_newtournament2);
            this.Controls.Add(this.btn_newtournament1);
            this.Controls.Add(this.lb_headline);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_home);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "tournament";
            this.ShowIcon = false;
            this.Text = "tournament";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}