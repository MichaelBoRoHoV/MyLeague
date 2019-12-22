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
            List<Game> myGames = new List<Game>();
            myGames = MyDataBase.GetAllGames();
            foreach (var item in myGames)
            {
                string winnerTeam;
                if (item.HomeTeamScore > item.AwayTeamScore)
                {
                    winnerTeam = item.HomeTeam;
                }
                else
                {
                    winnerTeam = item.AwayTeam;
                }

                Console.WriteLine($" {item.HomeTeam} vs {item.AwayTeam} in {item.Date} and " +
                    $"{winnerTeam} won the game");
                Console.ReadLine();
            }
            List<GameStat> gameStats = new List<GameStat>();
            gameStats = MyDataBase.GetPlayersGameStats(1);
            foreach (var item in gameStats)
            {
                int test = item.FT_Percentage;
                Console.WriteLine($"Points { item.Points}  FGM/A  { item.FT_Percentage}");
            }
        }
    }
}