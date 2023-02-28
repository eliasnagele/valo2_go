namespace SWP_Jahresprojekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SQLInformation.CreateDB();
            SQLInformation.CreateTables();
        }

        private void bt_tournament_Click(object sender, EventArgs e)
        {
            tournament tournament = new tournament();
            this.Hide();
            tournament.ShowDialog();
            this.Show();
        }

        private void bt_news_Click(object sender, EventArgs e)
        {
            news news = new news();
            this.Hide();
            news.ShowDialog();
            this.Show();
        }

        private void bt_skins_Click(object sender, EventArgs e)
        {
            skins skins = new skins();
            this.Hide();
            skins.ShowDialog();
            this.Show();
        }

        private void bt_bundles_Click(object sender, EventArgs e)
        {
            Bundles Bundles = new Bundles();
            this.Hide();
            Bundles.ShowDialog();
            this.Show();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void bt_EditTables_Click(object sender, EventArgs e)
        {
            ChangeTable changetable = new ChangeTable();
            this.Hide();
            changetable.ShowDialog();
            this.Show();
        }
    }
}