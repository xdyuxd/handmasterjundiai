using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

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

        }
    }
}
