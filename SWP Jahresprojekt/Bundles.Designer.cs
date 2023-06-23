namespace SWP_Jahresprojekt
{
    partial class Bundles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bundles));
            bt_home = new Button();
            bt_exit = new Button();
            lb_bundle = new Label();
            pb_glass = new PictureBox();
            tb_search = new TextBox();
            bt_Bundle1 = new Button();
            bt_Bundle2 = new Button();
            dgv_bundles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pb_glass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_bundles).BeginInit();
            SuspendLayout();
            // 
            // bt_home
            // 
            bt_home.BackColor = Color.Orange;
            bt_home.Location = new Point(12, 35);
            bt_home.Name = "bt_home";
            bt_home.Size = new Size(49, 25);
            bt_home.TabIndex = 0;
            bt_home.Text = "Home";
            bt_home.UseVisualStyleBackColor = false;
            bt_home.Click += bt_home_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.Red;
            bt_exit.Location = new Point(12, 9);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(49, 23);
            bt_exit.TabIndex = 2;
            bt_exit.Text = "Exit";
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // lb_bundle
            // 
            lb_bundle.AutoSize = true;
            lb_bundle.Font = new Font("Segoe UI Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lb_bundle.ForeColor = Color.White;
            lb_bundle.Location = new Point(327, 25);
            lb_bundle.Name = "lb_bundle";
            lb_bundle.Size = new Size(146, 45);
            lb_bundle.TabIndex = 6;
            lb_bundle.Text = "Bundles";
            // 
            // pb_glass
            // 
            pb_glass.BackColor = SystemColors.ControlLightLight;
            pb_glass.BackgroundImage = (Image)resources.GetObject("pb_glass.BackgroundImage");
            pb_glass.InitialImage = (Image)resources.GetObject("pb_glass.InitialImage");
            pb_glass.Location = new Point(630, 12);
            pb_glass.Name = "pb_glass";
            pb_glass.Size = new Size(21, 20);
            pb_glass.TabIndex = 16;
            pb_glass.TabStop = false;
            // 
            // tb_search
            // 
            tb_search.BorderStyle = BorderStyle.None;
            tb_search.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tb_search.Location = new Point(651, 12);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(137, 20);
            tb_search.TabIndex = 15;
            // 
            // bt_Bundle1
            // 
            bt_Bundle1.BackColor = Color.Snow;
            bt_Bundle1.Location = new Point(12, 87);
            bt_Bundle1.Name = "bt_Bundle1";
            bt_Bundle1.Size = new Size(367, 182);
            bt_Bundle1.TabIndex = 17;
            bt_Bundle1.UseVisualStyleBackColor = false;
            bt_Bundle1.Click += bt_Bundle1_Click;
            // 
            // bt_Bundle2
            // 
            bt_Bundle2.BackColor = Color.Snow;
            bt_Bundle2.Location = new Point(421, 87);
            bt_Bundle2.Name = "bt_Bundle2";
            bt_Bundle2.Size = new Size(367, 182);
            bt_Bundle2.TabIndex = 18;
            bt_Bundle2.UseVisualStyleBackColor = false;
            bt_Bundle2.Click += bt_Bundle2_Click;
            // 
            // dgv_bundles
            // 
            dgv_bundles.BackgroundColor = Color.Black;
            dgv_bundles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_bundles.Location = new Point(12, 279);
            dgv_bundles.Name = "dgv_bundles";
            dgv_bundles.ReadOnly = true;
            dgv_bundles.RowTemplate.Height = 25;
            dgv_bundles.Size = new Size(776, 159);
            dgv_bundles.TabIndex = 19;
            // 
            // Bundles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_bundles);
            Controls.Add(bt_Bundle2);
            Controls.Add(bt_Bundle1);
            Controls.Add(pb_glass);
            Controls.Add(tb_search);
            Controls.Add(lb_bundle);
            Controls.Add(bt_exit);
            Controls.Add(bt_home);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "Bundles";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bundles";
            ((System.ComponentModel.ISupportInitialize)pb_glass).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_bundles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_home;
        private Button bt_exit;
        private Label lb_bundle;
        private PictureBox pb_glass;
        private TextBox tb_search;
        private Button bt_Bundle1;
        private Button bt_Bundle2;
        private DataGridView dgv_bundles;
    }
}