using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace handmasterjundiai.Pages
{
    public class StoreModel : PageModel
    {
        private readonly ILogger<StoreModel> _logger;

        public StoreModel(ILogger<StoreModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
