using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TMA3A.Pages.part4.Models
{
    public class Item
    {
        public Components Component { get; set; }
        public int Quantity { get; set; }
    }
}
