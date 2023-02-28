using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWP_Jahresprojekt
{
    public partial class ChangeTable : Form
    {
        public ChangeTable()
        {
            InitializeComponent();

            SQLInformation.ReadTables();

            for (int i = 0; i < SQLInformation.tables.Count(); i++)
            {
                cb_ChooseTable.Items.Add(SQLInformation.tables[i]);
            }
        }

        private void bt_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_LoadData_Click(object sender, EventArgs e)
        {
            string table = cb_ChooseTable.Text;

            SQLInformation.FillDTV(table);
        }
    }
}
