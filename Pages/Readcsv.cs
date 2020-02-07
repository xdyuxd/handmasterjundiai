using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.IO;

namespace handmasterjundiai.Pages{
    public class Readcsv (string[] args){
        using (var reader = new StreamReader(@"~/playerlist.csv")){
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            List<string> listC = new List<string>();

            while (!reader.EndOfStream){
                var line = reader.ReadLine();
                var values = line.Split(";");

                listA.Add(values[0]);
                listB.Add(values[1]);
                listC.Add(values[2]);
            }
        }
    }    
}