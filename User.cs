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
    }
}
