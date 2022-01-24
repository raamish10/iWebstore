using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TMA3A.Pages.part3.Models
{
    public class Computers 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string CPU { get; set; }
        public string Display { get; set; }
        public string Fan { get; set; }
        public string GPU { get; set; }
        public string Hard_Drive { get; set; }
        public string Motherboard { get; set; }
        public string OS { get; set; }
        public string RAM { get; set; }
        public string Soundcard { get; set; }

    }
}
