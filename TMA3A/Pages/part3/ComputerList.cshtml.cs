using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TMA3A.Pages.part3.Helpers;
using TMA3A.Pages.part3.Models;

namespace TMA3A.Pages.part3
{
    public class ComputerListModel : PageModel
    {
        public string[] name;
        public string[] price;
        public string[] image;
        public string[] CPU;
        public string[] Display;
        public string[] Fan;
        public string[] GPU;
        public string[] Hard_Drive;
        public string[] Motherboard;
        public string[] OS;
        public string[] RAM;
        public string[] Soundcard;


        //public List<Components> computers0 = new List<Components>();
        public List<Computers> computers0 = new List<Computers>();
        public List<Computers> computerz;

        public void OnGet()
        {
            ExtractJSON();
        }


        public void ExtractJSON()
        {
            var webClient = new WebClient();
            var url_str = "./Pages/part3/db_files/Computers.json";
            var json = webClient.DownloadString(@url_str);
            var components_json = JsonConvert.DeserializeObject(json);

            string[] arr = ((IEnumerable)components_json).Cast<object>()
                            .Select(x => x.ToString())
                            .ToArray();

            name = new string[9];
            price = new string[9];
            image = new string[9];
            Display = new string[200];
            Fan = new string[200];
            CPU = new string[200];
            GPU = new string[200];
            Hard_Drive = new string[200];
            Motherboard = new string[200];
            OS = new string[200];
            RAM = new string[200];
            Soundcard = new string[200];

            for (int i = 0; i < 1; i++)
            {
                JObject jsonnn = JObject.Parse(arr[i]);

                name[i] = jsonnn["name"].ToString();
                price[i] = jsonnn["price"].ToString();
                image[i] = jsonnn["link"].ToString();
                Display[i] = jsonnn["Display"].ToString();
                Fan[i] = jsonnn["Fan"].ToString();
                CPU[i] = jsonnn["CPU"].ToString();
                GPU[i] = jsonnn["GPU"].ToString();
                Hard_Drive[i] = jsonnn["Hard_Drive"].ToString();
                Motherboard[i] = jsonnn["Motherboard"].ToString();
                OS[i] = jsonnn["OS"].ToString();
                RAM[i] = jsonnn["RAM"].ToString();
                Soundcard[i] = jsonnn["Soundcard"].ToString();

                computers0.Add(new Computers { Id = i.ToString(), Name = name[i], Image = image[i], Price = price[i], CPU = CPU[i], Display = Display[i], Fan=Fan[i], GPU = GPU[i], Hard_Drive = Hard_Drive[i], Motherboard = Motherboard[i], OS = OS[i], RAM = RAM[i], Soundcard = Soundcard[i] });
            }
            computerz = SessionHelper.GetObjectFromJson<List<Computers>>(HttpContext.Session, "computer_details");

            if (computerz == null)
            {
                computerz = new List<Computers>();
                SessionHelper.SetObjectAsJson(HttpContext.Session, "computer_details", computers0);
            }
            else
            {
                SessionHelper.SetObjectAsJson(HttpContext.Session, "computer_details", computers0);
            }
        }

        public Computers find(string id)
        {
            return computerz.Where(p => p.Id == id).FirstOrDefault();
        }

    }
}
