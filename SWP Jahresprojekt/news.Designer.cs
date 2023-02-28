namespace SWP_Jahresprojekt
{
    partial class news
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
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.lb_headline = new System.Windows.Forms.Label();
            this.tb_newsOne = new System.Windows.Forms.TextBox();
            this.pb_newsOne = new System.Windows.Forms.PictureBox();
            this.pb_newsTwo = new System.Windows.Forms.PictureBox();
            this.tb_newsTwo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newsOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newsTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_home
            // 
            this.bt_home.Location = new System.Drawing.Point(38, 41);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(75, 23);
            this.bt_home.TabIndex = 0;
            this.bt_home.Text = "Home";
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(38, 12);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 2;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // lb_headline
            // 
            this.lb_headline.AutoSize = true;
            this.lb_headline.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_headline.Location = new System.Drawing.Point(347, 31);
            this.lb_headline.Name = "lb_headline";
            this.lb_headline.Size = new System.Drawing.Size(130, 32);
            this.lb_headline.TabIndex = 6;
            this.lb_headline.Text = "Überschrift";
            // 
            // tb_newsOne
            // 
            this.tb_newsOne.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_newsOne.Location = new System.Drawing.Point(38, 114);
            this.tb_newsOne.Multiline = true;
            this.tb_newsOne.Name = "tb_newsOne";
            this.tb_newsOne.ReadOnly = true;
            this.tb_newsOne.Size = new System.Drawing.Size(326, 148);
            this.tb_newsOne.TabIndex = 7;
            // 
            // pb_newsOne
            // 
            this.pb_newsOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_newsOne.Location = new System.Drawing.Point(431, 114);
            this.pb_newsOne.Name = "pb_newsOne";
            this.pb_newsOne.Size = new System.Drawing.Size(326, 148);
            this.pb_newsOne.TabIndex = 8;
            this.pb_newsOne.TabStop = false;
            // 
            // pb_newsTwo
            // 
            this.pb_newsTwo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_newsTwo.Location = new System.Drawing.Point(431, 290);
            this.pb_newsTwo.Name = "pb_newsTwo";
            this.pb_newsTwo.Size = new System.Drawing.Size(326, 148);
            this.pb_newsTwo.TabIndex = 10;
            this.pb_newsTwo.TabStop = false;
            // 
            // tb_newsTwo
            // 
            this.tb_newsTwo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_newsTwo.Location = new System.Drawing.Point(38, 290);
            this.tb_newsTwo.Multiline = true;
            this.tb_newsTwo.Name = "tb_newsTwo";
            this.tb_newsTwo.ReadOnly = true;
            this.tb_newsTwo.Size = new System.Drawing.Size(326, 148);
            this.tb_newsTwo.TabIndex = 9;
            // 
            // news
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_newsTwo);
            this.Controls.Add(this.tb_newsTwo);
            this.Controls.Add(this.pb_newsOne);
            this.Controls.Add(this.tb_newsOne);
            this.Controls.Add(this.lb_headline);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_home);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "news";
            this.ShowIcon = false;
            this.Text = "news";
            ((System.ComponentModel.ISupportInitialize)(this.pb_newsOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newsTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_home;
        private Button bt_exit;
        private Label lb_headline;
        private TextBox tb_newsOne;
        private PictureBox pb_newsOne;
        private PictureBox pb_newsTwo;
        private TextBox tb_newsTwo;
    }
}