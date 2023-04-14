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
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.lb_bundle = new System.Windows.Forms.Label();
            this.pb_glass = new System.Windows.Forms.PictureBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_Bundle1 = new System.Windows.Forms.Button();
            this.bt_Bundle2 = new System.Windows.Forms.Button();
            this.dgv_bundles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_glass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bundles)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_home
            // 
            this.bt_home.Location = new System.Drawing.Point(12, 45);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(75, 23);
            this.bt_home.TabIndex = 0;
            this.bt_home.Text = "Home";
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(12, 16);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 2;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // lb_bundle
            // 
            this.lb_bundle.AutoSize = true;
            this.lb_bundle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_bundle.Location = new System.Drawing.Point(343, 45);
            this.lb_bundle.Name = "lb_bundle";
            this.lb_bundle.Size = new System.Drawing.Size(99, 32);
            this.lb_bundle.TabIndex = 6;
            this.lb_bundle.Text = "Bundles";
            // 
            // pb_glass
            // 
            this.pb_glass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb_glass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_glass.BackgroundImage")));
            this.pb_glass.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_glass.InitialImage")));
            this.pb_glass.Location = new System.Drawing.Point(630, 12);
            this.pb_glass.Name = "pb_glass";
            this.pb_glass.Size = new System.Drawing.Size(21, 20);
            this.pb_glass.TabIndex = 16;
            this.pb_glass.TabStop = false;
            // 
            // tb_search
            // 
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_search.Location = new System.Drawing.Point(651, 12);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(137, 20);
            this.tb_search.TabIndex = 15;
            // 
            // bt_Bundle1
            // 
            this.bt_Bundle1.Location = new System.Drawing.Point(12, 87);
            this.bt_Bundle1.Name = "bt_Bundle1";
            this.bt_Bundle1.Size = new System.Drawing.Size(367, 182);
            this.bt_Bundle1.TabIndex = 17;
            this.bt_Bundle1.UseVisualStyleBackColor = true;
            this.bt_Bundle1.Click += new System.EventHandler(this.bt_Bundle1_Click);
            // 
            // bt_Bundle2
            // 
            this.bt_Bundle2.Location = new System.Drawing.Point(421, 87);
            this.bt_Bundle2.Name = "bt_Bundle2";
            this.bt_Bundle2.Size = new System.Drawing.Size(367, 182);
            this.bt_Bundle2.TabIndex = 18;
            this.bt_Bundle2.UseVisualStyleBackColor = true;
            this.bt_Bundle2.Click += new System.EventHandler(this.bt_Bundle2_Click);
            // 
            // dgv_bundles
            // 
            this.dgv_bundles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bundles.Location = new System.Drawing.Point(12, 279);
            this.dgv_bundles.Name = "dgv_bundles";
            this.dgv_bundles.RowTemplate.Height = 25;
            this.dgv_bundles.Size = new System.Drawing.Size(776, 159);
            this.dgv_bundles.TabIndex = 19;
            // 
            // Bundles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_bundles);
            this.Controls.Add(this.bt_Bundle2);
            this.Controls.Add(this.bt_Bundle1);
            this.Controls.Add(this.pb_glass);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lb_bundle);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_home);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Bundles";
            this.ShowIcon = false;
            this.Text = "Bundles";
            ((System.ComponentModel.ISupportInitialize)(this.pb_glass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bundles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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