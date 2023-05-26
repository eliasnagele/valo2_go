namespace SWP_Jahresprojekt
{
    partial class ChangeTable
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
            this.lb_Table = new System.Windows.Forms.Label();
            this.cb_ChooseTable = new System.Windows.Forms.ComboBox();
            this.dtv_ChangeTable = new System.Windows.Forms.DataGridView();
            this.bt_LoadData = new System.Windows.Forms.Button();
            this.bt_Return = new System.Windows.Forms.Button();
            this.bt_SaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_ChangeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Table
            // 
            this.lb_Table.AutoSize = true;
            this.lb_Table.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Table.ForeColor = System.Drawing.Color.Snow;
            this.lb_Table.Location = new System.Drawing.Point(12, 17);
            this.lb_Table.Name = "lb_Table";
            this.lb_Table.Size = new System.Drawing.Size(64, 25);
            this.lb_Table.TabIndex = 0;
            this.lb_Table.Text = "Table";
            // 
            // cb_ChooseTable
            // 
            this.cb_ChooseTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_ChooseTable.FormattingEnabled = true;
            this.cb_ChooseTable.Location = new System.Drawing.Point(82, 19);
            this.cb_ChooseTable.Name = "cb_ChooseTable";
            this.cb_ChooseTable.Size = new System.Drawing.Size(140, 25);
            this.cb_ChooseTable.TabIndex = 1;
            // 
            // dtv_ChangeTable
            // 
            this.dtv_ChangeTable.BackgroundColor = System.Drawing.Color.Black;
            this.dtv_ChangeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_ChangeTable.Location = new System.Drawing.Point(14, 58);
            this.dtv_ChangeTable.Name = "dtv_ChangeTable";
            this.dtv_ChangeTable.RowTemplate.Height = 25;
            this.dtv_ChangeTable.Size = new System.Drawing.Size(699, 380);
            this.dtv_ChangeTable.TabIndex = 2;
            // 
            // bt_LoadData
            // 
            this.bt_LoadData.BackColor = System.Drawing.Color.Snow;
            this.bt_LoadData.Location = new System.Drawing.Point(228, 19);
            this.bt_LoadData.Name = "bt_LoadData";
            this.bt_LoadData.Size = new System.Drawing.Size(78, 25);
            this.bt_LoadData.TabIndex = 3;
            this.bt_LoadData.Text = "Load data";
            this.bt_LoadData.UseVisualStyleBackColor = false;
            this.bt_LoadData.Click += new System.EventHandler(this.bt_LoadData_Click);
            // 
            // bt_Return
            // 
            this.bt_Return.BackColor = System.Drawing.Color.Orange;
            this.bt_Return.Location = new System.Drawing.Point(731, 9);
            this.bt_Return.Name = "bt_Return";
            this.bt_Return.Size = new System.Drawing.Size(57, 22);
            this.bt_Return.TabIndex = 4;
            this.bt_Return.Text = "Return";
            this.bt_Return.UseVisualStyleBackColor = false;
            this.bt_Return.Click += new System.EventHandler(this.bt_Return_Click);
            // 
            // bt_SaveChanges
            // 
            this.bt_SaveChanges.BackColor = System.Drawing.Color.Lime;
            this.bt_SaveChanges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_SaveChanges.ForeColor = System.Drawing.Color.Black;
            this.bt_SaveChanges.Location = new System.Drawing.Point(731, 403);
            this.bt_SaveChanges.Name = "bt_SaveChanges";
            this.bt_SaveChanges.Size = new System.Drawing.Size(57, 35);
            this.bt_SaveChanges.TabIndex = 5;
            this.bt_SaveChanges.Text = "Save";
            this.bt_SaveChanges.UseVisualStyleBackColor = false;
            this.bt_SaveChanges.Click += new System.EventHandler(this.bt_SaveChanges_Click);
            // 
            // ChangeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_SaveChanges);
            this.Controls.Add(this.bt_Return);
            this.Controls.Add(this.bt_LoadData);
            this.Controls.Add(this.dtv_ChangeTable);
            this.Controls.Add(this.cb_ChooseTable);
            this.Controls.Add(this.lb_Table);
            this.Name = "ChangeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeTable";
            ((System.ComponentModel.ISupportInitialize)(this.dtv_ChangeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_Table;
        private ComboBox cb_ChooseTable;
        private DataGridView dtv_ChangeTable;
        private Button bt_LoadData;
        private Button bt_Return;
        private Button bt_SaveChanges;
    }
}