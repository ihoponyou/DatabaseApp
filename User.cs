using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    public class User
    {
        public string Username { get; set; }
        public int UserID { get; set; }
        public Dictionary<int, Game> OwnedGames { get; set; }
        public bool IsAdmin { get => UserID == -1; }

        public User(int userID, string username, Dictionary<int, Game> ownedGames)
        {
            UserID = userID;
            Username = username;
            OwnedGames = new Dictionary<int, Game>();
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
                int gameID = (int)results[0];
                Publisher publisher = Game.GetPublisherFromID(dbm, gameID);
                Dictionary<int, Tag> tags = Game.GetTagsFromID(dbm, gameID);

                Game game = new Game((int)results[0], results[1].ToString(), results[2].ToString(),
                    results[3].ToString(), (decimal)results[4], results[5].ToString(),
                    publisher, tags);

                ownedGames.Add(gameID, game);
            }

            results.Close();

            return ownedGames;
        }
    }
}
