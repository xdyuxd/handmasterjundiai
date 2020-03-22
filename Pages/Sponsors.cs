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
    public class SponsorsModel : PageModel
    {
        private readonly ILogger<SponsorsModel> _logger;

        public SponsorsModel(ILogger<SponsorsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var reader = new Csv();
            var sponsors = reader.read((string) DotEnv.env["SPONSOR"]);

            List<Sponsor> sponsorlist = new List<Sponsor>();

                foreach (var item in sponsors) {
                    String[] fullsponsor = item.Split(";");
                    Sponsor sponsor = new Sponsor(){
                        Name = fullsponsor[0],
                        Url = fullsponsor[1],
                        Image = fullsponsor[2]
                    };

                    sponsorlist.Add(sponsor);

                }

                ViewData["sponsorlist"] = sponsorlist;

        }
    }
}
