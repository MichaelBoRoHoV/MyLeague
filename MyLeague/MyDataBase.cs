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
                return connection.Query<Player>(query).ToList();
            }
        }
        



    }
}
