
using Microsoft.VisualBasic.ApplicationServices;
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
        public Publisher Publisher { get; init; }
        public Dictionary<int, Tag> Tags { get; set; }

        public Game(int gameID, string title, string description, string releaseDate, decimal price, string iconLink, Publisher publisher, Dictionary<int, Tag> tags)
        {
            GameID = gameID;
            Title = title;
            Description = description;
            ReleaseDate = releaseDate;
            Price = price;
            IconLink = iconLink;
            Publisher = publisher;
            Tags = tags;
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
                int gameID = (int) results[0];
                Publisher publisher = GetPublisherFromID(dbm, gameID);
                Dictionary<int, Tag> tags = GetTagsFromID(dbm, gameID);

                Game game = new Game((int) results[0], results[1].ToString(), results[2].ToString(),
                    results[3].ToString(), (decimal) results[4], results[5].ToString(),
                    publisher, tags);

                ownedGames.Add(gameID, game);
            }

            results.Close();

            return ownedGames;
        }

        public static Publisher GetPublisherFromID(DatabaseManager dbm, int gameID)
        {
            string query = "SELECT publisher.publisher_id, publisher_name, publisher_description FROM publisher " +
                "JOIN game ON game.publisher_id = publisher.publisher_id " +
                $"WHERE game_id = {gameID}";

            var results = dbm.Query(query);

            if (results == null)
                throw new Exception("Something went wrong");
            if (!results.HasRows)
                throw new Exception($"No publisher for game with id: {gameID}");

            results.Read();
            Publisher publisher = new Publisher((int)results[0], results[1].ToString(), results[2].ToString());
            results.Close();

            return publisher;
        }

        public static Dictionary<int, Tag> GetTagsFromID(DatabaseManager dbm, int gameID)
        {
            string query = "SELECT tag.tag_id, tag_name, tag_description FROM tag " +
                "JOIN taggedas ON tag.tag_id = taggedas.tag_id " +
                $"WHERE taggedas.game_id = {gameID}";

            var results = dbm.Query(query);

            if (results == null)
                throw new Exception("Something went wrong");

            Dictionary<int, Tag> tags = new Dictionary<int, Tag>();

            while (results.Read())
            {
                Tag tag = new Tag( (int) results[0], results[1].ToString(), results[2].ToString() );
                tags.Add((int)results[0], tag);
            }

            results.Close();

            return tags;
        }
    }
}
