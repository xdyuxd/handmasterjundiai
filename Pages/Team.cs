using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using handmasterjundiai.Scripts;
using handmasterjundiai.Models;



namespace handmasterjundiai.Pages
{
    public class TeamModel : PageModel
    {
        private readonly ILogger<TeamModel> _logger;

        public TeamModel(ILogger<TeamModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var reader = new Csv();
            var players = reader.read("playerlist.csv");

            Player[] f30 = null;
            Player[] m35 = null;
            Player[] m42 = null;

            for (int i = 0; i < players.Count; i++){
                String[] fullplayer = players[i].Split(";");
                var player = new Player();
                player.Name = fullplayer[0];
                player.Team = fullplayer[1];
                player.Position = fullplayer[2];
                player.Image = fullplayer[3];
                
                switch (player.Team)
                {
                    case "30F":
                        f30.Append(player);
                        break;
                    case "35M":
                        m35.Append(player);
                        break;
                    default:
                        m42.Append(player);
                        break;
                }
            }
        }
    }
}
