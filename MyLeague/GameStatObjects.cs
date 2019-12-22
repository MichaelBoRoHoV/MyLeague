using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeague
{
    public class GameStatObjects
    {
        public List<Player> Players { get; set; }
        public List<Game> Games { get; set; }
        public List<GameStat> GamesStats { get; set; }
    }

    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Jersey { get; set; }
    }

    public class Game
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
    }

    public class GameStat
    {
        public int PlayerID { get; set; }
        public int Points { get; set; }
        public int Rebounds { get; set; }
        public int Assists { get; set; }
        public int Steals { get; set; }
        public int Blocks { get; set; }
        public int ThreePointMade { get; set; }
        public int FieldGoalMade { get; set; }
        public int FieldGoalAttempts { get; set; }
        public int FG_Percentage { get; set; }
        public int FreeThrowMade { get; set; }
        public int FreeThrowAttempts { get; set; }
        public int FT_Percentage { get; set; }
        public int Turnovers { get; set; }
        public int GameID { get; set; }

    }

}
