using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.IO;

namespace handmasterjundiai.Models{
    public class player{
        public string name { get; set; }
        public string team { get; set; }
        public string position { get; set; }
        public string image { get; set; }

    }
}