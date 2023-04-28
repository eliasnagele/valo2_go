namespace SWP_Jahresprojekt
{
    partial class skins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(skins));
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lb_Skins = new System.Windows.Forms.Label();
            this.dtv_skins = new System.Windows.Forms.DataGridView();
            this.pb_glass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_skins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_glass)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.Color.Orange;
            this.bt_home.Location = new System.Drawing.Point(12, 41);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(53, 23);
            this.bt_home.TabIndex = 0;
            this.bt_home.Text = "Home";
            this.bt_home.UseVisualStyleBackColor = false;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.Red;
            this.bt_exit.Location = new System.Drawing.Point(12, 12);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(53, 23);
            this.bt_exit.TabIndex = 2;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // tb_search
            // 
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_search.Location = new System.Drawing.Point(651, 12);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(137, 20);
            this.tb_search.TabIndex = 3;
            // 
            // lb_Skins
            // 
            this.lb_Skins.AutoSize = true;
            this.lb_Skins.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Skins.ForeColor = System.Drawing.Color.White;
            this.lb_Skins.Location = new System.Drawing.Point(336, 9);
            this.lb_Skins.Name = "lb_Skins";
            this.lb_Skins.Size = new System.Drawing.Size(111, 47);
            this.lb_Skins.TabIndex = 6;
            this.lb_Skins.Text = "Skins";
            // 
            // dtv_skins
            // 
            this.dtv_skins.BackgroundColor = System.Drawing.Color.Black;
            this.dtv_skins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_skins.Location = new System.Drawing.Point(121, 70);
            this.dtv_skins.Name = "dtv_skins";
            this.dtv_skins.RowTemplate.Height = 25;
            this.dtv_skins.Size = new System.Drawing.Size(568, 380);
            this.dtv_skins.TabIndex = 7;
            // 
            // pb_glass
            // 
            this.pb_glass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb_glass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_glass.BackgroundImage")));
            this.pb_glass.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_glass.InitialImage")));
            this.pb_glass.Location = new System.Drawing.Point(631, 12);
            this.pb_glass.Name = "pb_glass";
            this.pb_glass.Size = new System.Drawing.Size(21, 20);
            this.pb_glass.TabIndex = 8;
            this.pb_glass.TabStop = false;
            // 
            // skins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_glass);
            this.Controls.Add(this.dtv_skins);
            this.Controls.Add(this.lb_Skins);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_home);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "skins";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "skins";
            this.Load += new System.EventHandler(this.skins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_skins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_glass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_home;
        private Button bt_exit;
        private TextBox tb_search;
        private Label lb_Skins;
        private DataGridView dtv_skins;
        private PictureBox pb_glass;
    }
}