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
        public int[] OwnedGames { get; set; }

        public User(int userID, string username, int[] ownedGames)
        {
            UserID = userID;
            Username = username;
            OwnedGames = ownedGames;
        }
    }
}
