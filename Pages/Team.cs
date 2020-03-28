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
            var players = reader.read((string) DotEnv.env["PLAYER"]);

            List<Player> f30 = new List<Player>();
            List<Player>  m35 = new List<Player>();
            List<Player>  m42 = new List<Player>();

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
                        f30.Add(player);
                        break;
                    case "35M":
                        m35.Add(player);
                        break;
                    default:
                        m42.Add(player);
                        break;
                }
            }
            
            ViewData["f30"] = f30;
            ViewData["m35"] = m35;
            ViewData["m42"] = m42;
        }
    }
}
