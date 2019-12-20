using System;
using System.Text;
using System.Data.SqlClient;
using MyLeague;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;

namespace SqlServerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                using (IDbConnection connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=main_db_1;Trusted_Connection=True;")){
                    Console.WriteLine("you connected");
                    var output = connection.Query<string>($"select firstname from players where id = 1");
                    var output2 = connection.Query<Player>($"select * from players").ToList();
                    //connection.Execute($"update players set jersey = 3 where id = 1");
                          
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}