using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.IO;

namespace handmasterjundiai.Models{
    public class Player{
        public string Name { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
    }
}