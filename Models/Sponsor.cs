using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.IO;

namespace handmasterjundiai.Models{
    public class Sponsor{
        public string Name { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
    }
}