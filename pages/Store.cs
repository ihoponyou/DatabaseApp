
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
        // int = review id
        private Dictionary<int, ReviewPanel> currentReviews = new Dictionary<int, ReviewPanel>();

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

        private struct ReviewPanel
        {
            public Review AssociatedReview { get; set; }
            public Panel Panel { get; set; }
            public Label AuthorLabel { get; set; }
            public Label ContentLabel { get; set; }

            public ReviewPanel(Review review)
            {
                AssociatedReview = review;

                Panel = new Panel();
                Panel.Height = 90;
                Panel.Width = 150;
                Panel.BackColor = SystemColors.Window;

                AuthorLabel = new Label();
                AuthorLabel.Parent = Panel;
                AuthorLabel.Text = review.Author;

                ContentLabel = new Label();
                ContentLabel.Parent = Panel;
                ContentLabel.Location = new Point(0, 23);
                ContentLabel.AutoSize = false;
                ContentLabel.Size = new Size(140, 67);
                ContentLabel.Text = review.Content;
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
            string order = (ascendingReviews) ? "ASC" : "DESC";
            string query = "SELECT review.review_id, customer_username, review_text, review_is_positive, post_date FROM review " +
                "JOIN customer ON customer.customer_id = review.author_id " +
                $"WHERE game_id = {gameID} " +
                $"ORDER BY review_is_positive {order}";
            var reviews = mainForm.dbm.Query(query);

            reviewList.Controls.Clear();

            if (!reviews.HasRows)
            {
                Label label = new Label();
                label.Text = "No reviews found.";
                label.Width = 150;
                label.Parent = reviewList;
                return;
            }

            while (reviews.Read())
            {
                int reviewID = (int)reviews[0];

                Review review = new Review(reviewID, reviews[1].ToString(), reviews[2].ToString(), (bool)reviews[3], reviews[4].ToString());

                ReviewPanel reviewPanel = new ReviewPanel(review);
                reviewPanel.Panel.Parent = reviewList;
            }
        }

        private void LoadGames(DatabaseManager dbm)
        {
            string condition = $"WHERE game_price < CAST({priceTrackBar.Value} AS MONEY)";
            string order = (ascendingPrice) ? "ASC" : "DESC";
            string query = $"SELECT * FROM game {condition} ORDER BY game_price {order}";
            var results = dbm.Query(query);

            storeList.Controls.Clear();
            inventory.Clear();

            if (!results.HasRows)
                throw new Exception("No games found");

            while (results.Read())
            {
                int gameID = (int)results[0];
                Publisher publisher = Game.GetPublisherFromID(dbm, gameID);
                Dictionary<int, Tag> tags = Game.GetTagsFromID(dbm, gameID);

                // order is wack because im dumb
                Game currentGame = new Game((int)results[0], results[2].ToString(), results[3].ToString(),
                    results[4].ToString(), (decimal)results[5], results[6].ToString(),
                    publisher, tags);

                GamePanel gamePanel = new GamePanel(currentGame);
                gamePanel.Panel.Parent = storeList;
                gamePanel.TitleLabel.Click += (sender, e) => DisplayReviews(gameID);

                inventory.Add(gameID, gamePanel);
            }
        }

        public void RefreshPage()
        {
            Main mainForm = Parent as Main;

            ascendingReviews = true;
            reviewOrderButton.Text = UP_ARROW;
            ascendingPrice = true;
            priceOrderButton.Text = UP_ARROW;

            priceTrackBar.Value = 20;
            priceLabel.Text = $"Under ${priceTrackBar.Value}";

            titleSearchTextBox.Text = "";

            storeList.Controls.Clear();
            // load all games
            LoadGames(mainForm.dbm);
        }

        private void Store_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (priceTrackBar.Value > 0)
                priceLabel.Text = $"Under ${priceTrackBar.Value}";
            else
                priceLabel.Text = "Free";
        }

        private void priceTrackBar_MouseCaptureChanged(object sender, EventArgs e)
        {
            Main mainForm = Parent as Main;

            // reload games
            LoadGames(mainForm.dbm);
        }

        private void reviewOrderButton_Click(object sender, EventArgs e)
        {
            Main mainForm = Parent as Main;

            ascendingReviews = !ascendingReviews;
            reviewOrderButton.Text = (ascendingReviews) ? UP_ARROW : DOWN_ARROW;

            // reload games

        }

        private void priceOrderButton_Click(object sender, EventArgs e)
        {
            Main mainForm = Parent as Main;

            ascendingPrice = !ascendingPrice;
            priceOrderButton.Text = (ascendingPrice) ? UP_ARROW : DOWN_ARROW;

            // reload games
            LoadGames(mainForm.dbm);
        }

        private void titleSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // search by title

        }

        private void mostPopularGameButton_Click(object sender, EventArgs e)
        {
            Main mainForm = Parent as Main;

            // get max number of reviews
            string query = "SELECT game_title, most_popular_game.count FROM game " +
                "JOIN (SELECT * FROM (SELECT game_id, COUNT(game_id) FROM review GROUP BY game_id) reviews_per_game ORDER BY reviews_per_game DESC LIMIT 1) most_popular_game " +
                "ON game.game_id = most_popular_game.game_id;";
            var result = mainForm.dbm.Query(query);

            result.Read();
            MessageBox.Show($"{result[0]} ({result[1]} reviews)", "And the winner is...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result.Close();
        }
    }
}
