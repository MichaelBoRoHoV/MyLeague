using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MyLeague;
using Newtonsoft.Json;

namespace MyLeagueAPI.Controllers
{
    public class PlayersController : ApiController
    {

        List<Player> players = new List<Player>();


        [Route("Players")]
        [HttpGet]
        public List<Player> GetPlayers()
        {
            players = MyDataBase.GetAllPlayers();
            
            return players; 
        }

        // GET: api/Players
        public List<Player> Get()
        {
            return players;
        }

        // GET: api/Players/5
        public Player Get(int id)
        {
            return players.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/Players
        public void Post(Player val)
        {
            players.Add(val);
        }

        // DELETE: api/Players/5
        public void Delete(int id)
        {
        }
    }
}
