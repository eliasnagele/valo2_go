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
            bt_home = new Button();
            bt_exit = new Button();
            tb_search = new TextBox();
            lb_Skins = new Label();
            dtv_skins = new DataGridView();
            pb_glass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtv_skins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_glass).BeginInit();
            SuspendLayout();
            // 
            // bt_home
            // 
            bt_home.BackColor = Color.Orange;
            bt_home.Location = new Point(12, 41);
            bt_home.Name = "bt_home";
            bt_home.Size = new Size(53, 23);
            bt_home.TabIndex = 0;
            bt_home.Text = "Home";
            bt_home.UseVisualStyleBackColor = false;
            bt_home.Click += bt_home_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.Red;
            bt_exit.Location = new Point(12, 12);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(53, 23);
            bt_exit.TabIndex = 2;
            bt_exit.Text = "Exit";
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // tb_search
            // 
            tb_search.BorderStyle = BorderStyle.None;
            tb_search.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tb_search.Location = new Point(651, 12);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(137, 20);
            tb_search.TabIndex = 3;
            // 
            // lb_Skins
            // 
            lb_Skins.AutoSize = true;
            lb_Skins.Font = new Font("Segoe UI Black", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Skins.ForeColor = Color.White;
            lb_Skins.Location = new Point(336, 9);
            lb_Skins.Name = "lb_Skins";
            lb_Skins.Size = new Size(111, 47);
            lb_Skins.TabIndex = 6;
            lb_Skins.Text = "Skins";
            // 
            // dtv_skins
            // 
            dtv_skins.BackgroundColor = Color.Black;
            dtv_skins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtv_skins.Location = new Point(121, 70);
            dtv_skins.Name = "dtv_skins";
            dtv_skins.ReadOnly = true;
            dtv_skins.RowTemplate.Height = 25;
            dtv_skins.Size = new Size(568, 380);
            dtv_skins.TabIndex = 7;
            // 
            // pb_glass
            // 
            pb_glass.BackColor = SystemColors.ControlLightLight;
            pb_glass.BackgroundImage = (Image)resources.GetObject("pb_glass.BackgroundImage");
            pb_glass.InitialImage = (Image)resources.GetObject("pb_glass.InitialImage");
            pb_glass.Location = new Point(631, 12);
            pb_glass.Name = "pb_glass";
            pb_glass.Size = new Size(21, 20);
            pb_glass.TabIndex = 8;
            pb_glass.TabStop = false;
            // 
            // skins
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pb_glass);
            Controls.Add(dtv_skins);
            Controls.Add(lb_Skins);
            Controls.Add(tb_search);
            Controls.Add(bt_exit);
            Controls.Add(bt_home);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "skins";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "skins";
            ((System.ComponentModel.ISupportInitialize)dtv_skins).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_glass).EndInit();
            ResumeLayout(false);
            PerformLayout();
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