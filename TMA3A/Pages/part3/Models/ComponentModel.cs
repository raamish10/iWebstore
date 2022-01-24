using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TMA3A.Pages.part3.Helpers;
using TMA3A.Pages.part3.Models;
using System.Collections;
using System.Net;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Timers;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TMA3A.Pages.part3.Models
{
    public class ComponentModel
    {
        public List<Components> Component = new List<Components>();

        public ComponentModel()
        {
            //Component = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "component_list");

            Component = new List<Components>()
            {
                new Components
                {
                    Id = "0",
                    Name = "name00",
                    Price = "$45",
                    Image = "https://multimedia.bbycastatic.ca/multimedia/products/500x500/157/15778/15778670.jpg"
                },
                new Components
                {
                    Id = "1",
                    Name = "name11",
                    Price = "$45",
                    Image = "https://multimedia.bbycastatic.ca/multimedia/products/500x500/157/15778/15778670.jpg"
                },
                new Components
                {
                    Id = "2",
                    Name = "name22",
                    Price = "$45",
                    Image = "https://multimedia.bbycastatic.ca/multimedia/products/500x500/157/15778/15778670.jpg"
                },
                new Components
                {
                    Id = "3",
                    Name = "name33",
                    Price = "$45",
                    Image = "https://multimedia.bbycastatic.ca/multimedia/products/500x500/157/15778/15778670.jpg"
                },
                new Components
                {
                    Id = "4",
                    Name = "name44",
                    Price = "$45",
                    Image = "https://multimedia.bbycastatic.ca/multimedia/products/500x500/157/15778/15778670.jpg"
                },
                new Components
                {
                    Id = "5",
                    Name = "name55",
                    Price = "$45",
                    Image = "https://multimedia.bbycastatic.ca/multimedia/products/500x500/157/15778/15778670.jpg"
                }


            };

        }


        public Components find(string id)
        {
            return Component.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
