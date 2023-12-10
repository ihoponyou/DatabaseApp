
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DatabaseApp
{
    public class Game
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string IconLink { get; set; }

        public Game()
        {
            GameID = -1;
            Title = string.Empty;
            Description = string.Empty;
            ReleaseDate = string.Empty;
            Price = -1;
        }

        public Game(int gameID, string title, string description, string releaseDate, decimal price, string iconLink)
        {
            GameID = gameID;
            Title = title;
            Description = description;
            ReleaseDate = releaseDate;
            Price = price;
            IconLink = iconLink;
        }

        public static Dictionary<int, Game> GetOwnedGames(DatabaseManager dbm, int userID)
        {
            string query = "SELECT game.game_id, game_title, game_description, release_date, game_price, game_icon_link FROM ownedby " +
                "JOIN game ON ownedby.game_id = game.game_id " +
                $"WHERE ownedby.customer_id = {userID}";

            var results = dbm.Query(query);

            if (results == null)
                throw new Exception("Something went wrong");

            Dictionary<int, Game> ownedGames = new Dictionary<int, Game>();

            while (results.Read())
            {
                Game game = new Game((int) results[0], results[1].ToString(), results[2].ToString(), results[3].ToString(), (decimal) results[4], results[5].ToString());
                ownedGames.Add(game.GameID, game);
            }

            results.Close();

            return ownedGames;
        }
    }
}
