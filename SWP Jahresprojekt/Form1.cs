namespace SWP_Jahresprojekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_tournament_Click(object sender, EventArgs e)
        {
            tournament tournament = new tournament();
            this.Hide();
            tournament.Show();
        }

        private void bt_news_Click(object sender, EventArgs e)
        {
            news news = new news();
            this.Hide();
            news.Show();
        }

        private void bt_skins_Click(object sender, EventArgs e)
        {
            skins skins = new skins();
            this.Hide();
            skins.Show();
        }

        private void bt_bundles_Click(object sender, EventArgs e)
        {
            Bundles Bundles = new Bundles();
            this.Hide();
            Bundles.Show();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}