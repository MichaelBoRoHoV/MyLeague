using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MyLeague
{
    class MyDataBase
    {
        
        public static List<Player> GetAllPlayers ()
        {
            string query = $"select * from players";

            using (IDbConnection connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=main_db_1;Trusted_Connection=True;"))
            {
                var list = connection.Query<Player>(query).ToList();
                connection.Close();
                return list; 
            }
        }

        public static List<Game> GetAllGames()
        {
            string query = $"select * from games";

            using (IDbConnection connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=main_db_1;Trusted_Connection=True;"))
            {
                var list = connection.Query<Game>(query).ToList();
                connection.Close();
                return list;
            }
        }

        public static List<GameStat> GetPlayersGameStats(int gameID)
        {
            string query = $"select * from gameStats where playerID = {gameID}";
            using (IDbConnection connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=main_db_1;Trusted_Connection=True;"))
            {
                var list = connection.Query<GameStat>(query).ToList();
                connection.Close();
                return list;
            }

        }



    }
}
