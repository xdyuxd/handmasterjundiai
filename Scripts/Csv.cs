using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.IO;

namespace handmasterjundiai.Scripts{
    public class Csv {
        public List<string> read (string filename) {
            using (var reader = new StreamReader(filename)){
                var lines = new List<string>();
                while (!reader.EndOfStream){
                    lines.Add(reader.ReadLine());
                }          
                return lines;
            }
        }
    }    
}