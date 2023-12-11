
using MagcalasCullen_CSCI366_GroupProject;
using System.Diagnostics;

namespace DatabaseApp.pages
{
    public partial class Store : UserControl, IPage
    {
        private const string UP_ARROW = "↑";
        private const string DOWN_ARROW = "↓";

        public string Title { get; }

        private bool ascendingReviews = true;
        private bool ascendingPrice = true;

        // int is associated game id
        private Dictionary<int, GamePanel> inventory = new Dictionary<int, GamePanel>();

        private struct GamePanel
        {
            public Game AssociatedGame { get; set; }
            public Panel Panel { get; set; }
            public LinkLabel TitleLabel { get; set; }

            public GamePanel(Game game)
            {
                AssociatedGame = game;

                Panel = new Panel();
                Panel.Height = 23;
                Panel.Width = 237;
                Panel.BackColor = SystemColors.Window;

                TitleLabel = new LinkLabel();
                TitleLabel.Parent = Panel;
                TitleLabel.Text = game.Title;
                TitleLabel.Dock = DockStyle.Left;
                TitleLabel.AutoSize = false;
                TitleLabel.TextAlign = ContentAlignment.MiddleLeft;

                Label priceLabel = new Label();
                priceLabel.Parent = Panel;
                priceLabel.Text = game.Price.ToString("C");
                priceLabel.AutoSize = false;
                priceLabel.TextAlign = ContentAlignment.MiddleRight;
                priceLabel.Dock = DockStyle.Right;
            }
        }

        public Store()
        {
            Title = "Store";
            InitializeComponent();
        }

        public void DisplayReviews(int gameID)
        {
            Main mainForm = Parent as Main;

            string query = "SELECT review.review_id, customer_username, review_text, review_is_positive, post_date FROM review " +
                "JOIN customer ON customer.customer_id = review.author_id " +
                $"WHERE game_id = {gameID}";
            var reviews = mainForm.dbm.Query(query);

            reviewListLayout.Controls.Clear();

            if (!reviews.HasRows)
            {
                Label label = new Label();
                label.Text = "No reviews found.";
                label.Width = 150;
                label.Parent = reviewListLayout;
            }
        }

        public void RefreshPage()
        {
            Main mainForm = Parent as Main;

            ascendingReviews = true;
            reviewOrderButton.Text = UP_ARROW;
            ascendingPrice = true;
            priceOrderButton.Text = UP_ARROW;

            priceTrackBar.Value = 0;
            priceLabel.Text = "Free";

            titleSearchTextBox.Text = "";

            storeListLayout.Controls.Clear();
            // load all games
            var results = mainForm.dbm.Query("SELECT * FROM game");

            if (!results.HasRows)
                throw new Exception("No games found");

            while (results.Read())
            {
                int gameID = (int)results[0];
                Publisher publisher = Game.GetPublisherFromID(mainForm.dbm, gameID);
                Dictionary<int, Tag> tags = Game.GetTagsFromID(mainForm.dbm, gameID);

                // order is wack because im dumb
                Game currentGame = new Game((int)results[0], results[2].ToString(), results[3].ToString(),
                    results[4].ToString(), (decimal)results[5], results[6].ToString(),
                    publisher, tags);

                GamePanel gamePanel = new GamePanel(currentGame);
                gamePanel.Panel.Parent = storeListLayout;
                gamePanel.TitleLabel.Click += (sender, e) => DisplayReviews(gameID);

                inventory.Add(gameID, gamePanel);
            }
        }

        private void Store_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void priceTrackBar_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (priceTrackBar.Value > 0)
                priceLabel.Text = $"Under ${priceTrackBar.Value}";
            else
                priceLabel.Text = "Free";
        }

        private void reviewOrderButton_Click(object sender, EventArgs e)
        {
            ascendingReviews = !ascendingReviews;
            reviewOrderButton.Text = (ascendingReviews) ? UP_ARROW : DOWN_ARROW;
        }

        private void priceOrderButton_Click(object sender, EventArgs e)
        {
            ascendingPrice = !ascendingPrice;
            priceOrderButton.Text = (ascendingPrice) ? UP_ARROW : DOWN_ARROW;
        }
    }
}
