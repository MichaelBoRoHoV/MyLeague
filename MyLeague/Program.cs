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

            List<Player> myPlayers = new List<Player>();
            myPlayers = MyDataBase.GetAllPlayers();
            foreach (var item in myPlayers)
            {
                Console.WriteLine($" first name = {item.FirstName} last name = {item.LastName}\n");
            }
                Console.ReadLine();

            
        }
    }
}